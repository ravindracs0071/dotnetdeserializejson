using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxApp.Controllers
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

        [HttpPost]
        public ActionResult Index(List<int> elements)
        {

            return Json(elements.Count, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult CallCounter(List<Int64> elements)
        {

            return Json(elements.Count, JsonRequestBehavior.AllowGet);
        }
    }
}