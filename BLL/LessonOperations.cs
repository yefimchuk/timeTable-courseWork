using BLL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace BLL
{
    public class LessonOperations
    {
        IMapper SubjectToM = new MapperConfiguration(cfg => cfg.CreateMap<Lesson, MLesson>()).CreateMapper();
        private readonly UnitOfWork _uow;

        public LessonOperations(UnitOfWork uow)
        {
            this._uow = uow;
        }

        public LessonOperations()
        {
            TimeTableContext context = new TimeTableContext();
            _uow = new UnitOfWork(context, new ContextRepository<User>(context), new ContextRepository<Department>(context), new ContextRepository<Group>(context), new ContextRepository<Lesson>(context), new ContextRepository<Auditory>(context), new ContextRepository<Subject>(context), new ContextRepository<Teatcher>(context));
        }

        public List<MLesson> GetLessons()
        {
            return SubjectToM.Map<IEnumerable<Lesson>, List<MLesson>>(_uow.Lessons.Get());

        }

        public MLesson GetLessonByID(int id)
        {
            return SubjectToM.Map<Lesson, MLesson>(_uow.Lessons.GetOne(x => (x.Id == id)));

        }

        public void AddLesson(MLesson subject)
        {
            _uow.Lessons.Create(new Lesson { Day = subject.Day, Para = subject.Para, Auditory = subject.Auditory, Group = subject.Group, Subject = subject.Subject, Teacher = subject.Teacher});
            _uow.Save();
        }

        public void DeleteLessonByID(int id)
        {
            _uow.Lessons.Remove(_uow.Lessons.FindById(id));
            _uow.Save();
        }
        
    }
}
