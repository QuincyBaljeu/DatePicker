using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatePicker
{
    public partial class Form1 : Form
    {
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
            Console.WriteLine(NameTextBox.Text + ", chose: " + DateTimePickerField.Value);
        }
    }
}
