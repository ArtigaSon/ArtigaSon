using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArtıkArtığaSon.Controllers
{
    public class AASController : Controller
    {
        // GET: AAS
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [Authorize]
        public ActionResult Ilanlar()
        {
            return View();
        }

    }
}