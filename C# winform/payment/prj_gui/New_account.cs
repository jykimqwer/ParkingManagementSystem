using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static prj_gui.Main;

namespace prj_gui
{
    public partial class New_account : Form
    {
        public New_account()
        {
            InitializeComponent();
            textpw.PasswordChar = '*';
            textcpw.PasswordChar = '*';
        }
        private void resisterUser(string id, string pw, string name, string email)
        {
            using (MySqlConnection connection = SQLCONN.GetConn())
            {
                connection.Open();
                string duplicateQuery = "SELECT COUNT(*) FROM admin_info WHERE ID=@id AND email=@email";
                using (MySqlCommand duplicateCmd = new MySqlCommand(duplicateQuery, connection))
                {
                    duplicateCmd.Parameters.AddWithValue("@id", id);
                    duplicateCmd.Parameters.AddWithValue("@email", email);

                    try
                    {
                        int count = Convert.ToInt32(duplicateCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("이미 등록한 ID나 EMAIL 주소가 있습니다.", "회원가입");
                        }
                        else
                        {
                            string insertQuery = "INSERT INTO admin_info(ID, PW, name,email) VALUES(@id,@pw,@name,@email)";
                            using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection))
                            {
                                insertCmd.Parameters.AddWithValue("@id", id);
                                insertCmd.Parameters.AddWithValue("@pw", pw);
                                insertCmd.Parameters.AddWithValue("@name", name);
                                insertCmd.Parameters.AddWithValue("@email", email);

                                int rowsAffected = insertCmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("회원 가입이 완료되었습니다.", "회원가입");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("회원 가입 중 오류가 발생했습니다. 다시 시도해주세요.", "회원가입");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
        private bool ValidateInput(string id, string pw, string cpw, string email)
        {
            if (id.Length < 3 || id.Length > 13) //ID 형식 검사
            {
                MessageBox.Show("ID는 4자 이상 12자 이하여야 합니다.", "회원가입");
                return false;
            }
            if (pw.Length < 3 || pw.Length > 13)//pw 형식 검사
            {
                MessageBox.Show("Password는 4자 이상 12자 이하여야 합니다.", "회원가입");
                return false;
            }
            if (pw != cpw)
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.", "회원가입");
                return false;
            }
            if (!IsValidEmail(email))
            {
                MessageBox.Show("유효한 이메일 주소를 입력하세요.", "회원가입");
                return false;
            }
            return true;
        }
        private bool IsValidEmail(string email) //이메일 유효 검사
        {
            try
            {
                var eaddr = new System.Net.Mail.MailAddress(email);
                return eaddr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateInput(textid.Text, textpw.Text, textcpw.Text, textemail.Text))
            {
                resisterUser(textid.Text, textpw.Text, textname.Text, textemail.Text);
                this.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

