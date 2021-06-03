using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Reporting_AspNetMvc_Create_Custom_Control.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult Designer() {
            Models.ReportDesignerModel model = new Models.ReportDesignerModel();
            return View(model);
        }
    }
}
