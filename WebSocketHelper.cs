using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebSocket4Net;

namespace CryptoAlerts
{
    public class WebSocketHelper
    {
        private WebSocket webSocket;
        private AutoResetEvent _messageReceivedEvent = new AutoResetEvent(false);
        private string sUrl = "";
        private string _incomingMessage;
        private string _outgoingMessage;
        private string _errorMessage;

        public WebSocketHelper(string url)
        {
            webSocket = new WebSocket(url);
            webSocket.Opened += new EventHandler((sender, e) => webSocket_Opened(sender, e, this._outgoingMessage));
            webSocket.Error += new EventHandler<SuperSocket.ClientEngine.ErrorEventArgs>(webSocket_Error);
            webSocket.Closed += new EventHandler(webSocket_Closed);
            webSocket.MessageReceived += new EventHandler<MessageReceivedEventArgs>(webSocket_MessageReceived);
            sUrl = url;
        }

        private void webSocket_Closed(object sender, EventArgs e)
        {
            //resend and reopen
            if(string.IsNullOrEmpty(this._errorMessage))
                Send(this._outgoingMessage);
        }

        public string Send(string message)
        {
            this._outgoingMessage = message;
            webSocket.Open();
            this._errorMessage = "";//reset error
            this._messageReceivedEvent.WaitOne();
            return this._incomingMessage;
        }

        private void webSocket_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            CheckMessage(sender, e);
        }

        private void CheckMessage(object sender, MessageReceivedEventArgs e)
        {
            this._incomingMessage = e.Message;
            this._messageReceivedEvent.Set();
            Console.WriteLine(this._incomingMessage);
        }

        private void webSocket_Opened(object sender, EventArgs e, string message)
        {
            webSocket.Send(message);
        }

        private void webSocket_Error(object sender, SuperSocket.ClientEngine.ErrorEventArgs e)
        {
            this._errorMessage = e.Exception.Message;
            Console.WriteLine(this._errorMessage);
            webSocket.Close();
            webSocket.Dispose();

            //reinitialize
            WebSocketHelper wsh = new WebSocketHelper(sUrl);
            wsh.Send(this._outgoingMessage);
        }
    }
}
