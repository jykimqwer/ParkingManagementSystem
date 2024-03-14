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
    public partial class month : Form
    {
        public int selectMonth { get; private set; }
        public month()
        {
            InitializeComponent();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            string selectedMonth = comboBox1.SelectedItem.ToString();
            string selectMonth = selectedMonth.Replace("월", "");
            DialogResult = DialogResult.OK;
        }

        private void month_Load(object sender, EventArgs e)
        {
            for(int i=1;i<=12;i++)
            {
                comboBox1.Items.Add(i.ToString()+"월"); //콤보박스에 1~12월 추가
            }
        }
    }
}
