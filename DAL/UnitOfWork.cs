using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private readonly TimeTableContext _db;

        public UnitOfWork(TimeTableContext db, ContextRepository<User> userRepository,
            ContextRepository<Department> departamentRepository, ContextRepository<Group> groupRepository,
            ContextRepository<Lesson> lessonRepository, ContextRepository<Auditory> auditoryRepository,
            ContextRepository<Subject> subjectRepository, ContextRepository<Teatcher> teatcherRepository)
        {
            _db = db;

            Users = userRepository;
            Departaments = departamentRepository;
            Groups = groupRepository;
            Lessons = lessonRepository;
            Auditories = auditoryRepository;
            Subjects = subjectRepository;
            Teachers = teatcherRepository;
        }

        public ContextRepository<User> Users { get; } //получение репозиториев 

        public ContextRepository<Department> Departaments { get; }

        public ContextRepository<Group> Groups { get; }

        public ContextRepository<Lesson> Lessons { get; }

        public ContextRepository<Auditory> Auditories { get; }

        public ContextRepository<Subject> Subjects { get; }

        public ContextRepository<Teatcher> Teachers { get; }


        public void Save()
        {
            _db.SaveChanges();
        }

        private bool _disposed;


        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;
            if (disposing)
            {
                _db.Dispose();
            }

            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
