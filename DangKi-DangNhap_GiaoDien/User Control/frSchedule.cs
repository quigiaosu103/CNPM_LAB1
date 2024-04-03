using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DangKi.Controller;

namespace DangKi.User_Control
{
    public partial class frSchedule : UserControl
    {
        public frSchedule()
        {
            InitializeComponent();
            Form_Load();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void Form_Load()
        {
            dataGridView1.Rows.Add("", "CNTT1", "CNTT2", "", "", "CNTT1", "CA 1");
            dataGridView1.Rows.Add("CNTT3", "", "CNTT2", "", "CNTT5", "", "CA 2");
            dataGridView1.Rows.Add("", "CNTT2", "", "CNTT9", "", "CNTT3", "CA 3");
            dataGridView1.Rows.Add("", "CNTT1", "CNTT2", "", "CNTT8", "CNTT1", "CA 4");
            dataGridView1.Rows.Add("CNTT10", "", "", "CNTT7", "", "CNTT5", "CA 5");
            dataGridView1.ReadOnly = true;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                DataGridViewCell selectedCell = dataGridView1.CurrentCell;
                if (selectedCell.Value == null || string.IsNullOrWhiteSpace(selectedCell.Value.ToString()))
                {
                    if (comboBox1.SelectedItem != null)
                    {
                        selectedCell.Value = comboBox1.SelectedItem.ToString();
                    }
                }
            }
            dataGridView1.ReadOnly = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dataGridView1.SelectedCells[0];
                int rowIndex = selectedCell.RowIndex;
                int columnIndex = selectedCell.ColumnIndex;
                dataGridView1.Rows[rowIndex].Cells[columnIndex].Value = null;
                dataGridView1.ReadOnly = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dataGridView1.SelectedCells[0];
                dataGridView1.ReadOnly = false;
                if (!selectedCell.ReadOnly)
                {
                    selectedCell.ReadOnly = false;
                    dataGridView1.BeginEdit(true);
                }
                else
                {
                    MessageBox.Show("Selected cell is read-only and cannot be edited.");
                }
            }
            else
            {
                MessageBox.Show("Please select a cell to edit.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null)
                        {
                            object cellValue = row.Cells[i].Value;
                            //listOfValues.Add(cellValue);
                        }
                    }
                }
            }
            MessageBox.Show("Changes saved successfully.");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value.Date;
            StringBuilder messageBuilder = new StringBuilder();
            bool hasSchedule = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.OwningColumn.HeaderText.ToLower().Contains("thứ") && cell.Value != null)
                    {
                        DateTime scheduleDate;
                        if (DateTime.TryParse(cell.Value.ToString(), out scheduleDate) && scheduleDate.Date > selectedDate)
                        {
                            int subjectColumnIndex = cell.ColumnIndex + 1;
                            if (subjectColumnIndex < row.Cells.Count)
                            {
                                string subject = row.Cells[subjectColumnIndex].Value.ToString();
                                string session = row.Cells[row.Cells.Count - 1].Value.ToString();
                                messageBuilder.AppendLine($"Subject: {subject}, Session: {session}");
                                hasSchedule = true;
                                break; 
                            }
                        }
                    }
                }
            }


            if (hasSchedule)
            {
                string message = messageBuilder.ToString();
                SendEmail("duyga000123@gmail.com", "Upcoming Schedule", message);
                MessageBox.Show("Schedule email sent successfully!");
            }
            else
            {
                MessageBox.Show("No upcoming schedule found.");
            }
        }
        private void SendEmail(string to, string subject, string body)
        {
            string from = "duyga16022003@gmail.com";
            string password = "000123duy";

            SmtpClient client = new SmtpClient("smtp.example.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(from, password),
                EnableSsl = true,
            };

            MailMessage message = new MailMessage(from, to, subject, body);
            client.Send(message);
        }
    }
}
