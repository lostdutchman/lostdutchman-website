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
            this.Username = "FB#< v5bh]ES$NKPwKq~6 &@~37Xq{^ 4(6 > U5DX7z";
            this.Password = "LnZ8eW@8!A6c,.9uL2  PWG^K46U:96b8hr6@N2Hk";
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
        public ActionResult Index(string name, string email, string message, string Question1, string Question2)
        {
            FormEmail help = new FormEmail();
            if (Question1 == "" && Question2 == "")//capcha
            {
                help.SendEmail(name, email, message);
            }
            else {
                help.Spam("failed capcha");
            }
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
            return Redirect("https://goo.gl/forms/zYEzG8BRxkw0F3Ho2");
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
