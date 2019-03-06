using BLL;
using Store.Models;


using System.Web.Mvc;

namespace Store.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMyBll bll;// = new MyBll();

        public HomeController(IMyBll bll)
        {
            this.bll = bll;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpPost]
        public ActionResult About(AboutModel model)
        {
            var result = bll.GetProducersCountByCocncreteMark(model.ConcreteMark);
            model.Quantity = result;
            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactModel model)
        {
            model.Countries = bll.GetCountriesByConcreteMark(model.ConcreteMark);
            return View(model);
        }
    }
}