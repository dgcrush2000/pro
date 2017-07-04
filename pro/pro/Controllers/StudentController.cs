using pro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pro.Controllers
{
    public class StudentController : Controller

    {
        private StudentDB db = new StudentDB();
        // GET: Student
        public ActionResult Index()
        {
            //List<Students> lst = new List<Students>();
            //lst.Add(new Students { Id = 1, Name = "aaaa", Address = "Mumbai" });
            //lst.Add(new Students { Id = 2, Name = "bbbb", Address = "Mumbai" });
            //lst.Add(new Students { Id = 3, Name = "cccc", Address = "Mumbai" });
            //return View(lst);
            return View(db.student.ToList());
        }

        
        public ActionResult Create()
        { 
            return View();
        }
        [HttpPost]
        public ActionResult Create(Students student)
        {
            if(ModelState.IsValid)
            {
                db.student.Add(student);
                db.SaveChanges();
            }
            return View(student);
        }
    }
}