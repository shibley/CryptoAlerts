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
        public static List<AlertSetting> InitializeAlertSettings(string sData)
        {
            List<AlertSetting> alertSettings = new List<AlertSetting>();
            //parse data to get exchanges and pairs
            CryptoCurrencyUpdate cUpdate = Parse(sData);

            if (cUpdate != null)
            {
                string sExchange = cUpdate.ExchangeName;
                string sCurrencyPair = cUpdate.CryptoCurrencyName + "/" + cUpdate.FiatCurrencyName;
            }

            return alertSettings;
        }

        public static void CheckAlerts(List<AlertSetting> alertSettings, string sData)
        {
            //parse data to get current prices
            CryptoCurrencyUpdate cUpdate = Parse(sData);

            if (cUpdate != null)
            {
                string sExchange = cUpdate.ExchangeName;
                string sCurrencyPair = cUpdate.CryptoCurrencyName + "/" + cUpdate.FiatCurrencyName;
            }

            if (alertSettings != null)
            {
                //loop through settings to see if we need to send any
                foreach (AlertSetting aSetting in alertSettings)
                {

                }
            }
        }

        public static List<AlertSetting> GetAlertSettings(int iPairID, int iExchangeId)
        {
            using (CryptoAlertsContext dbContext = new CryptoAlertsContext())
            {
                return dbContext.AlertSettings.Where(x => x.ICurrencyPairId == iPairID && x.IExchangeId == iExchangeId).ToList<AlertSetting>();               
            }
        }

        public static Alert CreateAlert(int iUserId, string sTitle, string sMessage)
        {
            Alert alert = new Alert();
            using (CryptoAlertsContext dbContext = new CryptoAlertsContext())
            {
                alert.IUserId = iUserId;
                alert.SMessage = sMessage;
                alert.STitle = sTitle;

                dbContext.Alerts.Add(alert);
                dbContext.SaveChanges();
            }

            return alert;
        }

        /// <summary>
        /// Builds string request from AlertSettings to be sent to CryptoCompare subscribe call
        /// sample output: "42[\"SubAdd\",{\"subs\":[\"0~Bitstamp~BTC~USD\",\"0~Coinbase~BTC~USD\"]}]"
        /// </summary>
        /// <param name="str"></param>
        /// <returns>Return null if parsing was not possible</returns>
        public static string BuildRequest(string sSubcriptionType)
        {
            string sRequest = "42[\"SubAdd\",{\"subs\":[";//\"0~Bitstamp~BTC~USD\",\"0~Coinbase~BTC~USD\"]}]";

            using (CryptoAlertsContext dbContext = new CryptoAlertsContext())
            {
                List<AlertSetting> alertSettings = dbContext.AlertSettings.Where(x => x.DtCreated == null).ToList<AlertSetting>();

                foreach(AlertSetting alertSetting in alertSettings)
                {
                    //build subscription string
                    string sSetting = "\"" + sSubcriptionType + "~" + alertSetting.Exchanx.SName;
                    sSetting += "~" + alertSetting.CurrencyPair.SName.Replace('/', '~') + "\"";

                    sRequest += sSetting;
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

            if (strValues[0].Substring(1) != "0")//could be 2?
                return null;

            retVal.ExchangeName = strValues[1];
            retVal.CryptoCurrencyName = strValues[2];
            retVal.FiatCurrencyName = strValues[3];

            decimal decVal;
            if (decimal.TryParse(strValues[7], NumberStyles.Number, CultureInfo.InvariantCulture, out decVal))
            {
                retVal.Quantity = decVal;
            }

            if (decimal.TryParse(strValues[8], NumberStyles.Number, CultureInfo.InvariantCulture, out decVal))
            {
                retVal.LastPrice = decVal;
            }

            return retVal;
        }
    }
}
