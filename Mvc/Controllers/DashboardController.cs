using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;

namespace MySitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "DashboardWidget", Title = "Dashboard Page Widget", SectionName = "Dashboard Widgets")]
    public class DashboardController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}