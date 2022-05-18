using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    class MTeatcher
    {
        public MTeatcher()
        {
        }

        public MTeatcher(string departament, string name, ICollection<MLesson> lessons)
        {
            Departament = departament;
            Name = name;
            Lessons = lessons;
        }

        public int Id { get; set; }
        public string Departament { get; set; }
        public string Name { get; set; }
        public ICollection<MLesson> Lessons { get; set; }
    }
}
