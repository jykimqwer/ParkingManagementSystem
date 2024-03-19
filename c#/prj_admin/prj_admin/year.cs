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
    public partial class year : Form
    {
        public int SelectedYear { get; private set; }
        public year()
        {
            InitializeComponent();
            numericUpDown1.Minimum = 1900;
            numericUpDown1.Maximum = DateTime.Now.Year;
            numericUpDown1.Value = DateTime.Now.Year; // 기본 값을 현재 연도로 설정
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form adMin = new admin_Menu();
            adMin.Show();
            this.Close();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            SelectedYear=(int)numericUpDown1.Value;
            DialogResult = DialogResult.OK; //ad_min 폼으로 선택한 연도 전달
        }
    }
}
