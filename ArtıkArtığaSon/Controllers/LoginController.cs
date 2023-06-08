using ArtıkArtığaSon.Models.Sınıflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ArtıkArtığaSon.Models;
using System.Security.Cryptography;
using System.Text;
using System.Security.Claims;


namespace ArtıkArtığaSon.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult girisYap()
        {
            return View();
        }

        [HttpPost]
        public ActionResult girisYap(KisiselBilgiler k)
        {
            Context c = new Context();
            var bilgi = c.KisiselBilgilers.FirstOrDefault(x => x.Mail == k.Mail && x.Sifre == k.Sifre);

            if (bilgi != null)
            {
                FormsAuthentication.SetAuthCookie(bilgi.Mail, false);
                Session["Mail"] = bilgi.Mail;
                return RedirectToAction("Index", "AAS");
            }
            else
            {
                return RedirectToAction("girisYap");
            }

            return View();
        }

}
}
