using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangKi.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public int Duration { get; set; }
        public DateTime dateTime { get; set; }
        public bool IsCanceled { get; set; }
        public bool IsCompleted { get; set; }
        public string? Room { get; set; }
        public Teacher? Teacher { get; set; }
        public Course? Course { get; set; }
    }
}
