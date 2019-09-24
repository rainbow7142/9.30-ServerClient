using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;

namespace Client
{
    public partial class Client : Form
    {
        delegate void AppendTextDelegate(Control ctrl, string s);
        AppendTextDelegate textAppender;
        Socket mainSock;
        machinestate machinestate;

        public Client()
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
        private void Client_Load(object sender, EventArgs e)
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
            string[] grd = text.Split('+');
            string receivedLotNo = grd[0];
            string receivedWorker = grd[1];
            string receivedModelName = grd[2];
            string receivedPaste = grd[3];
            string receivedSpeed = grd[4];

            AppendText(LotNo, receivedLotNo); //ctrl,string 
            AppendText(Worker, receivedWorker);
            AppendText(ModelName, receivedModelName);
            AppendText(Paste, receivedPaste);
            AppendText(Speed, receivedSpeed);

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
            AppendText(txtHistory, "Connected to server");
            AsyncObject obj = new AsyncObject(4096);
            obj.WorkingSocket = mainSock;
            mainSock.BeginReceive(obj.Buffer, 0, obj.BufferSize, 0, DataReceived, obj);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            LotNo.Clear();
            Worker.Clear();
            ModelName.Clear();
            Paste.Clear();
            Speed.Clear();
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            //string message = string.Format("disconnected to server");
            //byte[] toByte = Encoding.UTF8.GetBytes(message);
            //AsyncObject obj = new AsyncObject(4096);
            //mainSock.Send(toByte);
            //mainSock.Close(5000);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string message = string.Format("LotNo:{0}\rWorker:{1}\rModelName:{2}\rPaste:{3}\rSpeed:{4}\rDate: {5}\r", LotNo.Text, Worker.Text, ModelName.Text, Paste.Text, Speed.Text, Convert.ToString(DateTime.Now));

            string saveDataPath = @"C:\Users\Unieye\Desktop\0909 Server\Clientlog\Clientlog.txt";
            if (!File.Exists(saveDataPath))
            {
                using (FileStream fs = File.Create(saveDataPath))
                {
                    byte[] gnd = new UTF8Encoding(true).GetBytes(message);
                    fs.Write(gnd, 0, gnd.Length);
                    AppendText(txtHistory, message);
                }
            }

                using (StreamWriter sw = File.AppendText(saveDataPath))
                {
                    
                    sw.WriteLine(message);
                    sw.Flush();
                }
                
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime endOfMonth = new DateTime(DateTime.Now.Year, 9, 30);
            DateTime now = DateTime.Now;
            rtbTest.AppendText("Today :" + now +"\r");
            TimeSpan gap = endOfMonth - now;
            rtbTest.AppendText("남은 일자:" + gap.TotalDays);
        }
    }
}
