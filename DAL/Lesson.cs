using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Lesson
    {
        public Lesson() { }

        public Lesson(string day, int para, string group, string teacher, string auditory, string subject)
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
