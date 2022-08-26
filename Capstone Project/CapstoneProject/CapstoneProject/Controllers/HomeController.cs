using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapstoneProject.Models;

namespace CapstoneProject.Controllers
{
    public class HomeController : Controller
    {
        private Model1 db = new Model1();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]

        public ActionResult AdminLogin(EmpInfo empInfo)
        {
            return RedirectToAction("EmployeeList", "Admin");
        }
        public ActionResult EmployeeLogin()
        {
            return View();
        }
        [HttpPost]

        public ActionResult EmployeeLogin(BlogInfo blogInfo)
        {
            return RedirectToAction("BlogList", "Employee");
        }

        public ActionResult BlogTracker(BlogInfo blogInfo)
        {
            return View();
        }
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("AdminLogin", "Home");
        }

    }
}