using DutchmanSite.Models;
using DutchmanSite.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DutchmanSite.Controllers
{
    public class BasicAuthenticationAttribute : ActionFilterAttribute
    {
        public string BasicRealm { get; set; }
        protected string Username { get; set; }
        protected string Password { get; set; }

        public BasicAuthenticationAttribute(string username, string password)
        {
            this.Username = "Far over the misty mountains cold";
            this.Password = "To dungeons deep and caverns old";
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var req = filterContext.HttpContext.Request;
            var auth = req.Headers["Authorization"];
            if (!String.IsNullOrEmpty(auth))
            {
                var cred = System.Text.ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(auth.Substring(6))).Split(':');
                var user = new { Name = cred[0], Pass = cred[1] };
                if (user.Name == Username && user.Pass == Password) return;
            }
            var res = filterContext.HttpContext.Response;
            res.StatusCode = 401;
            res.AddHeader("WWW-Authenticate", String.Format("Basic realm=\"{0}\"", BasicRealm ?? "LostDutchamnSoftware"));
            res.End();
        }
    }

    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string name, string email, string message)
        {
            FormEmail help = new FormEmail();
            help.SendEmail(name, email, message);
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
        public ActionResult BetaTest()
        {
            return Redirect("https://docs.google.com/forms/d/e/1FAIpQLSf4GacszQah45byshI1cR2SiOUwLb6ef452YDM8I8AN6-P-jQ/viewform?usp=sf_link");
        }

        [HttpGet]
        [BasicAuthenticationAttribute("your-username", "your-password")]
        public ActionResult DevLogs()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        [BasicAuthenticationAttribute("your-username", "your-password")]
        public ActionResult DevLogs(string site, string icon, string iconText, string title, string summery, string description, int isPublished)
        {
            DevLogsModel DevLog = new DevLogsModel();
            DevLog.CreateNew(site, icon, iconText, title, summery, description, isPublished);
            return RedirectToAction("DevLogs");
        }

        [HttpGet]
        [BasicAuthenticationAttribute("your-username", "your-password")]
        public ActionResult EditDevLog()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        [BasicAuthenticationAttribute("your-username", "your-password")]
        public ActionResult EditDevLog(string site, string icon, string iconText, string title, string summery, string description, int isPublished, long logID)
        {
            DevLogsModel DevLog = new DevLogsModel();
            if(isPublished == 2)
            {
                DevLog.DeleteLog(logID);
            }
            else
            {
                DevLog.CreateNew(site, icon, iconText, title, summery, description, isPublished);
                DevLog.DeleteLog(logID);
            }
            return RedirectToAction("DevLogs");
        }

        [HttpPost]
        [BasicAuthenticationAttribute("your-username", "your-password")]
        public ActionResult UploadImage(HttpPostedFileBase file)
        {
            ImgUpload ImageHelp = new ImgUpload();
            return Json(ImageHelp.Upload(file));
        }
    }
}
