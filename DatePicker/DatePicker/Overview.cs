﻿using Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatePicker
{
    public partial class Overview : Form
    {
        TcpClient Client;
        public Overview()
        {
            InitializeComponent();
            Client = new TcpClient("127.0.0.1", 6666);
            ServerUtil.WriteTextMessage(Client.GetStream(), "Info");
        }

        private void ButtonGetData_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Getting data");
            ServerUtil.WriteTextMessage(Client.GetStream(), EventNameInfo.Text);

            String Datareceived = ServerUtil.ReadTextMessage(Client.GetStream());

            Console.WriteLine("yeeeeeet" + Datareceived);
        }
    }
}
