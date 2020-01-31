using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TakipWeb.Web.Models;


namespace TakipWeb.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            DataTable tablo = new DataTable();
            ViewData["TakipDosya"] = tablo;

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
    }
}