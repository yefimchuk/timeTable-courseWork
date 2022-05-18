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
    public class UserOperationsTests
    {
        [TestMethod()]
        public void GetUserTest()
        {
            var groupOperations = new UserOperations();
            groupOperations.GetUsers();
            groupOperations.AddUser(new Models.MUser());

            groupOperations.GetUserById(0);
        }
    }
}