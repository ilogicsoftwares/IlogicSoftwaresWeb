using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IlogicSoftwaresWeb.Models;
using Newtonsoft.Json;


namespace IlogicSoftwaresWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            pirumpi_ilogicEntities contex = new pirumpi_ilogicEntities();
            var listaprod = contex.products.ToList();
            if (listaprod.Count > 0)
            {
                ViewBag.listadeprods = JsonConvert.SerializeObject(listaprod);
            }
            else
            {
                ViewBag.listadeprods = JsonConvert.SerializeObject(null);
            }
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