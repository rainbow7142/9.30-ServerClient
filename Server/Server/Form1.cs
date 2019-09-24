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
using System.IO;
namespace Server
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            mainSock =
                new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            textAppender = new AppendTextDelegate(AppendText);
        }
        delegate void AppendTextDelegate(Control ctrl, string s);
        AppendTextDelegate textAppender;
        Socket mainSock;
        IPAddress thisAddress;


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
        List<Socket> connectedClients = new List<Socket>();

        void AcceptCallback(IAsyncResult ar)
        {
            try
            {
                Socket client = mainSock.EndAccept(ar);
                mainSock.BeginAccept(AcceptCallback, null);
                AsyncObject obj = new AsyncObject(4096);
                obj.WorkingSocket = client;
                connectedClients.Add(client);
                AppendText(txtHistory, string.Format("Connected: {0}", client.RemoteEndPoint));
                client.BeginReceive(obj.Buffer, 0, 4096, 0, DataReceived, obj);
            }
            catch (ObjectDisposedException ex)
            {
                MessageBox.Show(ex.Message, "클라이언트 접속 끊김", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

                for (int i = connectedClients.Count - 1; i >= 0; i--)
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
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message, "정훈이 또 삐졌다.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //AppendText(txtHistory, )
        }
        private void button1_Click_1(object sender, EventArgs e)
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

        private void SendButton_Click_1(object sender, EventArgs e)
        {
            string message = string.Format("{0}+{1}+{2}+{3}+{4}", lotno.Text, worker.Text, modelname.Text, paste.Text, Speed.Text);
            message.Split('+');
            message.Trim();
            if (!mainSock.IsBound)
            {
                MessageBox.Show("서버가 실행되고 있지 않습니다!", "Not Found Server!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            byte[] bDts = Encoding.UTF8.GetBytes(message);
            for (int i = connectedClients.Count - 1; i >= 0; i--)
            {
                Socket socket = connectedClients[i];
                try { socket.Send(bDts); }
                catch
                {
                    connectedClients.RemoveAt(i);
                }
            }
            string data = string.Format("Lotno:{0}\rWorker:{1}\rModelName:{2}\rPaste:{3}\rSpeed:{4}\rDate:{5}\r", lotno.Text, worker.Text, modelname.Text, paste.Text, Speed.Text, Convert.ToString(DateTime.Now));
            string DataPath = @"C:\Users\Unieye\Desktop\0909 Server\Serverlog\Serverlog.txt";
            if (!File.Exists(DataPath))
            {
                using (FileStream fs = File.Create(DataPath, 2048))
                {
                    byte[] inData = new UTF8Encoding(true).GetBytes(data);
                    fs.Write(inData, 0, inData.Length);

                }
            }
            using (StreamWriter sw = File.AppendText(DataPath))
            {
                sw.Write(data);
                AppendText(txtHistory, data);
            }
        }

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
        private void EDMS_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            form2.ClientName.Text = "EDMS";
            AppendText(txtHistory, "EDMS>>");

        }
        private void ColorSensor_Click(object sender, EventArgs e)
        {          
            Form2 form2 = new Form2();
            form2.Show();
            form2.ClientName.Text = "COLORSENSOR"; 
            AppendText(txtHistory, "COLORSENSOR>>");
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            lotno.Clear();
            modelname.Clear();
            worker.Clear();
            paste.Clear();
            Speed.Clear();
            txtHistory.ClearUndo();
        }

        private void Pinhole_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            form2.ClientName.Text = "PINHOLE";
            AppendText(txtHistory, "PINHOLE>>");
        }

        private void StopImage_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            form2.ClientName.Text = "STOPIMAGE";
            AppendText(txtHistory, "STOPIMAGE>>");           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Having to my Happiness";
            byte [] closeMessage = Encoding.UTF8.GetBytes(message);
            for (int i = connectedClients.Count - 1; i >= 0; i--)
            {
                Socket socket = connectedClients[i];
                try { socket.Send(closeMessage); }
                catch
                {
                    connectedClients.RemoveAt(i);
                }
            }
            AppendText(txtHistory, message);
            mainSock.Close(2000);
        }
    }
}
