using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_gui
{
    public partial class datetime : Form
    {
        public event EventHandler<DateRangeSelectedEventArgs>? DateRangeSelected;
        public datetime()
        {
            InitializeComponent();
        }
        public class DateRangeSelectedEventArgs : EventArgs
        {
            public DateTime StartDate { get; }
            public DateTime EndDate { get; }

            public DateRangeSelectedEventArgs(DateTime startDate, DateTime endDate)
            {
                StartDate = startDate;
                EndDate = endDate;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime endDate = dateTimePickerEnd.Value;
            DateTime startDate = endDate.AddMonths(-3);
            if (endDate.Date < startDate.Date)
            {
                MessageBox.Show("시작날짜가 종료날짜보다 미래일 수 없습니다.");
                return;
            }
            if ((endDate - startDate).TotalDays > 180)
            {
                MessageBox.Show("조회기간은 최대 6개월까지 가능합니다.");
                return;
            }
            DateRangeSelected?.Invoke(this, new DateRangeSelectedEventArgs(startDate, endDate));
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
