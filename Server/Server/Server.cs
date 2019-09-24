using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace Server
{
    public partial class Form1 : Form
    {
        delegate void AppendTextDelegate(Control ctrl, string s);
        AppendTextDelegate textAppender;
        Socket mainSock;
        IPAddress thisAddress;
        //ClientMachinestate Machinestate;
        //bool PinholeOnStart;
        public Form1()
        {
            InitializeComponent();
            mainSock =
                new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            textAppender = new AppendTextDelegate(AppendText);
        }

        void AppendText(Control ctrl, string s)
        {
            if (ctrl.InvokeRequired) ctrl.Invoke(textAppender, ctrl, s);
            else
            {
                string source = ctrl.Text;
                ctrl.Text = source + Environment.NewLine + s;
            }
        }


        IPEndPoint serverEP = new IPEndPoint(IPAddress.Any, 2019);

        private void Form1_Load(object sender, EventArgs e)
        {
            IPHostEntry he = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress addr in he.AddressList)
            {
                if (addr.AddressFamily == AddressFamily.InterNetwork)
                {
                    thisAddress = addr;
                    break;
                }
            }
            if (thisAddress == null)
                thisAddress = IPAddress.Loopback;
            txtAddress.Text = thisAddress.ToString();
        }

        List<Socket> connectedClients = new List<Socket>();
        void AcceptCallback(IAsyncResult ar)
        {
            Socket client = mainSock.EndAccept(ar);
            mainSock.BeginAccept(AcceptCallback, null);
            AsyncObject obj = new AsyncObject(4096);
            obj.WorkingSocket = client;
            connectedClients.Add(client);
            AppendText(txtHistory, string.Format("클라이언트 (@{0})가 연결되었습니다.", client.RemoteEndPoint));
            client.BeginReceive(obj.Buffer, 0, 4096, 0, DataReceived, obj);
        }
        void DataReceived(IAsyncResult ar)
        {
            AsyncObject obj = (AsyncObject)ar.AsyncState;
            int received = obj.WorkingSocket.EndReceive(ar);
            if(received <= 0)
            {
                obj.WorkingSocket.Close();
                return;
            }

            string text = Encoding.UTF8.GetString(obj.Buffer);
            string[] tokens = text.Split('\x01');
            string ip = tokens[0];
            string msg = tokens[1];

            AppendText(txtHistory, string.Format("{0}:{1}", ip, msg));
            for(int i = connectedClients.Count -1; i>= 0; i--)
            {
                Socket socket = connectedClients[i];
                if (socket != obj.WorkingSocket)
                {
                    try { socket.Send(obj.Buffer); }
                    catch
                    {
                        try { socket.Dispose(); } catch { }
                        connectedClients.RemoveAt(i);
                    }
                }
            }
            obj.ClearBuffer();
            obj.WorkingSocket.BeginReceive(obj.Buffer, 0, 4096, 0, DataReceived, obj);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {            
            mainSock.Close();           
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            List<string> msglist = new List<string>(5);
            msglist.Add(lotno.Text); // uint 0
            msglist.Add(worker.Text); // uint 1
            msglist.Add(modelname.Text); //string 변환 x 2
            msglist.Add(paste.Text); // .. 3
            msglist.Add(Speed.Text); // float.1 4
            string message = string.Format("{0},{1},{2},{3},{4}", lotno.Text, worker.Text, modelname.Text, paste.Text, Speed.Text);
            message.Split('\x01');

            List<Control> textboxlist = new List<Control>();
            textboxlist.Add(lotno);
            textboxlist.Add(worker);
            textboxlist.Add(modelname);
            textboxlist.Add(paste);
            textboxlist.Add(Speed);
            Control list = new Control(string.Format("{0}, {1}, {2} ,{3}, {4}", lotno, worker, modelname, paste, Speed));

            if (!mainSock.IsBound)
            {
                MessageBox.Show("서버가 실행되고 있지 않습니다!", "Not Found Server!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
          
            byte[] bDts = Encoding.UTF8.GetBytes("\0x01"+ message);
            for (int i = connectedClients.Count -1; i >= 0; i--)
            {
                Socket socket = connectedClients[i];
                try { socket.Send(bDts); } catch {
                    try { socket.Dispose(); } catch { }
                    connectedClients.RemoveAt(i);
                }
            }
            AppendText(txtHistory,message);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int port;
            if (!int.TryParse(txtPort.Text, out port))
            {
                txtPort.Focus();
                txtPort.SelectAll();
                return;
            }
            IPEndPoint serverEP = new IPEndPoint(thisAddress, port);
            mainSock.Bind(serverEP);
            mainSock.Listen(10);

            mainSock.BeginAccept(AcceptCallback, null);
        }

        private void Pinhole_Click(object sender, EventArgs e)
        {
           
        }
    }
}
