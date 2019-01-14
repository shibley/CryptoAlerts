using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoAlerts
{
    public class ManageAlerts
    {
        public List<AlertSetting> alertSettings;
        public string sRequest = "";

        public ManageAlerts() { }

        public ManageAlerts(string sSubscriptionType)
        {
            sRequest = BuildRequest(sSubscriptionType);
        }

        public static async void CheckAlerts(List<AlertSetting> alertSettings, string sData)
        {
            //parse data to get current prices
            CryptoCurrencyUpdate cUpdate = Parse(sData);

            if (cUpdate != null)
            {
                string sExchange = cUpdate.ExchangeName;
                string sCurrencyPair = cUpdate.CryptoCurrencyName + "/" + cUpdate.FiatCurrencyName;

                if (alertSettings != null)
                {
                    //loop through settings to see if we need to send any
                    foreach (AlertSetting aSetting in alertSettings)
                    {
                        //check for match
                        if (aSetting.Exchanx.SName == cUpdate.ExchangeName
                            && aSetting.CurrencyPair.SName == (cUpdate.CryptoCurrencyName + "/" + cUpdate.FiatCurrencyName))
                        {
                            //check for setting conditions
                            if(cUpdate.LastPrice > aSetting.PriceHigh)
                                await CreateAlert(aSetting.IAlertSettingId, aSetting.IUserId.Value, "Price Up", "");

                            else if (cUpdate.LastPrice < aSetting.PriceLow)
                                await CreateAlert(aSetting.IAlertSettingId, aSetting.IUserId.Value, "Price Down", "");

                        }
                    }
                }
            }
        }

        public static async Task<Alert> CreateAlert(int iAlertSettingId, int iUserId, string sTitle, string sMessage)
        {
            Alert alert = new Alert();

            using (CryptoAlertsContext dbContext = new CryptoAlertsContext())
            {
                int iAlerts = dbContext.Alerts.Where(x => x.IUserId == iUserId 
                    && x.IAlertSettingId == iAlertSettingId
                    && !x.DtDeleted.HasValue
                    && !x.DtSent.HasValue).Count();

                if (iAlerts == 0)
                {
                    alert.IAlertSettingId = iAlertSettingId;
                    alert.IUserId = iUserId;
                    alert.SMessage = sMessage;
                    alert.STitle = sTitle;

                    dbContext.Alerts.Add(alert);
                    int id = await dbContext.SaveChangesAsync();
                    alert.IAlertId = id;

                    Console.WriteLine("Alert table updated: " + id);
                }
            }

            return alert;
        }

        /// <summary>
        /// Builds string request from AlertSettings to be sent to CryptoCompare subscribe call
        /// sample output: "42[\"SubAdd\",{\"subs\":[\"0~Bitstamp~BTC~USD\",\"0~Coinbase~BTC~USD\"]}]"
        /// </summary>
        /// <param name="sSubcriptionType"></param>
        /// <returns>Return null if parsing was not possible</returns>
        public string BuildRequest(string sSubcriptionType)
        {
            string sRequest = "42[\"SubAdd\",{\"subs\":[";
            //\"0~Bitstamp~BTC~USD\",\"0~Coinbase~BTC~USD\"]}]";

            using (CryptoAlertsContext dbContext = new CryptoAlertsContext())
            {
                this.alertSettings = dbContext.AlertSettings.Where(x => x.DtDeleted == null && x.BActive == true).ToList<AlertSetting>();

                int iCount = this.alertSettings.Count;

                foreach (AlertSetting alertSetting in this.alertSettings)
                {
                    //build subscription string
                    string sSetting = "\"" + sSubcriptionType + "~" + alertSetting.Exchanx.SName;
                    sSetting += "~" + alertSetting.CurrencyPair.SName.Replace('/', '~') + "\"";

                    sRequest += sSetting;

                    if (iCount > 1)
                        sRequest += ",";

                    iCount--;
                }

                sRequest += "]}]";
            }

            return sRequest;
        }

        /// <summary>
		/// Parses plain txt update to CryptoCurrencyUpdate
		/// sample input: 42["m","0~Bitfinex~BTC~USD~1~159021061~1515488499~0.119~15091.30724464~1795.86556211216~1f"]
		/// </summary>
		/// <param name="str"></param>
		/// <returns>Return null if parsing was not possible</returns>
		private static CryptoCurrencyUpdate Parse(String str)
        {
            if (str.Length < 3 || !str.Substring(0, 2).Equals("42"))
                return null;

            CryptoCurrencyUpdate retVal = new CryptoCurrencyUpdate();
            var strValues = str.Substring(2).Split(',')[1].Split('~');

            if (strValues[0].Substring(1) != "0" && strValues[0].Substring(1) != "2")//could be 2?
                return null;

            retVal.ExchangeName = strValues[1];
            retVal.CryptoCurrencyName = strValues[2];
            retVal.FiatCurrencyName = strValues[3];

            if (strValues.Length > 7)
            {
                decimal decVal;
                if (decimal.TryParse(strValues[7], NumberStyles.Number, CultureInfo.InvariantCulture, out decVal))
                {
                    retVal.Quantity = decVal;
                }

                if (decimal.TryParse(strValues[8], NumberStyles.Number, CultureInfo.InvariantCulture, out decVal))
                {
                    retVal.LastPrice = decVal;
                }
            }

            return retVal;
        }
    }
}
