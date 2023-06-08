using ArtıkArtığaSon.Models.Sınıflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.UI.WebControls;

namespace ArtıkArtığaSon.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        Context c = new Context();

        

        [HttpGet]
        public ActionResult uyeOl()
        {
            var degerler = c.KisiselBilgilers.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult uyeOl(KisiselBilgiler p)
        {
            c.KisiselBilgilers.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index", "AAS");
        }
     
    }
}