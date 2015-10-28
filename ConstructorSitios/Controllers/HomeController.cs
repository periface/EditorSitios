using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConstructorSitios.Controllers
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
        public ActionResult ConstructorJquery() {
            return View();
        }
        public ActionResult ConstructorGridStack() {
            
            return View();
        }
        public JsonResult diseno() {
            if (Session["model"] != null) {
                return Json(Session["model"],JsonRequestBehavior.AllowGet);
            }
            return Json("",JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult Guardar(List<disenoModel> model) {
            Session["model"] = model;
            return Json(new { ok=true },JsonRequestBehavior.AllowGet);
        }
        public class disenoModel {
            public int x { get; set; }
            public int y { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public string id { get; set; }
        }
    }
}