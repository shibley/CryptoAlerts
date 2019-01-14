
namespace AlertsApp.Common.Pages
{
    using Serenity;
    using Serenity.Data;
    using System;
    using System.Web.Mvc;
    using web.Default.Endpoints;
    using web.Default.Entities;
    using MyRepository = web.Default.Repositories.AlertsRepository;

    [RoutePrefix("Dashboard"), Route("{action=index}")]
    public class DashboardController : Controller
    {
        [Authorize, HttpGet, Route("~/")]
        public ActionResult Index()
        {

            var model = new DashboardPageModel();
            var row = AlertsRow.Fields;
            using (var connection = SqlConnections.NewFor<AlertsRow>())
            {
                SqlQuery queryAlerts = new SqlQuery();

                model.ActiveAlerts = connection.Count<AlertsRow>(row.IUserId == Authorization.UserId);
            }

            return View(MVC.Views.Common.Dashboard.DashboardIndex, model);
        }

        [Authorize, HttpGet, Route("~/Reports")]
        public ActionResult Reports()
        {

            //var model = new Reports();
            //var row = AlertsRow.Fields;
            //using (var connection = SqlConnections.NewFor<AlertsRow>())
            //{
            //    SqlQuery queryAlerts = new SqlQuery();

            //    model.ActiveAlerts = connection.Count<AlertsRow>(row.IUserId == Authorization.UserId);
            //}

            return View(MVC.Views.Common.Reporting.ReportPage);
        }
    }
}
