using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BLL.Tests
{
    [TestClass()]
    public class GroupOperationsTests
    {
        [TestMethod()]
        public void GetGroupsTest()
        {
            GroupOperations groupOperations = new GroupOperations();
            groupOperations.GetGroups();
            groupOperations.GetGroupById(0);
            groupOperations.AddGroup(new Models.MGroup());
        }
    }
}