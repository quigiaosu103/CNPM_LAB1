using DangKi.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangKi.User_Control
{
    public partial class frSalary : UserControl
    {
        SalaryController sl = new SalaryController();
        public frSalary()
        {
            InitializeComponent();


        }

        private void showTime(object sender, EventArgs e)
        {
            //lbTotalTime.Text = sl.getTimeInMonth().ToString();
            //lbTotalTime.Text = "ngu";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //lbTotalTime.Text = "ngu2";

        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbTotalTime.Text = sl.getTimeInMonth(cbMonth.Text)[1].ToString("N1") + " giờ / tháng";
            lbSalary.Text = sl.getTimeInMonth(cbMonth.Text)[0].ToString("N0") + " VND / tháng";
            LoadData();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void dtDetailSalary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadData()
        {
            dtDetailSalary.Rows.Clear();
            foreach (var i in sl.getDataScheduleDetail(cbMonth.Text))
            {
                //MessageBox.Show(i.CourseName.ToString());

                dtDetailSalary.Rows.Add(i.CourseName, i.Salary, i.timeStudy, i.dayStudy, i.timeStart, i.timeEnd, i.total);
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
