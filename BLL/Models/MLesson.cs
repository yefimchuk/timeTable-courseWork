using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class MLesson
    {
        public MLesson() 
        {
            Day = "01.09.2022";
            Para = 1;
            Group = "224";
            Teacher = "Захарчук";
            Auditory = "414";
            Subject = "Історія Української державності та культури";
        }

        public MLesson(string day, int para, string group, string teacher, string auditory, string subject)
        {
            Day = day;
            Para = para;
            Group = group;
            Teacher = teacher;
            Auditory = auditory;
            Subject = subject;
        }

        public int Id { get; set; }

        public string Day { get; set; }
        public int Para { get; set; }

        public string Group { get; set; }

        public string Teacher { get; set; } 

        public string Auditory { get; set; }

        public string Subject { get; set; }
    }
}
