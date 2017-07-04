using pro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pro.Controllers
{
    //controller is a collection of multiple actions.
    public class HomeController : Controller
    {
        //1 call
        //return view without viewname.
        public ActionResult Index()

        {
            return View();
        }

        //2 call
        public ActionResult ViewWithName()
        {
            return View("myview");
        }

        //3 call
        //viewdata and viewbag 
        //scope available within action and associated views.
        public ActionResult ViewBagViewData()
        {
            ViewBag.Hello = "Hello ViewBag";

            ViewData["test"] = "Hello ViewData";

            ViewData["Hello"] = "Hello viewdata with same  key of viewbag";
            return View();
        }

        //4 call
        //viewbag viewdata with object
        public ActionResult ViewBagViewDataWithObject()
        {
            Students student = new Students();
            student.Id = 1;
            student.Name = "Dattaram";
            student.Address = "mumbai";
            ViewBag.Student = student;
            ViewData["Student"] = student;
            return View();
        }

        //5 call
        //temp data scope is only the first nearest action.
        public ActionResult tempdataAction()
        {
            ViewData["StudentName"] = "Dattaram Garud";
            TempData["StudentName"] = "Dattaram Garud";
           TempData.Peek("StudentName");
         //  TempData.Keep("StudentName");
            return RedirectToAction("fromtempdataaction");
        }
        public ActionResult fromtempdataaction()
        {
            if (ViewData["StudentName"] == null)
                ViewData["StudentName"] = "value not available in viewdata";

            if (TempData["StudentName"] == null)
                TempData["StudentName"] = "value not available in tempdata";
            return View();
        }
    }
}