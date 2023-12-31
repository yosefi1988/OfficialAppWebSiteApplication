using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OfficialAppWebSiteApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(string ApplicationID, string storeName)
        {

            ViewBag.ApplicationID = ApplicationID;
            ViewBag.storeName = storeName;


            bool isValid = true;  
            var obj = new
            {
                valid = isValid
            };
           // return Json(obj);
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