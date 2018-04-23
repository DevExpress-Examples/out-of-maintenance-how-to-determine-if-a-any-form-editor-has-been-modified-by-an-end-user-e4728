using System.Web.Mvc;

namespace TrackChanges.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }
        public ActionResult About() {
            return View();
        }
    }
}