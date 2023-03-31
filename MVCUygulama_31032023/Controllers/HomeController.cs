using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUygulama_31032023.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult AnaSayfa()
        {
            return View();
        }
        public ActionResult Hakkımızda()
        {
            return View();
        }
        public ActionResult Iletisim()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index2()
        {
            return View();
        }

    }
}