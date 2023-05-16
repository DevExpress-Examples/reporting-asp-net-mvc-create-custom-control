using System.Web;
using System.Web.Mvc;

namespace Reporting_AspNetMvc_Create_Custom_Control {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
