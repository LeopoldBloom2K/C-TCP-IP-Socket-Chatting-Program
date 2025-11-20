namespace MyClient2023
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.commLog = new System.Windows.Forms.RichTextBox();
            this.connectServer = new System.Windows.Forms.Button();
            this.serverPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.xxxx = new System.Windows.Forms.Label();
            this.serverIP = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(484, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // textMessage
            // 
            this.textMessage.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textMessage.Location = new System.Drawing.Point(12, 395);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(343, 29);
            this.textMessage.TabIndex = 20;
            this.textMessage.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textMessage_KeyUp);
            // 
            // commLog
            // 
            this.commLog.Location = new System.Drawing.Point(12, 134);
            this.commLog.Name = "commLog";
            this.commLog.Size = new System.Drawing.Size(450, 245);
            this.commLog.TabIndex = 17;
            this.commLog.Text = "";
            // 
            // connectServer
            // 
            this.connectServer.Location = new System.Drawing.Point(42, 12);
            this.connectServer.Name = "connectServer";
            this.connectServer.Size = new System.Drawing.Size(100, 20);
            this.connectServer.TabIndex = 16;
            this.connectServer.Text = "서버 연결하기";
            this.connectServer.UseVisualStyleBackColor = true;
            this.connectServer.Click += new System.EventHandler(this.connectServer_Click);
            // 
            // serverPort
            // 
            this.serverPort.Location = new System.Drawing.Point(81, 94);
            this.serverPort.Name = "serverPort";
            this.serverPort.Size = new System.Drawing.Size(100, 21);
            this.serverPort.TabIndex = 14;
            this.serverPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "Port :";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // xxxx
            // 
            this.xxxx.AutoSize = true;
            this.xxxx.Location = new System.Drawing.Point(30, 49);
            this.xxxx.Name = "xxxx";
            this.xxxx.Size = new System.Drawing.Size(40, 12);
            this.xxxx.TabIndex = 11;
            this.xxxx.Text = "내 IP :";
            // 
            // serverIP
            // 
            this.serverIP.Location = new System.Drawing.Point(81, 46);
            this.serverIP.Name = "serverIP";
            this.serverIP.Size = new System.Drawing.Size(100, 21);
            this.serverIP.TabIndex = 12;
            this.serverIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(322, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // sendBtn
            // 
            this.sendBtn.Image = ((System.Drawing.Image)(resources.GetObject("sendBtn.Image")));
            this.sendBtn.Location = new System.Drawing.Point(391, 395);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(71, 29);
            this.sendBtn.TabIndex = 29;
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(228, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 83);
            this.label1.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.commLog);
            this.Controls.Add(this.connectServer);
            this.Controls.Add(this.serverPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serverIP);
            this.Controls.Add(this.xxxx);
            this.Name = "Form1";
            this.Text = "2020E7427_이준행_MyClient";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.RichTextBox commLog;
        private System.Windows.Forms.Button connectServer;
        private System.Windows.Forms.TextBox serverPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label xxxx;
        private System.Windows.Forms.TextBox serverIP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Label label1;
    }
}

