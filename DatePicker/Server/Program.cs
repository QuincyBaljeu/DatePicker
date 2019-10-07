using System;
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
        static void Main(string[] args)
        {
            /*
             * Stijn is een pannenkoek
             */


            IPAddress LocalHost;

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
            NetworkStream networkStream = handledClient.GetStream();

            if (ServerUtil.ReadTextMessage(networkStream) == "Event")
            {
                HandleEvent(obj);
            }
            else if(ServerUtil.ReadTextMessage(networkStream) == "Picker")
            {
                HandlePicker(obj);
            }
            else
            {
                Console.WriteLine("Error identifying client");
            }

        }

        public static void HandleEvent(object obj)
        {

        }

        public static void HandlePicker(object obj)
        {


        }
    }
}
