using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangKi.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string UserName { get; set; }
        public string HashPassword { get; set; }
        public string  Email { get; set; }
        public ICollection<Schedule> Schedules { get; set; }
    }
}
