﻿
namespace CryptoAlerts.web.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/CurrencyPairs"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.CurrencyPairsRow))]
    public class CurrencyPairsController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/CurrencyPairs/CurrencyPairsIndex.cshtml");
        }
    }
}