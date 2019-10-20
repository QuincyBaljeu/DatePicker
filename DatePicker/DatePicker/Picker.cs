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
    public partial class Picker : Form
    {
        TcpClient Client;
        public Picker()
        {
            InitializeComponent();   
            Client = new TcpClient("127.0.0.1", 6666);
            ServerUtil.WriteTextMessage(Client.GetStream(), "Picker");
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine(DateTimePickerField.Value);
            Console.ReadLine();
        }

        private void NameTextBox_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = "";
            NameTextBox.ForeColor = Color.Black;
        }

        private void Btn_AddDate_Click(object sender, EventArgs e)
        {
          
            if (NameTextBox.Text != null && DateTimePickerField.Value != null && Client!=null && EventNameField != null)
            {
                ServerUtil.WriteTextMessage(Client.GetStream(), String.Format("{0}-{1}-{2}",EventNameField.Text, NameTextBox.Text, DateTimePickerField.Value));
            }

            Login login = new Login();
            login.Show();
            this.Hide();

           
        }

        private void EventNameField_Click(object sender, EventArgs e)
        {
            EventNameField.Text = "";
            EventNameField.ForeColor = Color.Black;
        }
    }
}
