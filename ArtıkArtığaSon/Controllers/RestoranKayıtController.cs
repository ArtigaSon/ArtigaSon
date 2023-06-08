using ArtıkArtığaSon.Models.Sınıflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArtıkArtığaSon.Controllers
{
    public class RestoranKayıtController : Controller
    {
        // GET: RestoranKayıt
        Context c = new Context();

        [Authorize]
        [HttpGet]
        public ActionResult Index()
        {
            var degerler = c.Ilans.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Index(Ilan p)
        {
            c.Ilans.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index", "AAS");
        }

    }
}