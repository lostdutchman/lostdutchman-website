using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DutchmanSite.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string name, string email, string message, string phone = "Non Entered")
        {
            Helper.FormEmail help = new Helper.FormEmail();
            help.SendEmail(name, email, message, phone);
            return View();
        }

        [HttpGet]
        public ActionResult TodaysWord(string id)
        {
            Helper.TodaysWord help = new Helper.TodaysWord();
            return Content(help.jsonBuilder(id), "application/json");
        }

        [HttpGet]
        public ActionResult Alexa(string id)
        {
            Helper.AlexaFlashBrief help = new Helper.AlexaFlashBrief();
            return Content(help.jsonBuilder(id), "application/json");
        }

        [HttpGet]
        public ActionResult NiceBowling()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Error()
        {
            return View();
        }
    }
}
