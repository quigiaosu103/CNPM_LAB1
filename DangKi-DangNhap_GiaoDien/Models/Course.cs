using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangKi.Models
{
    public class Course
    {
        [Key]
        public required string CourseId { get; set; }
        public string? CourseName { get; set; }
        public int Price { get; set; }
    }
}
