using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;

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
                

            }

        }

        
    }
}
