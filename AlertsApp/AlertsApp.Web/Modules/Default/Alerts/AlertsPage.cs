
namespace AlertsApp.web.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/Alerts"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.AlertsRow))]
    public class AlertsController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/Alerts/AlertsIndex.cshtml");
        }
    }
}