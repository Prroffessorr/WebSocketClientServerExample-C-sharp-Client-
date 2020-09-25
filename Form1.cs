using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebSocketSimpleExample
{
    public partial class Form1 : Form
    {
        TextWriter _writer = null;

        public Form1()
        {
            InitializeComponent();
            _writer = new StreamWrite(ConsoleMessage);
            Console.SetOut(_writer);
        }

        WebSocket websocket = new WebSocket();

        private void Connect_Click(object sender, EventArgs e)
        {
            websocket.Websock_Client_Node();   
        }

        private void Send_Message_Click(object sender, EventArgs e)
        {
            if (Message.Text != null)
            {

                websocket.WebSocketClient.Send(Message.Text);
            }
        }
    }
}
