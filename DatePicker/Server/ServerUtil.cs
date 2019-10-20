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

        //Send message to stream
        public static void WriteTextMessage(NetworkStream stream, string message)
        {
            StreamWriter streamwriter = new StreamWriter(stream, encoding);
            streamwriter.WriteLine(message);
            streamwriter.Flush();
        }

        //Read message from stream
        public static string ReadTextMessage(NetworkStream stream)
        {
            StreamReader streamreader = new StreamReader(stream, encoding);
            return streamreader.ReadLine();
        }
    }


}
