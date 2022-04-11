using DutchmanSite.Helper;
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

        [HttpGet]
        public ActionResult TodaysWord(string id)
        {
            TodaysWord help = new TodaysWord();
            return Content(help.jsonBuilder(id), "application/json");
        }

        [HttpGet]
        public ActionResult Alexa(string id)
        {
            AlexaFlashBrief help = new AlexaFlashBrief();
            return Content(help.jsonBuilder(id), "application/json");
        }

        [HttpGet]
        public ActionResult NiceBowling()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SumoSpin()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SumoSpinLegalJargon()
        {
            return View();
        }

        [HttpGet]
        public ActionResult WyrdOfStromgard()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Error()
        {
            return View();
        }

        [HttpGet]
        public ActionResult NiceBowlingLegalJargon()
        {
            return View();
        }

        [HttpGet]
        public ActionResult WyrdOfStromgardDevLog()
        {
            return View();
        }
    }
}
