using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tatilll.Models.Sinifler;

namespace Tatilll.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        BlogYorum by = new BlogYorum();
        public ActionResult Index()
        {
            by.Deyer1 = c.Blogs.Take(4).ToList();
            by.Deyer3 = c.Blogs.Take(4);
           // var bloglar = c.Blogs.ToList();
            return View(by);
        }

       
        public ActionResult BlogDetay(int id)
        {
            by.Deyer1 = c.Blogs.Where(o => o.ID == id).ToList();
            by.Deyer2 = c.Yorumlars.Where(o => o.BlogId == id).ToList();
           // var blogkod = c.Blogs.Where(o => o.ID == id).ToList();
          
            
            return View(by);
        }

        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deyer = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult YorumYap( Yorumlar y)
        {
            c.Yorumlars.Add(y);
            c.SaveChanges();
            return PartialView();
        }
    }
} 