using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentClient.ServiceReference1;

namespace StudentClient.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IStudentService sv = new StudentServiceClient();
            return View(sv.GetStudentList());
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
    }
}