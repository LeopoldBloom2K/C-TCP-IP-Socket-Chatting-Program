using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace MyClient2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            IPHostEntry host = Dns.GetHostByName(Dns.GetHostName());
            string myip = host.AddressList[0].ToString();
            serverIP.Text = myip;
            serverPort.Text = "5000";
        }

        StreamReader streamReader;
        StreamWriter streamWriter;
        Thread thread1;
        TcpClient tcpClient1;
        IPEndPoint ipEnd;

        private void connectServer_Click(object sender, EventArgs e)
        {
            if (connectServer.Text == "서버 연결하기")
            {
                thread1 = new Thread(new ThreadStart(connect));
                thread1.IsBackground = true;
                thread1.Start();
                connectServer.Text = "연결 해제하기";
            }
            else
            {
                streamWriter.WriteLine("## 클라이언트 종료됨");
                commLog.AppendText("## 연결 해제됨\r\n");
                connectServer.Text = "서버 연결하기";
            }
        }
        private void connect()
        {
            tcpClient1 = new TcpClient();
            ipEnd = new IPEndPoint(IPAddress.Parse(serverIP.Text), int.Parse(serverPort.Text));

            tcpClient1.Connect(ipEnd);
            if (tcpClient1.Connected)
            {
                commLog.AppendText("## 서버에 연결됨...\r\n");
                connectServer.Text = "연결 해제";
                streamReader = new StreamReader(tcpClient1.GetStream());
                streamWriter = new StreamWriter(tcpClient1.GetStream());
                streamWriter.AutoFlush = true;

                while (tcpClient1.Connected)
                {
                    string receiveData1 = streamReader.ReadLine();
                    commLog.AppendText(" " + DateTime.Now.ToString("tt h:mm:ss") + "\t수신 : " + receiveData1 + "\r\n");
                }
                connectServer.Text = "연결됨";
            }
            tcpClient1.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }
        private void textMessage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textMessage.Text != "")
                {
                    commLog.AppendText(" " + DateTime.Now.ToString("tt h:mm:ss") + "\t발신 : " + textMessage.Text + "\r\n");
                    streamWriter.WriteLine(textMessage.Text);
                    textMessage.Text = "";
                }
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (textMessage.Text != "")
            {
                commLog.AppendText(" " + DateTime.Now.ToString("tt h:mm:ss") + "\t발신 : " + textMessage.Text + "\r\n");
                streamWriter.WriteLine(textMessage.Text);
                textMessage.Text = "";
            }

        }
    }
}
