using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace viewBagdatatempdata.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult kullanim()
        {
            ViewBag.BagKullanim = "Burda viewbag mesajı var";
            ViewData["DataKullanim"] = "burda viewdata kullanımı yazar";
            TempData["TempKullanim"] = "burda tempdata kullanımı yazar";

            var Notlar = new List<int>
            { 25,12,59,47};
            ViewBag.Notlar = Notlar;

            var Gunler = new List<string>
            { "salı","cuma","pazar"};
            ViewData["Gunler"] = Gunler;


            return RedirectToAction("Contact");
        }
    }
}