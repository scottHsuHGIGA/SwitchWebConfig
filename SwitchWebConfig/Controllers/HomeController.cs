using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConfigManager.Service;

namespace SwitchWebConfig.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["TestStringA"] =ConfigManagerService.AppSettings["TestStringA"];
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