﻿using DangKi.Controller;
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
            using (var context = new MyDbContext())
            {
                var list = context.Schedules
                    .Where(sc => sc.Teacher.TeacherId == 1)
                    .GroupBy(sc => sc.dateTime.Date)
                    .Select(sc => new
                    {
                        date = sc.Key,
                        value = sc.Sum(g => g.Duration)
                    }).ToList();
                foreach (var schedule in list)
                {
                    gunaLineDataset.DataPoints.Add(new LPoint()
                    {
                        Label = schedule.date.ToString("dd/MM/yy"),
                        Y = schedule.value,
                    });
                }

               

            }

        }

        private void LoadSchedulesEarned()
        {
            using (var context = new MyDbContext())
            {
                var earnedList = context.Schedules
                   .Where(sc => sc.Teacher.TeacherId == 1)
                   .GroupBy(sc => sc.dateTime.Date)
                   .Select(sc => new
                   {
                       date = sc.Key,
                       value = sc.Sum(g => g.Course.Price * g.Duration)
                   }).ToList();

                foreach (var schedule in earnedList)
                {
                    gunaLineEarnedDataset.DataPoints.Add(new LPoint()
                    {
                        Label = schedule.date.ToString("dd/MM/yy"),
                        Y = schedule.value,
                    });
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }
        private GunaLineDataset gunaLineDataset;
        private GunaLineDataset gunaLineEarnedDataset;

        
    }
}
