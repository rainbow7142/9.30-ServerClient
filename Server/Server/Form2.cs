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
    public partial class Form2 : Form
    {
        delegate void AppendTextDelegate(Control ctrl, string s);
        AppendTextDelegate textAppender;
        Socket mainSock;
        Form1 form1 = new Form1();


        public Form2()
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

        private void Form2_Load(object sender, EventArgs e)
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
            txtPort.Text = form1.txtPort.Text;
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
                MessageBox.Show(ex.Message, "Failed to Connecting",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AppendText(txtHistory, Convert.ToString(DateTime.Now) + "\r\n" + "연결됨");
            AsyncObject obj = new AsyncObject(4096);
            obj.WorkingSocket = mainSock;
            mainSock.BeginReceive(obj.Buffer, 0, obj.BufferSize, 0, DataReceived, obj);
        }

        void DataReceived(IAsyncResult ar)
        {
            try
            {
                AsyncObject obj = (AsyncObject)ar.AsyncState;

                int received = obj.WorkingSocket.EndReceive(ar);
                if (received <= 0)
                {
                    obj.WorkingSocket.Close();
                    return;
                }

                string text = Encoding.UTF8.GetString(obj.Buffer);
                string[] grd = text.Split(',');
                string messageLotnumber = grd[0];
                string messageWorker = grd[1];
                string messageModelName = grd[2];
                string messagePaste = grd[3];
                string messageSpeed = grd[4];

                AppendText(LotNo, messageLotnumber); //ctrl,string 
                AppendText(Worker, messageWorker);
                AppendText(ModelName, messageModelName);
                AppendText(Paste, messagePaste);
                AppendText(Speed, messageSpeed);

                obj.ClearBuffer();
                obj.WorkingSocket.BeginReceive(obj.Buffer, 0, 4096, 0, DataReceived, obj);
            }
            catch (ObjectDisposedException ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            LotNo.Clear(); Worker.Clear(); ModelName.Clear(); Paste.Clear(); Speed.Clear();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
