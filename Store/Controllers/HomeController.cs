using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyBll bll = new MyBll();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var result = bll.GetProducersCountByConcreteMark();


            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}