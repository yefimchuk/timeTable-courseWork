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
    public class LessonOperationsTests
    {
        [TestMethod()]
        public void GetLessonsTest()
        {
            var groupOperations = new LessonOperations();
            groupOperations.GetLessons();
            groupOperations.AddLesson(new Models.MLesson ());

            groupOperations.GetLessonByID(0);
        }
    }
}