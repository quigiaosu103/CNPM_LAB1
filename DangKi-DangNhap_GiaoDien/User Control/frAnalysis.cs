using DangKi.Controller;
using DangKi.Models;
using Guna.Charts.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections;
using System.Drawing;
using TheArtOfDevHtmlRenderer.Adapters;
using Microsoft.EntityFrameworkCore.Metadata;
using OfficeOpenXml;
namespace DangKi.User_Control
{
    public partial class frAnalysis : UserControl
    {
        public frAnalysis()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void gunaChart_Load(object sender, EventArgs e)
        {
            gunaLineDataset = new GunaLineDataset();
            gunaLineDataset.Label = "Duration";
            gunaLineDataset.LegendBoxFillColor = Color.FromArgb(104, 41, 201);
            gunaLineDataset.FillColor = Color.FromArgb(104, 41, 201);
            gunaLineDataset.BorderColor = Color.FromArgb(104, 41, 201);
            gunaLineDataset.YFormat = "Income {0:C}";
            gunaChart.Datasets.Add(gunaLineDataset);
            LoadSchedulesDuration();


        }

        private void gunaChartEarned_Load(object sender, EventArgs e)
        {
            gunaLineEarnedDataset = new GunaLineDataset();
            gunaLineEarnedDataset.Label = "Earned";
            gunaLineEarnedDataset.LegendBoxFillColor = Color.FromArgb(0, 182, 122);
            gunaLineEarnedDataset.FillColor = Color.FromArgb(0, 182, 122);
            gunaLineEarnedDataset.BorderColor = Color.FromArgb(0, 182, 122);
            gunaLineEarnedDataset.YFormat = "Income {0:C}";
            gunaChartEarned.Datasets.Add(gunaLineEarnedDataset);
            LoadSchedulesEarned();

        }



        private void LoadSchedulesDuration()
        {
            int duration = 0;
            using (var context = new MyDbContext())
            {
                var list = context.Schedules
                    .Where(sc => sc.Teacher.TeacherId == UserInfo.currentUser.TeacherId)
                    .GroupBy(sc => sc.dateTime.Date)
                    .Select(sc => new
                    {
                        date = sc.Key,
                        value = sc.Sum(g => g.Duration)
                    }).ToList();
                foreach (var schedule in list)
                {
                    duration += schedule.value;
                    gunaLineDataset.DataPoints.Add(new LPoint()
                    {
                        Label = schedule.date.ToString("dd/MM/yy"),
                        Y = schedule.value,
                    });
                }

                txtDuration.Text = duration.ToString();



            }

        }

        private void LoadSchedulesEarned()
        {
            int totalEarned = 0;
            using (var context = new MyDbContext())
            {
                var earnedList = context.Schedules
                   .Where(sc => sc.Teacher.TeacherId == UserInfo.currentUser.TeacherId)
                   .GroupBy(sc => sc.dateTime.Date)
                   .Select(sc => new
                   {
                       date = sc.Key,
                       value = sc.Sum(g => g.Course.Price * g.Duration)
                   }).ToList();

                foreach (var schedule in earnedList)
                {
                    totalEarned += schedule.value;
                    gunaLineEarnedDataset.DataPoints.Add(new LPoint()
                    {
                        Label = schedule.date.ToString("dd/MM/yy"),
                        Y = schedule.value,
                    });
                }
                txtTotalEarned.Text = totalEarned.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime from = dateTimePicker1.Value.Date;
            DateTime to = dateTimePicker2.Value.Date;
            int totalEarned = 0;
            var duration = 0;
            gunaLineDataset.DataPoints.Clear();
            gunaLineEarnedDataset.DataPoints.Clear();
            using (var context = new MyDbContext())
            {
                var earnedList = context.Schedules
                   .Where(sc => sc.Teacher.TeacherId == UserInfo.currentUser.TeacherId && sc.dateTime.Date >= from && sc.dateTime.Date <= to)
                   .GroupBy(sc => sc.dateTime.Date)
                   .Select(sc => new
                   {
                       date = sc.Key,
                       value = sc.Sum(g => g.Course.Price * g.Duration)
                   }).ToList();

                foreach (var schedule in earnedList)
                {
                    totalEarned += schedule.value;
                    gunaLineEarnedDataset.DataPoints.Add(new LPoint()
                    {
                        Label = schedule.date.ToString("dd/MM/yy"),
                        Y = schedule.value,
                    });
                }
                var list = context.Schedules
                    .Where(sc => sc.Teacher.TeacherId == UserInfo.currentUser.TeacherId && sc.dateTime.Date >= from && sc.dateTime.Date <= to)
                    .GroupBy(sc => sc.dateTime.Date)
                    .Select(sc => new
                    {
                        date = sc.Key,
                        value = sc.Sum(g => g.Duration)
                    }).ToList();
                foreach (var schedule in list)
                {
                    duration += schedule.value;
                    gunaLineDataset.DataPoints.Add(new LPoint()
                    {
                        Label = schedule.date.ToString("dd/MM/yy"),
                        Y = schedule.value,
                    });
                }

                txtDuration.Text = duration.ToString();
                txtTotalEarned.Text = totalEarned.ToString();
            }
        }


        private void frAnalysis_Load(object sender, EventArgs e)
        {
            
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DateTime from = dateTimePicker1.Value.Date;
            DateTime to = dateTimePicker2.Value.Date;
            int totalEarned = 0;
            var duration = 0;
            using (var context = new MyDbContext())
            {
                var earnedList = context.Schedules
                   .Where(sc => sc.Teacher.TeacherId == UserInfo.currentUser.TeacherId && sc.dateTime.Date >= from && sc.dateTime.Date <= to)
                   .GroupBy(sc => sc.dateTime.Date)
                   .Select(sc => new
                   {
                       date = sc.Key,
                       value = sc.Sum(g => g.Course.Price * g.Duration)
                   }).ToList();
                var list = context.Schedules
                    .Where(sc => sc.Teacher.TeacherId == UserInfo.currentUser.TeacherId && sc.dateTime.Date >= from && sc.dateTime.Date <= to)
                    .GroupBy(sc => sc.dateTime.Date)
                    .Select(sc => new
                    {
                        date = sc.Key,
                        value = sc.Sum(g => g.Duration)
                    }).ToList();
               

                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");
                    worksheet.Cells[1, 1].Value = "Date";
                    worksheet.Cells[1, 2].Value = "Duration";
                    worksheet.Cells[1, 3].Value = "Earned";
                    for (int i = 0; i < list.Count; i++)
                    {
                        worksheet.Cells[i + 2, 1].Value = list[i].date;
                        worksheet.Cells[i + 2, 2].Value = list[i].value;
                        worksheet.Cells[i + 2, 3].Value = earnedList[i].value;
                    }
                    string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "output.xlsx");
                    FileInfo excelFile = new FileInfo(filePath);
                    excelPackage.SaveAs(excelFile);
                }
            }
        }

        private ExcelPackage exel;
        private GunaLineDataset gunaLineDataset;
        private GunaLineDataset gunaLineEarnedDataset;

    }
}
