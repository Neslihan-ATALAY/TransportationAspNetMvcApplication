using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TransportationMvc2Project.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        [Authorize(Roles = "KULLANICI, ŞİRKET")]
        public ActionResult Index()
        {
            ViewData["Message"] = "Transportation Application - Nakliyat Uygulaması";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
