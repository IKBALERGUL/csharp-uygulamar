using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcpartialview.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Hakkimizda()
        {
            return View();
        }
        public ActionResult Iletisim()
        {
            return View();
        }
        public ActionResult Asp()
        {
            return View();
        }
        public ActionResult Sql()
        {
            return View();
        }
        public ActionResult BootStarp()
        {
            return View();
        }
    }
}