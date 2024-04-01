using DangKi.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangKi
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            UserControl scheduleUC = new frSchedule();
            addUserControl(scheduleUC);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserControl salaryUC = new frSalary();
            addUserControl(salaryUC);
        }
        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            UserControl analysis = new frAnalysis();
            addUserControl(analysis);
        }

        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            containerPanel.Controls.Clear();
            containerPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            UserControl scheduleUC = new frSchedule();
            addUserControl(scheduleUC);
        }
    }
}
