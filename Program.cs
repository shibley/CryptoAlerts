using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;

namespace CryptoAlerts
{
    class Program
    {
        public static void Main(string[] args)
        {
            WebSocketHelper wsh = new WebSocketHelper("wss://streamer.cryptocompare.com/socket.io/?transport=websocket");
            ManageAlerts manager = new ManageAlerts("2");
            //string result = wsh.Send("42[\"SubAdd\",{\"subs\":[\"0~Cryptsy~BTC~USD\",\"0~Bitstamp~BTC~USD\",\"0~OKCoin~BTC~USD\",\"0~Coinbase~BTC~USD\",\"0~Poloniex~BTC~USD\",\"0~Cexio~BTC~USD\",\"0~BTCE~BTC~USD\",\"0~BitTrex~BTC~USD\",\"0~Kraken~BTC~USD\",\"0~Bitfinex~BTC~USD\",\"0~LocalBitcoins~BTC~USD\",\"0~itBit~BTC~USD\",\"0~HitBTC~BTC~USD\",\"0~Coinfloor~BTC~USD\",\"0~Huobi~BTC~USD\",\"0~LakeBTC~BTC~USD\",\"0~Coinsetter~BTC~USD\",\"0~CCEX~BTC~USD\",\"0~MonetaGo~BTC~USD\",\"0~Gatecoin~BTC~USD\",\"0~Gemini~BTC~USD\",\"0~CCEDK~BTC~USD\",\"0~Exmo~BTC~USD\",\"0~Yobit~BTC~USD\",\"0~BitBay~BTC~USD\",\"0~QuadrigaCX~BTC~USD\",\"0~BitSquare~BTC~USD\",\"0~TheRockTrading~BTC~USD\",\"0~Quoine~BTC~USD\",\"0~LiveCoin~BTC~USD\",\"0~WavesDEX~BTC~USD\",\"0~Lykke~BTC~USD\",\"0~Remitano~BTC~USD\",\"0~Coinroom~BTC~USD\",\"0~Abucoins~BTC~USD\",\"0~TrustDEX~BTC~USD\",\"0~BTCChina~BTC~USD\",\"0~bitFlyer~BTC~USD\"]}]");
            string result = wsh.Send(manager.sRequest, manager.alertSettings);//,\"2~Poloniex~BTC~USD\",\"2~Bitfinex~BTC~USD\
            //Console.WriteLine(result);
            Console.ReadKey(true);

        }
    }
}
