using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;

namespace WebSocketSimpleExample
{
    class WebSocket
    {
        Uri serverUri = new Uri("ws://localhost:8080");

        public WebSocketSharp.WebSocket WebSocketClient = null;

        public void Websock_Client_Node()
        {
            WebSocketClient = new WebSocketSharp.WebSocket(serverUri.ToString());
            WebSocketClient.OnMessage += wsServer_NewDataReceived;
            WebSocketClient.OnOpen += wsServer_NewSessionConnected;
            WebSocketClient.OnError += wsServer_OnError;
            WebSocketClient.OnClose += wsServer_Disconnect;
            WebSocketClient.Connect();
        }

        private void wsServer_Disconnect(object sender, CloseEventArgs e)
        {
            Console.Write("disconnect");
        }
        private void wsServer_OnError(object sender, WebSocketSharp.ErrorEventArgs e)
        {
            Console.WriteLine(e.Exception);
        }
        private void wsServer_NewSessionConnected(object sender, EventArgs e)
        {
            WebSocketClient.Send("User with ID: connected");

        }
        private void wsServer_NewDataReceived(object sender, MessageEventArgs e)
        {
            string result = e.Data.ToString();
            Console.WriteLine("NewMessageReceived:" + e.Data.ToString());
        }


    }
}
