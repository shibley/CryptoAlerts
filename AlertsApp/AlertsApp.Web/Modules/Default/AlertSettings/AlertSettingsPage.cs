
namespace AlertsApp.web.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("AlertSettings"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.AlertSettingsRow))]
    public class AlertSettingsController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/AlertSettings/AlertSettingsIndex.cshtml");
        }
    }
}