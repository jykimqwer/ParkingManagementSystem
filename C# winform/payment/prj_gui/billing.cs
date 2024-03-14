using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Diagnostics;
using System.Collections;
using System.Reflection.Emit;
using System.Net;
using Org.BouncyCastle.Utilities.Collections;

namespace prj_gui
{
    public partial class billing : Form
    {
        private MySqlConnection connection;
        private MySqlDataReader reader;
        private TcpClient clientSocket;
        private NetworkStream Stream;
        string preCarNum, preCost;
        int prePayment, cost;
        private Dictionary<string, string> prePayData = new Dictionary<string, string>();
        public billing(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            prePayListening();
            StartListening(); // 데이터 수신 대기 시작
            reset_Data();
        }
        public void insert_data() // Payment 폼에서 결제완료 버튼 누르면 billing폼의 정보를 db로 전송.
        {
            string query1 = "INSERT INTO cplate(car_num, entry_time, exit_time, usage_time, parking_fee) VALUES (@carNum, @entryTime, @exitTime, @usageTime, @parkingFee)";
            if (connection.State != ConnectionState.Open)
            {
                connection.Open(); // 데이터베이스 연결이 열려 있지 않으면 연결을 열기
                using (MySqlCommand com = new MySqlCommand(query1, connection))
                {
                    com.ExecuteNonQuery();
                }
            }
        }
        /*private void UpdateForm(string data) // 데이터베이스에서 데이터 읽어온 후 이용시간 및 금액 조회
        {
            string[] parts = data.Split(",");
            if (parts.Length == 3)
            {
                string carNum = parts[0];
                DateTime entryTime = DateTime.Parse(parts[1]);
                DateTime exitTime = DateTime.Parse(parts[2]);

                TimeSpan duration = exitTime - entryTime;
                double totalMinutes = duration.TotalMinutes;
                int totalHalfHours = (int)Math.Floor(totalMinutes / 30);
                int rate = 500;
                cost = totalHalfHours * rate;
                if (prePayData.ContainsKey(carNum))
                {
                    string prePaymentStr = prePayData[carNum];
                    //int.TryParse(prePaymentStr, out int prePayment);
                    prePayment = int.Parse(prePaymentStr);
                    cost -= prePayment + 500;
                    if (cost < 0)
                    {
                        cost = 0;
                    }
                }
                string durationStirng = $"{duration.Days * 24 + duration.Hours}시간 {duration.Minutes}분 {duration.Seconds}초";
                // 폼에 텍스트 표시
                this.Invoke((MethodInvoker)delegate
                {
                    number.Text = carNum;
                    inTime.Text = entryTime.ToString();
                    outTime.Text = exitTime.ToString();
                    usageTime.Text = durationStirng;
                    if (cost <= 0 && prePayment <= 0)     // 무료차량(사전정산 금액x, 정산 금액x)
                    {
                        parkingFee.Text = cost.ToString("C0");
                        serial();
                    }
                    else if (cost >= 0 && prePayment <= 0) // 사전정산을 하지 않은 차량
                    {
                        parkingFee.Text = cost.ToString("C0");
                    }
                    else if (cost >= 0 && prePayment < cost) // 사전정산 이후 추가 요금 발생 차량
                    {
                        parkingFee.Text = cost.ToString("C0") + $"(사전 정산 금액 : {prePayment}원)";
                    }
                    else if (cost <= 0 && prePayment >= cost) // 사전정산 이후 추가 요금 발생 안된 차량
                    {
                        parkingFee.Text = "사전 정산 차량입니다.";
                        serial();
                    }
                });
                // 폼에 표시된 데이터를 데이터베이스에 저장.
                string query = "INSERT INTO cplate(car_num, entry_time, exit_time, usage_time, parking_fee) VALUES(@carNum, @entryTime, @exitTime, @usageTime, @parkingFee)";
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open(); // 데이터베이스 연결이 열려 있지 않으면 연결을 열기
                    using (MySqlCommand com = new MySqlCommand(query, connection))
                    {
                        com.Parameters.AddWithValue("@carNum", carNum);
                        com.Parameters.AddWithValue("@entryTime", entryTime);
                        com.Parameters.AddWithValue("@exitTime", exitTime);
                        com.Parameters.AddWithValue("@usageTime", durationStirng);
                        com.Parameters.AddWithValue("@parkingFee", cost);
                        com.ExecuteNonQuery();
                    }
                }
            }
        }*/
        private async void UpdateForm(string data) // 데이터베이스에서 데이터 읽어온 후 이용시간 및 금액 조회
        {
            string[] parts = data.Split(",");
            if (parts.Length == 3)
            {
                string carNum = parts[0];
                DateTime entryTime = DateTime.Parse(parts[1]);
                DateTime exitTime = DateTime.Parse(parts[2]);

                TimeSpan duration = exitTime - entryTime;
                double totalMinutes = duration.TotalMinutes;
                int totalHalfHours = (int)Math.Floor(totalMinutes / 30);
                int rate = 500;
                cost = totalHalfHours * rate;
                if (prePayData.ContainsKey(carNum))
                {
                    string prePaymentStr = prePayData[carNum];
                    //int.TryParse(prePaymentStr, out int prePayment);
                    prePayment = int.Parse(prePaymentStr);
                    cost -= prePayment + 500;
                    if (cost < 0)
                    {
                        cost = 0;
                    }
                }
                string durationStirng = $"{duration.Days * 24 + duration.Hours}시간 {duration.Minutes}분 {duration.Seconds}초";
                // 폼에 텍스트 표시
                this.Invoke((MethodInvoker)delegate
                {
                    number.Text = carNum;
                    inTime.Text = entryTime.ToString();
                    outTime.Text = exitTime.ToString();
                    usageTime.Text = durationStirng;
                    if (cost <= 0 && prePayment <= 0)     // 무료차량(사전정산 금액x, 정산 금액x)
                    {
                        parkingFee.Text = cost.ToString("C0");
                        serial();
                    }
                    else if (cost >= 0 && prePayment <= 0) // 사전정산을 하지 않은 차량
                    {
                        parkingFee.Text = cost.ToString("C0");
                    }
                    else if (cost >= 0 && prePayment>0) // 사전정산 이후 추가 요금 발생 차량
                    {
                        parkingFee.Text = cost.ToString("C0") + $"(사전 정산 금액 : {prePayment}원)";
                    }
                    else if (cost <= 0 && prePayment>0) // 사전정산 이후 추가 요금 발생 안된 차량
                    {
                        parkingFee.Text = "사전 정산 차량입니다.";
                        serial();
                    }
                });
                await Task.Delay(5000); // 텍스트 5초간 표시
                // 폼에 표시된 데이터를 데이터베이스에 저장.
                string query = "INSERT INTO cplate(car_num, entry_time, exit_time, usage_time, parking_fee) VALUES(@carNum, @entryTime, @exitTime, @usageTime, @parkingFee)";
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open(); // 데이터베이스 연결이 열려 있지 않으면 연결을 열기
                    using (MySqlCommand com = new MySqlCommand(query, connection))
                    {
                        com.Parameters.AddWithValue("@carNum", carNum);
                        com.Parameters.AddWithValue("@entryTime", entryTime);
                        com.Parameters.AddWithValue("@exitTime", exitTime);
                        com.Parameters.AddWithValue("@usageTime", durationStirng);
                        com.Parameters.AddWithValue("@parkingFee", cost);
                        com.ExecuteNonQuery();
                    }
                }
                this.Invoke((MethodInvoker)delegate
                {
                    reset_Data(); //폼 초기화
                });
            }
        }
        private void StartListening() // 소켓 연결 후 데이터 수신
        {
            Task.Run(() =>
            {
                try
                {
                    TcpListener listener = new TcpListener(IPAddress.Parse("192.168.200.103"), 33333);
                    listener.Start();
                    //client = listener.AcceptTcpClient();
                    while (true)
                    {
                        TcpClient client = listener.AcceptTcpClient();
                        Task.Run(() =>
                        {
                            using (client)
                            {
                                NetworkStream stream = client.GetStream();
                                byte[] buffer = new byte[1024];
                                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                                string dataReceived = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                                UpdateForm(dataReceived);
                            }
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("데이터 수신 중 오류 발생: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
        }
        private void prePayListening() // 소켓 연결 후 데이터 수신
        {
            Task.Run(() =>
            {
                try
                {
                    TcpListener listener = new TcpListener(IPAddress.Parse("192.168.200.103"), 33332);
                    listener.Start();
                    while (true)
                    {
                        TcpClient client = listener.AcceptTcpClient();
                        Task.Run(() =>
                        {
                            using (client)
                            {
                                NetworkStream stream = client.GetStream();
                                byte[] buffer1 = new byte[1024];
                                int byteRead = stream.Read(buffer1, 0, buffer1.Length);
                                string data1 = Encoding.UTF8.GetString(buffer1);
                                string[] parts = data1.Split(',');
                                string pcarNum = parts[0];
                                string pCost = parts[1]+parts[2];
                                prePayData[pcarNum] = pCost;
                            }
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("데이터 수신 중 오류 발생: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
        }
        public void reset_Data()
        {
            number.Text = string.Empty;
            inTime.Text = string.Empty;
            outTime.Text = string.Empty;
            usageTime.Text = string.Empty;
            parkingFee.Text = string.Empty;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (cost > 0)
            {
                Form payment = new payment(connection, parkingFee.Text, this);
                payment.ShowDialog();
            }
            else
            {
                MessageBox.Show("결제할 금액 없습니다.");
                reset_Data();
            }
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
        private async Task display_wait()
        {
            await Task.Delay(3000);
        }
    }
}
