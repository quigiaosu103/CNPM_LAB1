using DangKi.Models;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DangKi.Controller
{
    public class SalaryController
    {
        public static int getSalary()
        {
            using (var context = new MyDbContext())
            {
                //var day = context.ScheduleDetails.Select(e => $"{e.Daily} {e.LastName}");
                
            }
            return 0;
        }

        public List<double> getTimeInMonth(string month)
        {
           
            using (var context = new MyDbContext())
            {
                List<double> resut = new List<double>();
                double totalSalary = 0;
                double totalTime = 0;
                int monthh = 1;
                if(month == "")
                {
                    monthh = DateTime.Now.Month;
                } else
                {
                    var replacedMonth = month.Replace("Tháng ", "");
                    monthh = int.Parse(replacedMonth);
                }
                var day = context.ScheduleDetails.Select(e => new { e.Schedule.Id,e.Salary, e.Daily, e.timeStart, e.timeEnd }).ToList();
               
                foreach (var i in day) /*tinhtheoca*/
                {
                   /* MessageBox.Show(i.Id.ToString());*/ /// id cac khoa day
                    var dayStartAndEnd = context.Schedules.Where(x => x.Id == i.Id).FirstOrDefault();
                    if (dayStartAndEnd.dateTime.Month <= monthh && dayStartAndEnd.dateTimeEnd.Month >= monthh)
                    {
                        //MessageBox.Show(dayStartAndEnd.dateTime.GetType().ToString());
                        string[] arrListStr = i.Daily.Split(',');
                        TimeSpan time = i.timeEnd.Subtract(i.timeStart);
                        double minutes = time.TotalMinutes;
                        foreach (var daily in arrListStr)
                        {
                            if (daily == "T2")
                            {
                                totalSalary += CountDays(monthh, DateTime.Now.Year)[0] * i.Salary;
                                totalTime += (minutes * (double)CountDays(monthh, DateTime.Now.Year)[0]);

                            }
                            else if (daily == "T3")
                            {
                                totalSalary += CountDays(monthh, DateTime.Now.Year)[1] * i.Salary;
                                totalTime += (minutes * (double)CountDays(monthh, DateTime.Now.Year)[1]);

                            }
                            else if (daily == "T4")
                            {
                                totalSalary += CountDays(monthh, DateTime.Now.Year)[2] * i.Salary;
                                totalTime += minutes * CountDays(monthh, DateTime.Now.Year)[2];
                            }
                            else if (daily == "T5")
                            {
                                totalSalary += CountDays(monthh, DateTime.Now.Year)[3] * i.Salary;
                                totalTime += minutes * CountDays(monthh, DateTime.Now.Year)[3];
                            }
                            else if (daily == "T7")
                            {
                                totalSalary += CountDays(monthh, DateTime.Now.Year)[4] * i.Salary;
                                totalTime += minutes * CountDays(monthh, DateTime.Now.Year)[4];
                            }
                            else if (daily == "T7")
                            {
                                totalSalary += CountDays(monthh, DateTime.Now.Year)[5] * i.Salary;
                                totalTime += minutes * CountDays(monthh, DateTime.Now.Year)[5];
                            }
                            else if (daily == "CN")
                            {
                                totalSalary += CountDays(monthh, DateTime.Now.Year)[6] * i.Salary;
                                totalTime += minutes * CountDays(monthh, DateTime.Now.Year)[6];
                            }

                        }
                        if(dayStartAndEnd.dateTime.Month == monthh)
                        {
                            List<double> doubles = new List<double>();
                            doubles = getDayFirstMonth(dayStartAndEnd.dateTime);
                            string[] dayInWeek = ["T2", "T3", "T4", "T5", "T6", "T7", "CN"];
                            double count = 0;
                            foreach (var daily in arrListStr)
                            {
                                int a = Array.IndexOf(dayInWeek, daily);
                                count = count + doubles[a];

                            }
                            totalSalary = totalSalary - (count * i.Salary);
                        }
                        if (dayStartAndEnd.dateTimeEnd.Month == monthh)
                        {

                            List<double> doubless = new List<double>();
                            doubless = getDayLastMonth(dayStartAndEnd.dateTimeEnd);
                            string[] dayInWeek = ["T2", "T3", "T4", "T5", "T6", "T7", "CN"];
                            double counts = 0;
                            foreach (var daily in arrListStr)
                            {
                                int a = Array.IndexOf(dayInWeek, daily);
                                counts = counts + doubless[a];

                            }
                            totalSalary = totalSalary - (counts * i.Salary);
                        }


                    }
                }
                resut.Add(totalSalary);
                resut.Add(totalTime/60);
                return resut;
            }
        }

        public List<double> getTimeInMonth(string month, string dailyy, string totalTimes, string salarys)
        {
            using (var context = new MyDbContext())
            {
                List<double> resut = new List<double>();
                double totalSalary = 0;
                double totalTime = 0;
                int monthh = 1;
                if (month == "")
                {
                    monthh = DateTime.Now.Month;
                }
                else
                {
                    var replacedMonth = month.Replace("Tháng ", "");
                    monthh = int.Parse(replacedMonth);
                }
                var day = context.ScheduleDetails.Select(e => new { e.Schedule.Id, e.Salary, e.Daily, e.timeStart, e.timeEnd }).ToList();
                foreach (var i in day) /*tinhtheoca*/
                {
                    totalSalary = totalTime = 0;
                    var dayStartAndEnd = context.Schedules.Where(x => x.Id == i.Id).FirstOrDefault();
                    if (dayStartAndEnd.dateTime.Month <= monthh && dayStartAndEnd.dateTimeEnd.Month >= monthh)
                    {
                        string[] arrListStr = dailyy.Split(',');
                        double minutes = double.Parse(totalTimes);
                        double Salary = double.Parse(salarys);
                        foreach (var daily in arrListStr)
                        {
                            if (daily == "T2")
                            {
                                totalSalary += CountDays(monthh, DateTime.Now.Year)[0] * Salary;
                                totalTime += (minutes * (double)CountDays(monthh, DateTime.Now.Year)[0]);

                            }
                            else if (daily == "T3")
                            {
                                totalSalary += CountDays(monthh, DateTime.Now.Year)[1] * Salary;
                                totalTime += (minutes * (double)CountDays(monthh, DateTime.Now.Year)[1]);

                            }
                            else if (daily == "T4")
                            {
                                totalSalary += CountDays(monthh, DateTime.Now.Year)[2] * Salary;
                                totalTime += minutes * CountDays(monthh, DateTime.Now.Year)[2];
                            }
                            else if (daily == "T5")
                            {
                                totalSalary += CountDays(monthh, DateTime.Now.Year)[3] * Salary;
                                totalTime += minutes * CountDays(monthh, DateTime.Now.Year)[3];
                            }
                            else if (daily == "T7")
                            {
                                totalSalary += CountDays(monthh, DateTime.Now.Year)[4] * Salary;
                                totalTime += minutes * CountDays(monthh, DateTime.Now.Year)[4];
                            }
                            else if (daily == "T7")
                            {
                                totalSalary += CountDays(monthh, DateTime.Now.Year)[5] * Salary;
                                totalTime += minutes * CountDays(monthh, DateTime.Now.Year)[5];
                            }
                            else if (daily == "CN")
                            {
                                totalSalary += CountDays(monthh, DateTime.Now.Year)[6] * Salary;
                                totalTime += minutes * CountDays(monthh, DateTime.Now.Year)[6];
                            }

                        }
                      
                        if (dayStartAndEnd.dateTime.Month == monthh)
                        {
                            List<double> ddoubles = new List<double>();
                            //MessageBox.Show(dayStartAndEnd.dateTime.ToString());
                            ddoubles = getDayFirstMonth(dayStartAndEnd.dateTime);
                            string[] dayInWeek = ["T2", "T3", "T4", "T5", "T6", "T7", "CN"];
                            double count = 0;
                            foreach (var daily in arrListStr)
                            {
                                int a = Array.IndexOf(dayInWeek, daily);
                                count = count + ddoubles[a];
                               
                            }
                            totalSalary = totalSalary - (count * Salary);
                        }
                        if (dayStartAndEnd.dateTimeEnd.Month == monthh)
                        {
                            List<double> ddoubless = new List<double>();
                            ddoubless = getDayLastMonth(dayStartAndEnd.dateTimeEnd);
                            string[] dayInWeek = ["T2", "T3", "T4", "T5", "T6", "T7", "CN"];
                            double counts = 0;
                            foreach (var daily in arrListStr)
                            {
                                int a = Array.IndexOf(dayInWeek, daily);
                                counts = counts + ddoubless[a];

                            }
                            totalSalary = totalSalary - (counts * Salary);
                        }
                    }
                }
                
                resut.Add(totalSalary);
                resut.Add(totalTime/60);
                return resut;
            }
        }

        public static List<int> CountDays(int month, int year)
        {
            List<int> dayOfMonth = new List<int>();
            List<DayOfWeek> dayOfWeeks = new List<DayOfWeek>();
            dayOfWeeks.Add(DayOfWeek.Monday);
            dayOfWeeks.Add(DayOfWeek.Tuesday);
            dayOfWeeks.Add(DayOfWeek.Wednesday);
            dayOfWeeks.Add(DayOfWeek.Thursday);
            dayOfWeeks.Add(DayOfWeek.Friday);
            dayOfWeeks.Add(DayOfWeek.Saturday);
            dayOfWeeks.Add(DayOfWeek.Sunday);
            foreach (DayOfWeek i in dayOfWeeks)
            {
                int days = 0;
                for (int day = 1; day <= DateTime.DaysInMonth(year, month); day++)
                {
                    
                    if (new DateTime(year, month, day).DayOfWeek == i)
                    {
                        days +=1;
                    }
                }
                dayOfMonth.Add(days);
            }
            return dayOfMonth;
        }

        public List<DataGirdviewClass> getDataScheduleDetail(string month)
        {
            using (var context = new MyDbContext())
            {
                List<DataGirdviewClass> dataDetail = new List<DataGirdviewClass>();
               











                var idSchedules = context.Schedules.Where(x => x.Teacher.TeacherId == 1).ToList(); // 1  2 check user

















                var codeCourse = context.Courses.ToList();
                
                foreach (var item in idSchedules)
                {
                    DataGirdviewClass data = new DataGirdviewClass();
                    var day = context.ScheduleDetails.Where(x => x.Schedule.Id == item.Id).ToList(); // salary
                    var nameCourse = context.Courses.Where(x => x.CourseId == item.Course.CourseId).ToList();
                    foreach (var z in nameCourse)
                    {
                        var name = z.CourseName.ToString(); // 1
                        data.CourseName = name;
                    }
                    foreach (var n in day)
                    {
                        var salary = n.Salary.ToString("N0");
                        var timeStart = n.timeStart.ToString("HH:mm:ss");
                        var timeEnd = n.timeEnd.ToString("HH:mm:ss");     
                        var daily = n.Daily.ToString();
                        var durationMinutes = (n.timeEnd - n.timeStart).Minutes.ToString();
                        var durationHouse = (n.timeEnd - n.timeStart).Hours.ToString();
                        var totalTime = (int.Parse(durationHouse) * 60 + int.Parse(durationMinutes)).ToString("N1");
                        //var calTotal = getTimeInMonth(month, daily, totalTime, salary);
                        data.Salary = salary;
                        data.timeEnd = timeEnd;
                        data.timeStart = timeStart;
                        data.dayStudy = daily.ToString();
                        data.timeStudy = (getTimeInMonth(month, daily, totalTime, salary)[1]).ToString("N1");
                        data.total = (getTimeInMonth(month, daily, totalTime, salary)[0]).ToString("N0");
                    }
                    dataDetail.Add(data);   
                }
                return dataDetail;
            }
           
        }


        public List<double> getDayFirstMonth(DateTime startDate)
        {
            double countMondays = 0;
            double countTuesdays = 0;
            double countWednesdays = 0;
            double countThursday = 0;
            double countFriday = 0;
            double countSaturday = 0;
            double countSunday = 0;
            List<double> data = new List<double>();
            DateTime monthFirst = new DateTime(DateTime.Now.Year, startDate.Month, 1);
            while (monthFirst < startDate)
            {
                if (monthFirst.DayOfWeek == DayOfWeek.Monday)
                {
                    countMondays++;
                }
                else if (monthFirst.DayOfWeek == DayOfWeek.Tuesday)
                {
                    countTuesdays++;
                }
                else if (monthFirst.DayOfWeek == DayOfWeek.Wednesday)
                {
                    countWednesdays++;
                }
                else if (monthFirst.DayOfWeek == DayOfWeek.Thursday)
                {
                    countThursday++;
                }
                else if (monthFirst.DayOfWeek == DayOfWeek.Friday)
                {
                    countFriday++;
                }
                else if (monthFirst.DayOfWeek == DayOfWeek.Saturday)
                {
                    countSaturday++;
                }
                else if (monthFirst.DayOfWeek == DayOfWeek.Sunday)
                {
                    countSunday++;
                }
                monthFirst = monthFirst.AddDays(1);
     
            }
            data.Add(countMondays);
            data.Add(countTuesdays);
            data.Add(countWednesdays);
            data.Add(countThursday);
            data.Add(countFriday); 
            data.Add(countSaturday);
            data.Add(countSunday);  
            return data;
        }

        public List<double> getDayLastMonth(DateTime endDate)
        {
            double countMondayss = 0;
            double countTuesdayss = 0;
            double countWednesdayss = 0;
            double countThursdayss = 0;
            double countFridayss = 0;
            double countSaturdayss = 0;
            double countSundayss = 0;
            int lastDayOfMonth = DateTime.DaysInMonth(endDate.Year, endDate.Month);
            List<double> data = new List<double>();
            DateTime monthLast = new DateTime(DateTime.Now.Year, endDate.Month, lastDayOfMonth);
            if (monthLast.Month != endDate.Month && monthLast.Day != endDate.Day)
            {
                endDate = endDate.AddDays(1);
            }
            while (endDate.Day < monthLast.Day)
            {
                
                if (endDate.DayOfWeek == DayOfWeek.Monday)
                {
                    countMondayss++;
                   
                }
                else if (endDate.DayOfWeek == DayOfWeek.Tuesday)
                {
                    countTuesdayss++;
                }
                else if (endDate.DayOfWeek == DayOfWeek.Wednesday)
                {
                    countWednesdayss++;
                }
                else if (endDate.DayOfWeek == DayOfWeek.Thursday)
                {
                    countThursdayss++;
                }
                else if (endDate.DayOfWeek == DayOfWeek.Friday)
                {
                    countFridayss++;
                }
                else if (endDate.DayOfWeek == DayOfWeek.Saturday)
                {
                    countSaturdayss++;
                }
                else if (endDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    countSundayss++;
                }
                endDate = endDate.AddDays(1);

            }
            data.Add(countMondayss);
            data.Add(countTuesdayss);
            data.Add(countWednesdayss);
            data.Add(countThursdayss);
            data.Add(countFridayss);
            data.Add(countSaturdayss);
            data.Add(countSundayss);
            return data;
        }
    }
}
