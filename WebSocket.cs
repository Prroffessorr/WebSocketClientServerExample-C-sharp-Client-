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
        bool Connect_Disconnect = false;

        public WebSocketSharp.WebSocket WebSocketClient = null;

        public void Websock_Client_Node()
        {
            if (Connect_Disconnect == false)
            {
                try
                {
                    WebSocketClient = new WebSocketSharp.WebSocket(serverUri.ToString());
                    WebSocketClient.OnMessage += wsServer_NewDataReceived;
                    WebSocketClient.OnOpen += wsServer_NewSessionConnected;
                    WebSocketClient.OnError += wsServer_OnError;
                    WebSocketClient.OnClose += wsServer_Disconnect;
                    WebSocketClient.Connect();
                    Console.WriteLine("Connection Open");
                    Connect_Disconnect = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Connect_Disconnect = false;
                }
            }
            else
            {
                WebSocketClient.Send("User is already connected");
            }
        }

        private void wsServer_Disconnect(object sender, CloseEventArgs e)
        {
            Console.Write("Connection Close");
            if(Connect_Disconnect == true)
            {
                Connect_Disconnect = false;
            }
        }
        private void wsServer_OnError(object sender, WebSocketSharp.ErrorEventArgs e)
        {
            Console.WriteLine(e.Exception);
        }
        private void wsServer_NewSessionConnected(object sender, EventArgs e)
        {
            WebSocketClient.Send("User connected");

        }
        private void wsServer_NewDataReceived(object sender, MessageEventArgs e)
        {
            string result = e.Data.ToString();
            Console.WriteLine("MessageReceived:" + e.Data.ToString());
        }

    }
}
