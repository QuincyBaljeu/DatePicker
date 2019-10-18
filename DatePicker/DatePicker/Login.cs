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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Btn_AddAvailability_MouseClick(object sender, MouseEventArgs e)
        {
            Picker Picker = new Picker();
            Picker.Show();
            this.Hide();
        }

        private void Btn_CreateEvent_Click(object sender, EventArgs e)
        {
            EventInfo EventInfo = new EventInfo();
            EventInfo.Show();
            this.Hide();
        }

        private void Txt_AvailabilityName_MouseClick(Object sender, MouseEventArgs e)
        {
            Txt_AvailabilityName.Clear();
            Txt_AvailabilityName.ForeColor = Color.Black;
        }
    }
}
