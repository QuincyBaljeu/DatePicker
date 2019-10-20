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

        private void Txt_EventName_Click(object sender, EventArgs e)
        {
            Txt_EventName.Clear();
            Txt_EventName.ForeColor = Color.Black;
        }

        private void Btn_SetEventName_Click(object sender, EventArgs e)
        {
            ServerUtil.WriteTextMessage(Client.GetStream(), Txt_EventName.Text);
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
