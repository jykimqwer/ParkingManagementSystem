using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace prj_parking
{
    public partial class login : Form
    {
        MySqlConnection connection;
        string connectionString = "Server=127.0.0.1;Database=plate;Uid=root;Pwd=1234;";  //mysql 서버 정보
        public login()
        {
            InitializeComponent();
            loginPW.PasswordChar = '*';     //로그인 창 비밀번호 '*' 출력
            connection = new MySqlConnection(connectionString); //mysql 서버 접속
        }
        private void loginDB(object sender, EventArgs e) //DB 로그인 함수
        {            
            string id = loginID.Text;  // 아이디 입력
            string pw = loginPW.Text;  // 비밀번호 입력
            try
            {
                connection.Open();  //mysql 연결
                if(connection.State == System.Data.ConnectionState.Open)
                {
                    if (CheckID_PW(connection, id, pw)) // 비밀번호 체크함수 호출
                    {
                        MessageBox.Show("MySQL 데이터베이스에 성공적으로 연결되었습니다.", "연결 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form num_searching = new num_searching(); //주차요금 확인 폼 연결
                        num_searching.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("ID 또는 패스워드가 일치하지 않습니다.", "접속 실패");
                    }
                }
                else
                {
                    MessageBox.Show("MySQL 데이터베이스에 연결할 수 없습니다.", "연결 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
             
            }catch(Exception ex)
            {
                MessageBox.Show("MySQL 데이터베이스 연결 중 오류가 발생했습니다.\n\n에러 메시지: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        private bool CheckID_PW(MySqlConnection connection, string id, string pw) //비밀번호 체크 함수
        {
            string query = "SELECT COUNT(*) FROM admin_info WHERE ID = @id AND PW = @pw";
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@pw", pw);
                try
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
;           loginDB(sender, e);
        }
    }
}
