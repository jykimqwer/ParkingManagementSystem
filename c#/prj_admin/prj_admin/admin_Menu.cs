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
using static prj_admin.datetime;
using Ex = Microsoft.Office.Interop.Excel;
using System.Drawing.Printing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.AccessControl;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using Org.BouncyCastle.Crypto.Tls;
using Renci.SshNet;
using System.ComponentModel.Design;
using MySql.Data.MySqlClient.Authentication;
using System.IO.Ports;

namespace prj_admin
{
    public partial class admin_Menu : Form
    {
        private MySqlConnection conn;
        private string selectedCarNumber;
        string input;
        private int queryCount;
        int totalCost, parking;
        MySqlDataReader table;
        public admin_Menu(MySqlConnection conn = null)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string carNumber = carNumberText.Text;
            string car_query = "SELECT * FROM cplate WHERE car_num = @carNumber";
            using (MySqlCommand command = new MySqlCommand(car_query, conn))
            {
                if(conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                command.Parameters.AddWithValue("@carNumber", carNumber);
                table = command.ExecuteReader();
                queryCount = 0;
                totalCost = 0;

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("car_num", "차량번호");
                dataGridView1.Columns.Add("entry_time", "입차시간");
                dataGridView1.Columns.Add("exit_time", "출차시간");
                dataGridView1.Columns.Add("usage_time", "이용시간");
                dataGridView1.Columns.Add("parking_fee", "주차요금");

                while (table.Read())
                {
                    string carNum = table.GetString("car_num");
                    DateTime entryTime = table.GetDateTime("entry_time");
                    DateTime exitTime = table.GetDateTime("exit_time");
                    string usageTime = table.GetString("usage_time");
                    int parkingFee = table.GetInt32("parking_fee");
                    dataGridView1.Rows.Add(carNum, entryTime, exitTime, usageTime, parkingFee);
                    queryCount++;
                    totalCost += parkingFee;
                }
                table.Close();
            }
        }
        private void saveToExcel(DataGridView datagridview) //엑셀저장(총사용량 조회탭)
        {
            // 엑셀 애플리케이션 객체 생성
            Ex.Application excelapp = new Ex.Application();
            excelapp.Visible = true; // 엑셀 프로그램을 표시할지 여부를 설정합니다.

            // 새 워크북 추가
            Ex.Workbook workbook = excelapp.Workbooks.Add();
            // 워크시트 가져오기
            Ex.Worksheet worksheet = (Ex.Worksheet)workbook.ActiveSheet;

            // 데이터그리드뷰의 헤더 행을 엑셀 워크시트에 복사
            for (int i = 0; i < datagridview.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = datagridview.Columns[i].HeaderText;
            }
            // 데이터그리드뷰의 데이터 행을 엑셀 워크시트에 복사
            for (int i = 0; i < datagridview.Rows.Count; i++)
            {
                for (int j = 0; j < datagridview.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = datagridview.Rows[i].Cells[j].Value.ToString();
                }
            }
            // 저장할 파일 경로 설정
            string filename = "c:\\users\\username\\documents\\data.xlsx"; // 파일 경로 및 이름을 원하는 대로 수정하세요
            // 엑셀 파일 저장
            workbook.SaveAs(filename);
        }
        private void MySql_data(string query) //Mysql_data (총사용량 조회탭)
        {
            MySqlCommand cmd = new MySqlCommand(query, conn);
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            MySqlDataReader table = cmd.ExecuteReader();
            queryCount = 0;
            totalCost = 0;

            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();

            dataGridView2.Columns.Add("car_num", "차량번호");
            dataGridView2.Columns.Add("entry_time", "입차시간");
            dataGridView2.Columns.Add("exit_time", "출차시간");
            dataGridView2.Columns.Add("usage_time", "이용시간");
            dataGridView2.Columns.Add("parking_fee", "주차요금");

            while (table.Read())
            {
                string carNum = table.GetString("car_num");
                DateTime entryTime = table.GetDateTime("entry_time");
                DateTime exitTime = table.GetDateTime("exit_time");
                string usageTime = table.GetString("usage_time");
                int parkingFee = table.GetInt32("parking_fee");
                dataGridView2.Rows.Add(carNum, entryTime, exitTime, usageTime, parkingFee);
                queryCount++;
                totalCost += parkingFee;
            }
            table.Close();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            serial();
        }
        private void serial()
        {
            SerialPort serialPort = new SerialPort();
            serialPort.PortName = "COM3";
            serialPort.BaudRate = 115200;
            serialPort.Open();
            serialPort.Write("1");
            serialPort.Close();
        }
        private void PrintDataGridView(DataGridView dataGridView) //출력 (총사용량 조회탭)
        {
            // 프린트 다이얼로그 생성
            PrintDialog printDialog = new PrintDialog();
            // 프린터 설정
            printDialog.AllowSomePages = true;
            printDialog.AllowSelection = false;
            printDialog.UseEXDialog = true;

            // 프린터 설정 대화 상자를 열고, 사용자가 확인 버튼을 클릭했을 때만 진행
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // 프린터 인스턴스 생성
                PrintDocument printDocument = new PrintDocument();
                // 프린터 설정 대화 상자의 설정을 프린터 인스턴스에 적용
                printDocument.PrinterSettings = printDialog.PrinterSettings;

                // 이벤트 핸들러 추가 - 프린트 페이지 설정
                printDocument.PrintPage += (sender, e) =>
                {
                    // DataGridView의 내용을 그릴 영역 지정
                    Rectangle rect = new Rectangle(0, 0, dataGridView.Width, dataGridView.Height);
                    // DataGridView의 내용을 그림
                    Bitmap bitmap = new Bitmap(dataGridView.Width, dataGridView.Height);
                    dataGridView.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView.Width, dataGridView.Height));
                    // 프린트 페이지에 그린 그림 출력
                    e.Graphics.DrawImage(dataGridView.BackgroundImage, 0, 0);
                };
                // 프린트 작업 시작
                printDocument.Print();
            }
        }
        private void tabControl1_MouseDown(object sender, MouseEventArgs e) // 로드화면(총사용량 조회탭) 
        {
            string defalutQuery = "SELECT car_num, entry_time, exit_time, usage_time, parking_fee FROM cplate";
            MySql_data(defalutQuery);
            totalLabel.Text = $"이용차량 수 : {queryCount} 대";
            costLabel.Text = $"총 정산금액 : {totalCost} 원";
        }
        private void button1_Click(object sender, EventArgs e) //당일 조회 (총사용량 조회탭)
        {
            DateTime Today = DateTime.Now;
            string query =$"SELECT car_num, entry_time, exit_time, usage_time, parking_fee FROM cplate WHERE DATE(entry_time) = DATE(@today);";
            using(MySqlCommand comm = new MySqlCommand(query, conn))
            {
                if(conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                comm.Parameters.AddWithValue("@today", DateTime.Today);

                using (MySqlDataReader table = comm.ExecuteReader())
                {
                    queryCount = 0;
                    totalCost = 0;

                    dataGridView2.Rows.Clear();
                    dataGridView2.Columns.Clear();

                    dataGridView2.Columns.Add("car_num", "차량번호");
                    dataGridView2.Columns.Add("entry_time", "입차시간");
                    dataGridView2.Columns.Add("exit_time", "출차시간");
                    dataGridView2.Columns.Add("usage_time", "이용시간");
                    dataGridView2.Columns.Add("parking_fee", "주차요금");

                    while (table.Read())
                    {
                        string carNum = table.GetString("car_num");
                        DateTime entryTime = table.GetDateTime("entry_time");
                        DateTime exitTime = table.GetDateTime("exit_time");
                        string usageTime = table.GetString("usage_time");
                        int parkingFee = table.GetInt32("parking_fee");
                        dataGridView2.Rows.Add(carNum, entryTime, exitTime, usageTime, parkingFee);
                        queryCount++;
                        totalCost += parkingFee;
                    }
                }
                totalLabel.Text = $"이용차량 수 : {queryCount} 대";
                costLabel.Text = $"총 정산금액 : {totalCost} 원";
            }
        }
        private void button2_Click(object sender, EventArgs e) // 월별 조회 (총사용량 조회탭)
        {
            month monthForm = new month();
            if (monthForm.ShowDialog() == DialogResult.OK)
            {
                int selectedMonth = monthForm.selectMonth;
                int year = DateTime.Now.Year;
                string query = $"SELECT car_num, entry_time, exit_time, usage_time, parking_fee FROM cplate WHERE MONTH(exit_time) = {selectedMonth} AND YEAR(exit_time)={year};";
                MySql_data(query);
                totalLabel.Text = $"이용차량 수 : {queryCount} 대";
                costLabel.Text = $"총 정산금액 : {totalCost} 원";
            }
        }
        private void button3_Click(object sender, EventArgs e) //연도별 조회 (총사용량 조회탭)
        {
            year yearForm = new year();
            if (yearForm.ShowDialog() == DialogResult.OK)
            {
                int selectedYear = yearForm.SelectedYear;
                string query = $"SELECT car_num, entry_time, exit_time, usage_time, parking_fee FROM cplate WHERE YEAR(exit_time) = {selectedYear};";
                MySql_data(query);
                totalLabel.Text = $"이용차량 수 : {queryCount} 대";
                costLabel.Text = $"총 정산금액 : {totalCost} 원";
            }
        }
        private void button4_Click(object sender, EventArgs e) //기간조회 날짜 받아오기 (총사용량 조회탭)
        {
            datetime dateTime = new datetime();
            dateTime.DateRangeSelected += DateTime_DateRangeSelected;
            dateTime.Show();
        }
        private void DateTime_DateRangeSelected(object sender, DateRangeSelectedEventArgs e) //기간조회 (총사용량 조회탭)
        {
            DateTime startDate = e.StartDate.Date;
            DateTime endDate = e.EndDate.Date;
            string query;
            //string query = $"SELECT car_num, entry_time, exit_time, usage_time, parking_fee FROM cplate WHERE entry_time BETWEEN '{startDate.ToString("yyyy-MM-dd")}' AND '{endDate.ToString("yyyy-MM-dd")}';";
            if(startDate == endDate)
            {
                query = $"SELECT car_num, entry_time, exit_time, usage_time, parking_fee FROM cplate WHERE  DATE(entry_time) = @startDate AND DATE(exit_time) = @endDate";
            }
            else {
                query = $"SELECT car_num, entry_time, exit_time, usage_time, parking_fee FROM cplate WHERE  entry_time BETWEEN @startDate AND @endDate";
            }
            using (MySqlCommand command = new MySqlCommand(query, conn))
            {
                // 매개변수에 값을 할당
                command.Parameters.AddWithValue("@startDate", startDate);
                command.Parameters.AddWithValue("@endDate", endDate);
                using (MySqlDataReader table = command.ExecuteReader())
                {
                    queryCount = 0;
                    totalCost = 0;

                    dataGridView2.Rows.Clear();
                    dataGridView2.Columns.Clear();

                    dataGridView2.Columns.Add("car_num", "차량번호");
                    dataGridView2.Columns.Add("entry_time", "입차시간");
                    dataGridView2.Columns.Add("exit_time", "출차시간");
                    dataGridView2.Columns.Add("usage_time", "이용시간");
                    dataGridView2.Columns.Add("parking_fee", "주차요금");

                    while (table.Read())
                    {
                        string carNum = table.GetString("car_num");
                        DateTime entryTime = table.GetDateTime("entry_time");
                        DateTime exitTime = table.GetDateTime("exit_time");
                        string usageTime = table.GetString("usage_time");
                        int parkingFee = table.GetInt32("parking_fee");
                        dataGridView2.Rows.Add(carNum, entryTime, exitTime, usageTime, parkingFee);
                        queryCount++;
                        totalCost += parkingFee;
                    }
                }
                totalLabel.Text = $"이용차량 수 : {queryCount} 대";
                costLabel.Text = $"총 정산금액 : {totalCost} 원";
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //saveToExcel(dataGridView2);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            PrintDataGridView(dataGridView2);
        }
        private void button7_Click(object sender, EventArgs e)//종료(총사용량 조회탭)
        {
            this.Close();
        }
    }
}
