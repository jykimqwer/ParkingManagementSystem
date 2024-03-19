using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_parking
{
    public partial class payment : Form
    {
        private MySqlConnection connection;
        private string cost, carNumber;
        private prepay prepayForm;
        Socket senderSocket;

        public payment(MySqlConnection connection, string cost, string carNumber, prepay prepayForm)
        {
            InitializeComponent();
            this.connection = connection;
            this.cost = cost;
            this.carNumber = carNumber;
            this.prepayForm = prepayForm;
            senderSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            label1.Text = "사전결제금액";
            label2.Text = cost;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("결제되었습니다.", "결제");
            senderSocket.Connect("192.168.200.103", 33332);
            string costString = cost.ToString().Replace(CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol, "");
            string carNumString = carNumber;
            string sendData = $"{carNumString},{costString}";
            byte[] byte1 = Encoding.UTF8.GetBytes(sendData);
            senderSocket.Send(byte1);
            num_searching num_SearchingForm = new num_searching();
            num_SearchingForm.Show();
            this.Close();
        }
    }
}
