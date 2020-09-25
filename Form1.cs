using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebSocketSimpleExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
