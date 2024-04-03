﻿using DangKi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangKi.Controller
{
    internal class MyDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbConnection = "server=localhost;uid=root;pwd=;database=TeacherAssistant";
            optionsBuilder.UseMySql(dbConnection, ServerVersion.AutoDetect(dbConnection));
        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<ScheduleDetails> ScheduleDetails { get; set; }
    }
}
