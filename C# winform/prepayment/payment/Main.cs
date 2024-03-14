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
            this.KeyPreview = true; // KeyPreview �Ӽ��� true�� ����
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
                            MessageBox.Show("MySQL �����ͺ��̽��� ���������� ����Ǿ����ϴ�.", "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Form billing = new billing(connection);
                            billing.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("ID �Ǵ� �н����尡 ��ġ���� �ʽ��ϴ�.", "���� ����");
                        }
                    }
                    else
                    {
                        MessageBox.Show("MySQL �����ͺ��̽��� ������ �� �����ϴ�.", "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MySQL �����ͺ��̽� ���� �� ������ �߻��߽��ϴ�.\n\n���� �޽���: " + ex.Message, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
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