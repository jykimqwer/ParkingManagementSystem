using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO.Ports;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace prj_gui
{
    public partial class payment : Form
    {
        private MySqlConnection connection;
        private string cost;
        private billing billingForm;

        public payment(MySqlConnection connection, string cost, billing billingForm)
        {
            InitializeComponent();
            this.connection = connection;
            this.cost = cost;
            this.billingForm = billingForm;
            label1.Text = cost;
        }

        private void serial()
        {
            //SerialPort serialPort = new SerialPort();
            //serialPort.PortName = "COM4";
            //serialPort.BaudRate = 115200;
            //serialPort.Open();
            //serialPort.Write("2");
            //serialPort.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            billingForm.insert_data();
            MessageBox.Show("결제되었습니다.", "결제");
            serial();
            billingForm.reset_Data();
            billingForm.Show();
            this.Close();
        }
    }
}
