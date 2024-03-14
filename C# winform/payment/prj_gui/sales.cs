using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static prj_gui.datetime;
using Excel = Microsoft.Office.Interop.Excel;

namespace prj_gui
{
    public partial class sales : Form
    {
        private MySqlConnection connection;
        private int queryCount;
        int totalCost, parking;
        public sales(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }
        private void MySql_data(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            connection.Open();
            MySqlDataReader table = cmd.ExecuteReader();
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
            //table.Close();
            connection.Close();
        }
        private void sales_Load(object sender, EventArgs e)
        {
            string defalutQuery = "SELECT car_num, entry_time, exit_time, usage_time, parking_fee FROM cplate";
            MySql_data(defalutQuery);
            totalLabel.Text = $"이용차량 수 : {queryCount} 대";
            costLabel.Text = $"총 정산금액 : {totalCost} 원";
        }
        private void saveToExcel(DataGridView datagridview)
        {
            // 엑셀 애플리케이션 객체 생성
            Excel.Application excelapp = new Excel.Application();
            excelapp.Visible = true; // 엑셀 프로그램을 표시할지 여부를 설정합니다.

            // 새 워크북 추가
            Excel.Workbook workbook = excelapp.Workbooks.Add();
            // 워크시트 가져오기
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.ActiveSheet;

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
        private void PrintDataGridView(DataGridView dataGridView)
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
        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT car_num, entry_time, exit_time, usage_time, parking_fee FROM cplate WHERE DATE(exit_time) = CURDATE();";
            MySql_data(query);
            totalLabel.Text = $"이용차량 수 : {queryCount} 대";
            costLabel.Text = $"총 정산금액 : {totalCost} 원";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT car_num, entry_time, exit_time, usage_time, parking_fee FROM cplate WHERE MONTH(entry_time) = MONTH(CURDATE()) AND YEAR(entry_time) = YEAR(CURDATE());";
            MySql_data(query);
            totalLabel.Text = $"이용차량 수 : {queryCount} 대";
            costLabel.Text = $"총 정산금액 : {totalCost} 원";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "SELECT car_num, entry_time, exit_time, usage_time, parking_fee FROM cplate WHERE YEAR(entry_time)  = YEAR(CURDATE());";
            MySql_data(query);
            totalLabel.Text = $"이용차량 수 : {queryCount} 대";
            costLabel.Text = $"총 정산금액 : {totalCost} 원";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            datetime dateTime = new datetime();
            dateTime.DateRangeSelected += DateTime_DateRangeSelected;
            dateTime.Show();
        }
        private void DateTime_DateRangeSelected(object sender, DateRangeSelectedEventArgs e)
        {
            DateTime startDate = e.StartDate;
            DateTime endDate = e.EndDate;
            string query = $"SELECT car_num, entry_time, exit_time, usage_time, parking_fee FROM cplate WHERE entry_time BETWEEN '{startDate.ToString("yyyy-MM-dd")}' AND '{endDate.ToString("yyyy-MM-dd")}';";
            MySql_data(query);
            queryCount++;
            totalLabel.Text = $"이용차량 수 : {queryCount} 대";
            costLabel.Text = $"총 정산금액 : {totalCost} 원";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            billing billingForm = new billing(connection);
            billingForm.Show();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            saveToExcel(dataGridView1);
        }
        private void print_Click(object sender, EventArgs e)
        {
            PrintDataGridView(dataGridView1);
        }

    }
}
