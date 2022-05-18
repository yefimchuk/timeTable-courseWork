using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IUnitOfWork
    {
        ContextRepository<User> Users { get; }  //получение доступа к репозиториям
        ContextRepository<Department> Departaments { get; }
        ContextRepository<Group> Groups { get; }
        ContextRepository<Lesson> Lessons { get; }
        ContextRepository<Auditory> Auditories { get; }
        ContextRepository<Subject> Subjects { get; }
        ContextRepository<Teatcher> Teachers { get; }
        void Save();
        void Dispose();
    }
}
