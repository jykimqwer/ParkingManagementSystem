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
using System.Web;

namespace prj_parking
{
    public partial class num_searching : Form
    {
        MySqlConnection connection;
        string connectionString = "Server=127.0.0.1;Database=plate;Uid=root;Pwd=1234;";
        private string selectedCarNumber;
        string input;
        public num_searching()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            input = textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text;
            string query = "SELECT * FROM plate WHERE RIGHT(car_num, 4) = @input";
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            using(MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@input", input);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    listView1.Items.Clear(); 
                    while(reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["car_num"].ToString());
                        item.SubItems.Add(reader["entry_time"].ToString());
                        listView1.Items.Add(item);
                    }
                }  
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                selectedCarNumber = listView1.SelectedItems[0].Text;
            }
        }
        private void insert_number(int number)
        {
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text += number;
                searchingBtn.Enabled = false;
            }
            else if (textBox2.Text.Length == 0)
            {  
                textBox2.Text += number;
                searchingBtn.Enabled = false;
            }
            else if (textBox3.Text.Length == 0)
            {
                textBox3.Text += number;
                searchingBtn.Enabled = false;
            }
            else if (textBox4.Text.Length == 0)
            {    
                textBox4.Text += number;
                searchingBtn.Enabled = true;
            }
        }
        //public void insert_data(string carNum) //
        //{
        //    DateTime pexitTime = DateTime.Now;
        //    string query1 = "UPDATE plate SET pexit_time = @pexitTime WHERE car_num = @carNum AND Check = 0";
        //    //string query1 = "INSERT INTO plate (car_num, entry_time, exit_time, pexit_time 'check') VALUES (%s, NOW(), NULL, NULL, 0) ON DUPLICATE KEY UPDATE pexit_time=NOW();"; 
        //    if (connection.State != ConnectionState.Open)
        //    {
        //        connection.Open(); // 데이터베이스 연결이 열려 있지 않으면 연결을 열기
        //        try
        //        {
        //            using (MySqlCommand com = new MySqlCommand(query1, connection))
        //            {
        //                com.Parameters.AddWithValue("@carNum", selectedCarNumber); // 선택된 차량 번호를 파라미터로 전달
        //                com.Parameters.AddWithValue("@pexitTime", pexitTime);
        //                com.ExecuteNonQuery();

        //            }
        //        } catch(Exception ex)
        //        {
        //            MessageBox.Show("출차시간 업데이트에 실패하였습니다." + ex.Message);
        //        }
        //    }
        
        private void button13_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedCarNumber))
            {
                DateTime pexitTime = DateTime.Now;
                string query = "UPDATE plate SET pexit_time = @pexitTime WHERE car_num = @carNUM";
                using(MySqlCommand comm = new MySqlCommand(query, connection))
                {
                    comm.Parameters.AddWithValue("@carNum", selectedCarNumber);
                    comm.Parameters.AddWithValue("@pexitTime", pexitTime);

                    try
                    {
                        if (connection.State != ConnectionState.Open)
                        {
                            connection.Open();
                        }
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("출차시간 업데이트 중 오류가 발생했습니다." + ex.Message);
                    }
                    finally
                    {
                        prepay prepayForm = new prepay(selectedCarNumber);
                        prepayForm.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("차량을 선택하세요."); // 선택된 차량 번호가 없을 때 메시지 표시
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            input = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insert_number(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            insert_number(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            insert_number(3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            insert_number(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            insert_number(5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            insert_number(6);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            insert_number(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            insert_number(8);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            insert_number(9);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            insert_number(0);
        }
    }
}
