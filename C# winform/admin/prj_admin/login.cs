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

namespace prj_admin
{
    public partial class login : Form
    {
        string connectionString = "Server=127.0.0.1;Database=plate;Uid=root;Pwd=1234;";
        MySqlConnection connection;
        public login()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString); 
            loginPW.PasswordChar = '*';
            this.KeyPreview = true; // KeyPreview 속성을 true로 설정
            this.KeyDown += new KeyEventHandler(Main_KeyDown); //
        }
        private bool CheckID_PW(MySqlConnection connection, string id, string pw)
        {
            string query = "SELECT COUNT(*) FROM admin_info WHERE ID = @id AND PW = @pw";
            if(connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
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
        private void loginDB(object sender, EventArgs e)
        {
            string id = loginID.Text;
            string pw = loginPW.Text;
            try
            {
                connection.Open();
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    if (CheckID_PW(connection, id, pw))
                    {
                        MessageBox.Show("MySQL 데이터베이스에 성공적으로 연결되었습니다.", "연결 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form admin = new admin_Menu(connection);
                        admin.Show();
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
            catch (Exception ex)
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
        private void button2_Click(object sender, EventArgs e)
        {
            Form new_acc = new new_account(connection);
            new_acc.Show();
            this.Hide();
        }
        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginDB(sender, e);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
