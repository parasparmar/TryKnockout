using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;
using TryKnockout.Models;
using TryKnockout.DAL;

namespace TryKnockout.Controllers
{
    public class HomeController : Controller
    {
        //private BookContext db = new BookContext();
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