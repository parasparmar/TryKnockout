using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TryKnockout.Models;

namespace TryKnockout.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Person p = new Person { FirstName="Paras", LastName="Chandrakant Parmar"};
            return View(p);
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