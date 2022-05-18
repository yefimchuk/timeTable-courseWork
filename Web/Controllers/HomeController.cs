using BLL;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{

    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult SingUp()
        {
            return View();
        }

        public ActionResult RedactorTimeTable()
        {
            return View();
        }

        public ActionResult StudentTimetable()
        {

            return View();
        }

        public ActionResult TeacherTimetable()
        {

            return View();
        }

        public ActionResult AdminTimetable()
        {

            return View();
        }

        public ActionResult ManagerTimetable()
        {

            return View();
        }

        [HttpPost]
        public ActionResult ManagerTimetable(string auditory)
        {
            LessonOperations lo = new LessonOperations();
            var list = lo.GetLessons();
            string result = "";

            foreach (MLesson l in list)
            {
                if (l.Auditory.Equals(auditory))
                {
                    result += "<br>" + " Day of week:  " + l.Day + " Group:  " + l.Group + " Number of lesson:  " + l.Para + " Code of auditory:  " + l.Auditory + " Name of subject:  " + l.Subject + " Teacher:  " + l.Teacher;
                }
            }

            ViewBag.Message = result;
            return View();
        }

        [HttpPost]
        public ActionResult AdminTimetable(string login, string role, string password, string passwordrepeat)
        {
            if (!password.Equals(passwordrepeat))
            {
                ViewBag.Message = "Passwords dont match";
                return View();
            }

            UserOperations uo = new UserOperations();
            uo.AddUser(new MUser(login, password, role));
            ViewBag.Message = "Succesfully registred";
            return View();
        }

        [HttpPost]
        public ActionResult TeacherTimetable(string teacher)
        {
            LessonOperations lo = new LessonOperations();
            var list = lo.GetLessons();
            string result = "";

            foreach (MLesson l in list)
            {
                if (l.Teacher.Equals(teacher))
                {
                    result += "<br>" +" Day of week:  " + l.Day + " Group:  " + l.Group + " Number of lesson:  " + l.Para + " Code of auditory:  " + l.Auditory + " Name of subject:  " + l.Subject + " Teacher:  " + l.Teacher;
                }
            }

            ViewBag.Message = result;
            return View();
        }

        [HttpPost]
        public ActionResult StudentTimetable(string group)
        {
            LessonOperations lo = new LessonOperations();
            var list = lo.GetLessons();
            string result = "";
           
            foreach(MLesson l in list)
            {
                if (l.Group.Equals(group))
                {
                    result += "<br>"+" Day of week:  " + l.Day + " Number of lesson:  " + l.Para + " Code of auditory:  " + l.Auditory + " Name of subject:  " + l.Subject + " Teacher:  " + l.Teacher;
                }
            }

            ViewBag.Message = result;

            return View();
        }


        [HttpPost]
        public ActionResult RedactorTimeTable(string day, string number, string group, string teatcher, string auditory, string subject)
        {
            LessonOperations lo = new LessonOperations();
            lo.AddLesson(new MLesson(day,int.Parse(number), group,teatcher,auditory,subject));
            ViewBag.Message = "Succsesfully added";
            return View();
        }

        [HttpPost]
        public ActionResult SingUp(string login, string password, string passwordrepeat)
        {
            if (!password.Equals(passwordrepeat))
            {
                ViewBag.Message = "Passwords dont match";
                return View();
            }

            UserOperations uo = new UserOperations();
            uo.AddUser(new MUser(login,password, "student"));
            ViewBag.Message = "Succesfully registred";
            return View();   
        }
        
        [HttpPost]
        public ActionResult Login(string login, string password)
        {
            UserOperations op = new UserOperations();
            var listUsers = op.GetUsers();
            string role = "none";
            foreach (MUser u in  listUsers)
            {
                if (u.Password.Equals(password) && u.Name.Equals(login))
                {
                    role = u.Role;
                }
            }

            if (role.Equals("student"))
                return Redirect("studenttimetable");
            else if (role.Equals("redactor"))
                return Redirect("redactortimetable");
            else if (role.Equals("teacher"))
                return Redirect("teachertimetable");
            else if (role.Equals("manager"))
                return Redirect("managertimetable");
            else if (role.Equals("admin"))
                return Redirect("admintimetable");
            else
            {
                ViewBag.Message = "Incorrect login or password, try again";
                return View();
            }
                
        }
    }
}