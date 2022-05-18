using BLL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AutoMapper;

namespace BLL
{
    public class GroupOperations
    {
        IMapper GroupToM = new MapperConfiguration(cfg => cfg.CreateMap<Group, MGroup>()).CreateMapper();
        private readonly UnitOfWork _uow;

        public GroupOperations(UnitOfWork uow)
        {
            this._uow = uow;
        }

        public GroupOperations()
        {
            TimeTableContext context = new TimeTableContext();
            _uow= new UnitOfWork(context, new ContextRepository<User>(context), new ContextRepository<Department>(context), new ContextRepository<Group>(context), new ContextRepository<Lesson>(context), new ContextRepository<Auditory>(context), new ContextRepository<Subject>(context), new ContextRepository<Teatcher>(context));
        }

        public List<MGroup> GetGroups()
        {
            return GroupToM.Map<IEnumerable<Group>, List<MGroup>>(_uow.Groups.Get());

        }
        public MGroup GetGroupById(int id)
        {
            return GroupToM.Map<Group, MGroup>(_uow.Groups.GetOne(x => (x.Id == id)));

        }
        public void AddGroup(MGroup group)
        {
            _uow.Groups.Create(new Group { Name = group.Name });
            _uow.Save();
        }

        public void DeleteGroupByID(int id)
        {
            _uow.Groups.Remove(_uow.Groups.FindById(id));
            _uow.Save();
        }
        
    }
}
