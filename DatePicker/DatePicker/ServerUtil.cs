using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class ServerUtil
    {
        public static Encoding encoding = Encoding.UTF8;

        public static void WriteTextMessage(NetworkStream stream, string message)
        {
            StreamWriter streamwriter = new StreamWriter(stream, encoding);
            streamwriter.WriteLine(message);
            streamwriter.Flush();
        }

        public static string ReadTextMessage(NetworkStream stream)
        {
            StreamReader streamreader = new StreamReader(stream, encoding);
            try
            {
                return streamreader.ReadLine();

            } catch(IOException e)
            {
                Console.WriteLine("User disconnected");
            }

            return "";
         
        }
    }


}
