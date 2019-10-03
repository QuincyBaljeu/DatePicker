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
    public partial class Form1 : Form
    {
        TcpClient Client;
        public Form1()
        {
            InitializeComponent();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine(DateTimePickerField.Value);
            Console.ReadLine();
        }

        private void NameTextBox_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = "";
        }

        private void AddDateButton_Click(object sender, EventArgs e)
        {
            ServerUtil.WriteTextMessage(Client.GetStream(), NameTextBox.Text + " " + DateTimePickerField.Value);
     

        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            Client = new TcpClient("127.0.0.1", 6666);
        }
    }
}
