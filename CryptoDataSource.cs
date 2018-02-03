﻿using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebSocket4Net;

namespace CryptoAlerts
{
    public class CryptoDataSource : IDisposable
    {
        public event EventHandler<DataReceivedEventArgs> DataRecieved;
        System.Timers.Timer _timer = new System.Timers.Timer(15000);
        WebSocket ws;

        public CryptoDataSource()
        {
            _timer.Elapsed += _timer_Elapsed;
        }

        private async void _timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (ws.State == WebSocketState.Open)
            {
                SendData("2");
            }
        }

        private void SendData(String str)
        {
            var encoded2 = Encoding.UTF8.GetBytes(str);
            var buffer2 = new ArraySegment<Byte>(encoded2, 0, encoded2.Length);
            ws.Send(str);
        }


        public void StartLoadingData()
        {
            ws = new WebSocket("wss://streamer.cryptocompare.com/socket.io/?transport=websocket", "", WebSocketVersion.None);
            ws.Opened += new EventHandler(websocket_Opened);
            //ws.Error += new EventHandler<ErrorEventArgs>(websocket_Error);
            //ws.Closed += new EventHandler(websocket_Closed);
            ws.MessageReceived += new EventHandler<MessageReceivedEventArgs>(websocket_MessageReceived);
            ws.Open();
           
        }

        private void websocket_MessageReceived(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void websocket_Opened(object sender, EventArgs e)
        {
            _timer.Start();

            var data2 = "42[\"SubAdd\",{\"subs\":[\"0~Cryptsy~BTC~USD\",\"0~Bitstamp~BTC~USD\",\"0~OKCoin~BTC~USD\",\"0~Coinbase~BTC~USD\",\"0~Poloniex~BTC~USD\",\"0~Cexio~BTC~USD\",\"0~BTCE~BTC~USD\",\"0~BitTrex~BTC~USD\",\"0~Kraken~BTC~USD\",\"0~Bitfinex~BTC~USD\",\"0~LocalBitcoins~BTC~USD\",\"0~itBit~BTC~USD\",\"0~HitBTC~BTC~USD\",\"0~Coinfloor~BTC~USD\",\"0~Huobi~BTC~USD\",\"0~LakeBTC~BTC~USD\",\"0~Coinsetter~BTC~USD\",\"0~CCEX~BTC~USD\",\"0~MonetaGo~BTC~USD\",\"0~Gatecoin~BTC~USD\",\"0~Gemini~BTC~USD\",\"0~CCEDK~BTC~USD\",\"0~Exmo~BTC~USD\",\"0~Yobit~BTC~USD\",\"0~BitBay~BTC~USD\",\"0~QuadrigaCX~BTC~USD\",\"0~BitSquare~BTC~USD\",\"0~TheRockTrading~BTC~USD\",\"0~Quoine~BTC~USD\",\"0~LiveCoin~BTC~USD\",\"0~WavesDEX~BTC~USD\",\"0~Lykke~BTC~USD\",\"0~Remitano~BTC~USD\",\"0~Coinroom~BTC~USD\",\"0~Abucoins~BTC~USD\",\"0~TrustDEX~BTC~USD\",\"0~BTCChina~BTC~USD\",\"0~bitFlyer~BTC~USD\"]}]";
            SendData(data2);

            ArraySegment<Byte> readbuffer = new ArraySegment<byte>(new Byte[8192]);
            while (ws.State == WebSocketState.Open)
            {
                DataReceivedEventArgs updateValue = null;
                try
                {
                    // var result = ws.//await ws.ReceiveAsync(readbuffer, CancellationToken.None);
                    ws.DataReceived += DataRecieved;

                    //var str = System.Text.Encoding.Default.GetString(readbuffer.Array, readbuffer.Offset, ws.ReceiveBufferSize);
                    //DataRecieved.. = Parse(str);
                    //if (updateValue != null)
                    //{
                    DataRecieved?.Invoke(this, updateValue);
                    //}
                }
                catch (TaskCanceledException)
                {
                    System.Diagnostics.Debug.Write("WebSocket Stopped");
                }
            }
        }

        public void StopLoadingData()
        {
            try
            {
                if (ws.State != WebSocketState.Closed)
                    ws.Close();//.CloseAsync(WebSocketCloseStatus.Empty, String.Empty, CancellationToken.None);
            }
            finally
            {
                ws.Dispose();
                _timer.Stop();
            }
        }

        /// <summary>
        /// Parses plain txt update to CryptoCurrencyUpdate
        /// sample input: 42["m","0~Bitfinex~BTC~USD~1~159021061~1515488499~0.119~15091.30724464~1795.86556211216~1f"]
        /// </summary>
        /// <param name="str"></param>
        /// <returns>Return null if parsing was not possible</returns>
        private CryptoCurrencyUpdate Parse(String str)
        {
            if (str.Length < 3 || !str.Substring(0, 2).Equals("42"))
                return null;

            CryptoCurrencyUpdate retVal = new CryptoCurrencyUpdate();
            var strValues = str.Substring(2).Split(',')[1].Split('~');

            if (strValues[0].Substring(1) != "0")
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

        public void Dispose()
        {
            if (_timer != null)
            {
                _timer.Dispose();
                _timer = null;
            }

            if (ws != null)
            {
                ws.Dispose();
                ws = null;
            }
        }
    }
}
