using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace MyServer2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            IPHostEntry host = Dns.GetHostByName(Dns.GetHostName());
            string myip = host.AddressList[0].ToString();
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            MyPC.Text = Dns.GetHostName().ToString();
            MyIP.Text = myip;
            MyPort.Text = "5000";
        }

        StreamReader streamReader1;
        StreamWriter streamWriter1;
        Thread thread1;
        TcpListener tcpListener1;
        TcpClient tcpClient1;

        private void startServer_Click(object sender, EventArgs e)
        {
            if (startServer.Text == "서버 열기")
            {
                thread1 = new Thread(connect);
                thread1.IsBackground = true;
                thread1.Start();
                startServer.Text = "서버 닫기"; 
            }
            else
            {
                commLog.AppendText("## 서비스를 종료합니다\r\n");
                startServer.Text = "서버 열기";
                
            }
        }
        private void connect()  // thread1에 연결된 함수. 메인폼과는 별도로 동작한다.
        {
            tcpListener1 = new TcpListener(IPAddress.Parse(MyIP.Text), int.Parse(MyPort.Text));
            tcpListener1.Start();

            commLog.AppendText("## 서버 준비...\r\n## 유저 대기 중...\r\n");
            tcpClient1 = tcpListener1.AcceptTcpClient();
            commLog.AppendText("## 유저와 연결됨" + "\r\n");

            streamReader1 = new StreamReader(tcpClient1.GetStream());
            streamWriter1 = new StreamWriter(tcpClient1.GetStream());
            streamWriter1.AutoFlush = true;

            while (tcpClient1.Connected)
            {
                string receiveData1 = streamReader1.ReadLine();
                commLog.AppendText(" " + DateTime.Now.ToString("tt h:mm:ss") + "\t수신 : " + receiveData1 + "\r\n");
            }
            tcpClient1.Close();
            startServer.Text = "서버 열기";
        }

        private void textMessage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                commLog.AppendText(" " + DateTime.Now.ToString("tt h:mm:ss") + "\t발신 : " + textMessage.Text + "\r\n");
                streamWriter1.WriteLine(textMessage.Text);
                textMessage.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textMessage.Text != "")
            {
                commLog.AppendText(" " + DateTime.Now.ToString("tt h:mm:ss") + "\t발신 : " + textMessage.Text + "\r\n");
                streamWriter1.WriteLine(textMessage.Text);
                textMessage.Text = "";
            }
        }
        

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }
    }
}