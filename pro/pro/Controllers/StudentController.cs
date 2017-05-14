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
        // GET: Student
        public ActionResult Index()
        {
            List<Students> lst = new List<Students>();
            lst.Add(new Students { Id = 1, Name = "aaaa", Address = "Mumbai" });
            lst.Add(new Students { Id = 2, Name = "bbbb", Address = "Mumbai" });
            lst.Add(new Students { Id = 3, Name = "cccc", Address = "Mumbai" });
            return View(lst);
        }
    }
}