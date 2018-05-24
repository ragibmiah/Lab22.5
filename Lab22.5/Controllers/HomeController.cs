using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab22._5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string userName, string color, string age)
        {

            ViewBag.UserName = userName;
            ViewBag.Color = color;
            ViewBag.Age = age;

            Session["userName"] = ViewBag.UserName;
            Session["color"] = ViewBag.Color;
            Session["age"] = ViewBag.Age;

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
        public ActionResult Login()
        {
            return View();
        }
    }
}