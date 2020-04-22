using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KCWebAuth.Controllers
{
    public class HomeController : Controller
    {
        //[Authorize(Users = @"LarryK321@gmail.com")]
        public ActionResult Index()
        {
            return View();
        }
        //[Authorize(Users = @"StevenW123@gmail.com")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        //[Authorize(Users = @"LarryK321@gmail.com")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}