
namespace AlertsApp.web.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/Exchanges"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.ExchangesRow))]
    public class ExchangesController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/Exchanges/ExchangesIndex.cshtml");
        }
    }
}