using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace nested.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Iletisim()
        {
            return View();
        }
        public ActionResult Referanslar()
        {
            return View();
        }
        public ActionResult AdaKonut()
        {
            return View();
        }
        public ActionResult GuzelKonut()
        {
            return View();
        }
        public ActionResult MerkezKonut()
        {
            return View();
        }

    }
}