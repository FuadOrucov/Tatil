using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tatilll.Models.Sinifler;

namespace Tatilll.Controllers
{
   
    public class AdminController : Controller
    {
        // GET: Admin
        
        Context c = new Context();
       [Authorize]
        public ActionResult Index()
        {
            var deyer = c.Blogs.ToList();
            return View(deyer);
        }

        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniBlog(Blog b)
        {
            c.Blogs.Add(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
            
            var deyer = c.Blogs.Where(o => o.ID == id).SingleOrDefault();
            c.Blogs.Remove(deyer);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

  
        public ActionResult BlogGetir(int id)
        {
            var deyer = c.Blogs.Find(id);
            return View("BlogGetir",deyer);
        }
     
        public ActionResult BlogGuncelle(Blog bl)
        {
            var deyr = c.Blogs.Find(bl.ID);
            deyr.Baslik = bl.Baslik;
            deyr.Tarih = bl.Tarih;
            deyr.Aciklama = bl.Aciklama;
            deyr.BlogImage = bl.BlogImage;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YorumListesi()
        {
            var deyer = c.Yorumlars.ToList();
            return View(deyer);
        }
        public ActionResult YorumSil(int id)
        {
            var y = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(y);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
            
        }
        public ActionResult YorumGetirr(int id)
        {
            var y = c.Yorumlars.Find(id);
            return View("YorumGetirr",y);
        }
        public ActionResult YorumGuncelle(Yorumlar y)
        {
            var yor = c.Yorumlars.Find(y.ID);
            yor.KullaniciAdi = y.KullaniciAdi;
            yor.Mail = y.Mail;
            yor.Yorum = y.Yorum;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
    }
}