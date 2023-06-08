using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArtıkArtığaSon.Models.Sınıflar;

namespace ArtıkArtığaSon.Controllers
{
    public class IlanEkleController : Controller
    {
        // GET: Ilan
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