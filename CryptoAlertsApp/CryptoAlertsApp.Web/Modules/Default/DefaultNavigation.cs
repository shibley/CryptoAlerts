using Serenity.Navigation;
using MyPages = CryptoAlerts.web.Default.Pages;

[assembly: NavigationLink(int.MaxValue, "Default/Alerts", typeof(MyPages.AlertsController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Default/Alert Settings", typeof(MyPages.AlertSettingsController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Default/Currency Pairs", typeof(MyPages.CurrencyPairsController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Default/Exchanges", typeof(MyPages.ExchangesController), icon: null)]