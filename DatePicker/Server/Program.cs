﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
    class Program
    {
        public static List<Event> Events;

        static void Main(string[] args)
        {
            /*
             * Stijn is een pannenkoek
             */

            IPAddress LocalHost;
            Events = new List<Event>();

            IPAddress.TryParse("127.0.0.1", out LocalHost);
            TcpListener TcpListener = new TcpListener(LocalHost, 6666);

            TcpListener.Start();

            while (true)
            {
                TcpClient client = TcpListener.AcceptTcpClient();
                Console.WriteLine("Connected!");
                Thread thread = new Thread(HandleClient);
                thread.Start(client);
            }

        }

        

        public static void HandleClient(object obj)
        {
            TcpClient handledClient = obj as TcpClient;
            NetworkStream NetworkStream = handledClient.GetStream();


            String ClientType = ServerUtil.ReadTextMessage(NetworkStream);
            Console.WriteLine(ClientType);

            if(ClientType == "Picker")
            {
                HandlePicker(obj);
            }
            else if(ClientType == "Event")
            {
                HandleEvent(obj);
            }
            else
            {
                Console.WriteLine("Error identifying client");
            }

        }
        
        public static void HandlePicker(object obj)
        {
            TcpClient HandledClient = obj as TcpClient;
            NetworkStream NetworkStream = HandledClient.GetStream();

            //Console.WriteLine(ServerUtil.ReadTextMessage(NetworkStream));

            char[] Seperator = { '-' };
            Int32 Count = 3;

            String[] Responses = ServerUtil.ReadTextMessage(NetworkStream).Split(Seperator, Count, StringSplitOptions.None);

            String EventNamePicked = Responses[0];
            String PickerName = Responses[1];
            String DatePicked = Responses[2];

            Console.WriteLine(EventNamePicked);

            if (Events.ToList().Count == 0)
            {
                Console.WriteLine("NO___");
            }
            else
            {
                Console.WriteLine("YES____");
            }

            /*
            IEnumerable<Event> EventsFound = from e in Events
                                             where e.EventName == EventNamePicked
                                             select e;

             */

           
            foreach(Event e in Events)
            {
                Console.WriteLine(e.EventName);
                Console.WriteLine(EventNamePicked);
                if (e.EventName == EventNamePicked){
                    Console.WriteLine("godzijdank");
                }

            }
        }

        public static void HandleEvent(object obj)
        {
            TcpClient HandledClient = obj as TcpClient;
            NetworkStream NetworkStream = HandledClient.GetStream();

            String EventName = ServerUtil.ReadTextMessage(NetworkStream);
            Events.Add(new Event(EventName));

            foreach(Event forEvent in Events)
            {
                Console.WriteLine("Event found");
                Console.WriteLine(forEvent.EventName);
            }

            Console.WriteLine("Yeet");

        }

    }
}
