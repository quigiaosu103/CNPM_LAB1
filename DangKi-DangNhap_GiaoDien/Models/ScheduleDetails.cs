using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangKi.Models
{
    public class ScheduleDetails
    {
        [Key]
        public int Id { get; set; }
        public int Salary { get; set; }
        public DateTime timeStart { get; set; }
        public DateTime timeEnd { get; set; }
        public string Daily {  get; set; }
        public Schedule Schedule { get; set; }  
       
    }
}
