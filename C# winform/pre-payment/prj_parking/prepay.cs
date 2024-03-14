using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace prj_parking
{
    public partial class prepay : Form
    {
        string selectedCarNumber;
        private MySqlConnection connection;
        Form num_searchinga = new num_searching(); 
        int cost; // 비용 산출을 위한 변수
        public prepay(string carNumber)
        {
            InitializeComponent();
            selectedCarNumber = carNumber;
            string connectionString = "Server=127.0.0.1;Database=plate;Uid=root;Pwd=1234;";
            connection = new MySqlConnection(connectionString);
            //senderSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //senderSocket.Connect("10.10.23.183", 33331);
        }

        private void prepay_Load(object sender, EventArgs e) //폼 로드 시 이전 폼에서 선택한 차량의 데이터 표시
        {
            textCarNum.Text = selectedCarNumber;
            DateTime entryTime = GetEntryTime(selectedCarNumber);
            DateTime exitTime = GetExitTime(selectedCarNumber);
            textInTime.Text = entryTime.ToString();
            textOutTime.Text = exitTime.ToString();
            TimeSpan duration = exitTime - entryTime;
            double totalMinutes = duration.TotalMinutes;
            int totalHalfHours = (int)Math.Floor(totalMinutes / 30);
            int rate = 500;
            cost = totalHalfHours * rate;        
            string durationStirng = $"{duration.Days * 24 + duration.Hours}시간 {duration.Minutes}분 {duration.Seconds}초";
            usageTime.Text = durationStirng;
            parkingFee.Text = cost.ToString("C0");
        }
        private DateTime GetEntryTime(string carNumber) //MySQL에서 입차시간 불러오기
        {
            string query = "SELECT entry_time FROM plate WHERE car_num = @carNumber";
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            using(MySqlCommand comm = new MySqlCommand(query, connection))
            {
                comm.Parameters.AddWithValue("@carNumber", carNumber);
                return (DateTime) comm.ExecuteScalar();
            }
        }
        private DateTime GetExitTime(string carNumber) //MySQL에서 출차시간 불러오기
        {
            string query = "SELECT pexit_time FROM plate WHERE car_num = @carNumber";
            using (MySqlCommand comm = new MySqlCommand(query, connection))
            {
                comm.Parameters.AddWithValue("@carNumber", carNumber);
                
                object result = comm.ExecuteScalar();
                return Convert.ToDateTime(result);
            }
        }
        private void socket_connect(object sender, EventArgs e) // 결제 금액이 있을 경우 결제 데이터를 정산 프로그램에 전송
        {          
            //senderSocket.Connect("10.10.23.183", 33331);
            if (cost <= 0)
            {
                MessageBox.Show("결제할 금액이 없습니다");
            }
            else
            {
                if (string.IsNullOrEmpty(textCarNum.Text))
                {
                    MessageBox.Show("차량 번호를 입력해주세요.");
                    return;
                }
                Form payment = new payment(connection, parkingFee.Text, textCarNum.Text, this);
                payment.Show();
                this.Close();
            }
        }
    }
}
