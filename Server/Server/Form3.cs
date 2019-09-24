using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Form3 : Form
    {
        delegate void AppendTextDelegate(Control ctrl, string s);
        AppendTextDelegate textAppender;
        Socket mainSock;

        public Form3()
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
                string sourse = ctrl.Text;
                ctrl.Text = sourse + Environment.NewLine + s;
            }
        }


        void DataReceived(IAsyncResult ar)
        {
            AsyncObject obj = (AsyncObject)ar.AsyncState;


            int received = obj.WorkingSocket.EndReceive(ar);
            if (received <= 0)
            {
                obj.WorkingSocket.Close();
                return;
            }
            string text = Encoding.UTF8.GetString(obj.Buffer);

            string message = string.Format("{0}:{1}:{2}:{3}:{4}", LotNo, Worker, ModelName, Paste, Speed);
            text.Split('\x01');
            text.Split('\x20');
            text.Trim();

            AppendText(LotNo, text); //ctrl,string 
            AppendText(Worker, text);
            AppendText(ModelName, text);
            AppendText(Paste, text);
            AppendText(Speed, text);

            obj.ClearBuffer();
            obj.WorkingSocket.BeginReceive(obj.Buffer, 0, 4096, 0, DataReceived, obj);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (mainSock.Connected)
            {
                return;
            }
            int port;
            if (!int.TryParse(txtPort.Text, out port))
            {
                txtPort.Focus();
                txtPort.SelectAll();
                return;
            }
            try { mainSock.Connect(txtIP.Text, port); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed to Connecting \n Error:{0}",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.btnConnect.Text = "Connected";
            AppendText(txtHistory, "Connected to server");
            AsyncObject obj = new AsyncObject(4096);
            obj.WorkingSocket = mainSock;
            mainSock.BeginReceive(obj.Buffer, 0, obj.BufferSize, 0, DataReceived, obj);
        }

        private void ClearButton_Click_1(object sender, EventArgs e)
        {
            LotNo.Clear(); Worker.Clear(); ModelName.Clear(); Paste.Clear(); Speed.Clear();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            IPHostEntry he = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress defaultHostAddress = null;
            foreach (IPAddress addr in he.AddressList)
            {
                if (addr.AddressFamily == AddressFamily.InterNetwork)
                {
                    defaultHostAddress = addr;
                    break;
                }
            }
            if (defaultHostAddress == null)
                defaultHostAddress = IPAddress.Loopback;
            txtIP.Text = defaultHostAddress.ToString();
        }
    }
}
