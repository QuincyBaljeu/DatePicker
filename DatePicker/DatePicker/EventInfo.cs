using Server;
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
    public partial class EventInfo : Form
    {
        TcpClient Client;
        public EventInfo()
        {
            InitializeComponent();
            Client = new TcpClient("127.0.0.1", 6666);
            ServerUtil.WriteTextMessage(Client.GetStream(), "Event");
        }
    }
}
