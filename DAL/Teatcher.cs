using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Teatcher
    {
        public Teatcher()
        {
        }

        public Teatcher(Department departament, string name, ICollection<Lesson> lessons)
        {
            Departament = departament;
            Name = name;
            Lessons = lessons;
        }

        public int Id { get; set; }
        public Department Departament { get; set; }
        public string Name { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
    }
}
