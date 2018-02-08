using Serenity.Navigation;
using MyPages = AlertsApp.web.Default.Pages;

[assembly: NavigationLink(int.MaxValue, "Alerts", typeof(MyPages.AlertsController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Alert Settings", typeof(MyPages.AlertSettingsController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Currency Pairs", typeof(MyPages.CurrencyPairsController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Exchanges", typeof(MyPages.ExchangesController), icon: null)]