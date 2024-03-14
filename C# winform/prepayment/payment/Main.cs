using System;
using System.Windows.Forms;
using System.Windows;
using MySql.Data.MySqlClient;
using System.Net.Sockets;

namespace prj_gui
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            mainPW.PasswordChar = '*';
            this.KeyPreview = true; // KeyPreview 속성을 true로 설정
            this.KeyDown += new KeyEventHandler(Main_KeyDown); // 
        }
        public class SQLCONN
        {
            public static MySqlConnection GetConn()
            {
                return new MySqlConnection("Server=127.0.0.1;Database=plate;Uid=root;Pwd=1234;");
            }
        }
        private bool CheckID_PW(MySqlConnection connection, string id, string pw)
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
        private void DB_Conn(object sender, EventArgs e)
        {
            string id = mainID.Text;
            string pw = mainPW.Text;
            try
            {
                using (MySqlConnection connection = SQLCONN.GetConn())
                {
                    connection.Open();
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        if (CheckID_PW(connection, id, pw))
                        {
                            MessageBox.Show("MySQL 데이터베이스에 성공적으로 연결되었습니다.", "연결 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Form billing = new billing(connection);
                            billing.Show();
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MySQL 데이터베이스 연결 중 오류가 발생했습니다.\n\n에러 메시지: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DB_Conn(sender, e);
            }
        }
    }
}