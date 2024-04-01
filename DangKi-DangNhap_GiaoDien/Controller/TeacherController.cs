using DangKi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangKi.Controller
{
    public class TeacherController
    {

        public static void AddSchedule(int id, int teacherId)
        {
            using (var context = new MyDbContext())
            {
                var findSchedule = context.Schedules.Find(id);
                if(findSchedule != null) {
                    var teacher = context.Teachers.Find(teacherId);
                    if(teacher != null)
                    {
                        var currSchedules = teacher.Schedules;
                        if(currSchedules == null)
                        {
                            currSchedules = new List<Schedule>();
                        }
                        currSchedules.Add(findSchedule);
                        teacher.Schedules = currSchedules;
                        context.Teachers.Update(teacher);
                        context.SaveChanges();

                    }
                }
            }
        }
    }
}
