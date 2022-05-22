using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Tatilll.Models.Sinifler;

namespace Tatilll.Controllers
{
    public class GirisYapController : Controller
    {
        // GET: GirisYap
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Admin ad)
        {
            var melumat = c.Admins.SingleOrDefault(o => o.Kullanici == ad.Kullanici && o.Sifre == ad.Sifre);
            if (melumat!=null)
            {
                FormsAuthentication.SetAuthCookie(melumat.Kullanici, false);
                Session["Kullanici"] = melumat.Kullanici.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
             
        }
        public ActionResult LoginOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "GirisYap");
        }

       
        
    }
}