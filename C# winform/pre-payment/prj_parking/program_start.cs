using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_parking
{
    public partial class program_start : Form
    {
        public program_start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form numSearching = new num_searching();
            numSearching.Show();
            this.Hide();
        }
    }
}
