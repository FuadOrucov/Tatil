using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tatilll.Models.Sinifler;

namespace Tatilll.Controllers
{
    public class TravelController : Controller
    {
        // GET: Travel
        Context c = new Context();
        public ActionResult Index()
        {
            var bloggg = c.Blogs.Take(11).ToList();
            return View(bloggg);
        }
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            var part = c.Blogs.Take(2).ToList();
            return PartialView(part);
        }
        public PartialViewResult Partial2()
        {
            var part = c.Blogs.Where(o => o.ID == 5).ToList();
            return PartialView(part);
        }
        public PartialViewResult Partial3()
        {
            var deyer = c.Blogs.Take(10).ToList();
            return PartialView(deyer);
        }
        public PartialViewResult Partial4()
        {
            var deyer = c.Blogs.Take(3).ToList();
            return PartialView(deyer);
        }
        public PartialViewResult Partial5()
        {
            var deyer1 = c.Blogs.Take(3).OrderByDescending(o => o.ID).ToList();
            return PartialView(deyer1);
        }


    }
}