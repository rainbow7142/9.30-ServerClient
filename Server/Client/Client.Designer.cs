namespace Client
{
    partial class Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ww = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHistory = new System.Windows.Forms.RichTextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.Speed = new System.Windows.Forms.TextBox();
            this.Paste = new System.Windows.Forms.TextBox();
            this.ModelName = new System.Windows.Forms.TextBox();
            this.Worker = new System.Windows.Forms.TextBox();
            this.LotNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ClientName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.closeTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 12);
            this.label5.TabIndex = 93;
            this.label5.Text = "Log";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(245, 61);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(57, 21);
            this.txtPort.TabIndex = 87;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(209, 34);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(93, 21);
            this.txtIP.TabIndex = 86;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(18, 204);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 91;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ww
            // 
            this.ww.AutoSize = true;
            this.ww.Location = new System.Drawing.Point(182, 37);
            this.ww.Name = "ww";
            this.ww.Size = new System.Drawing.Size(16, 12);
            this.ww.TabIndex = 90;
            this.ww.Text = "IP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 12);
            this.label6.TabIndex = 89;
            this.label6.Text = "Port";
            // 
            // txtHistory
            // 
            this.txtHistory.Location = new System.Drawing.Point(182, 106);
            this.txtHistory.Name = "txtHistory";
            this.txtHistory.Size = new System.Drawing.Size(120, 121);
            this.txtHistory.TabIndex = 88;
            this.txtHistory.Text = "";
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Gulim", 9F);
            this.btnConnect.Location = new System.Drawing.Point(18, 171);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 85;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Speed
            // 
            this.Speed.Location = new System.Drawing.Point(113, 144);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(58, 21);
            this.Speed.TabIndex = 84;
            // 
            // Paste
            // 
            this.Paste.Location = new System.Drawing.Point(98, 115);
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(73, 21);
            this.Paste.TabIndex = 83;
            // 
            // ModelName
            // 
            this.ModelName.Location = new System.Drawing.Point(98, 88);
            this.ModelName.Name = "ModelName";
            this.ModelName.Size = new System.Drawing.Size(73, 21);
            this.ModelName.TabIndex = 82;
            // 
            // Worker
            // 
            this.Worker.Location = new System.Drawing.Point(98, 61);
            this.Worker.Name = "Worker";
            this.Worker.Size = new System.Drawing.Size(73, 21);
            this.Worker.TabIndex = 81;
            // 
            // LotNo
            // 
            this.LotNo.Location = new System.Drawing.Point(98, 34);
            this.LotNo.Name = "LotNo";
            this.LotNo.Size = new System.Drawing.Size(73, 21);
            this.LotNo.TabIndex = 80;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gulim", 9F);
            this.label9.Location = new System.Drawing.Point(18, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 79;
            this.label9.Text = "Speed(m/min)";
            // 
            // ClientName
            // 
            this.ClientName.AutoSize = true;
            this.ClientName.Font = new System.Drawing.Font("Gulim", 10F);
            this.ClientName.Location = new System.Drawing.Point(18, 9);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(307, 14);
            this.ClientName.TabIndex = 78;
            this.ClientName.Text = "서버에서 보낼 때 4,5,6,7,8 이런 식으로 보낼것";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gulim", 9F);
            this.label4.Location = new System.Drawing.Point(18, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 12);
            this.label4.TabIndex = 77;
            this.label4.Text = "Paste";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gulim", 9F);
            this.label3.Location = new System.Drawing.Point(18, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 12);
            this.label3.TabIndex = 76;
            this.label3.Text = "ModelName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gulim", 9F);
            this.label2.Location = new System.Drawing.Point(18, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 12);
            this.label2.TabIndex = 75;
            this.label2.Text = "Worker";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 9F);
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 12);
            this.label1.TabIndex = 74;
            this.label1.Text = "LotNo.";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(96, 171);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 94;
            this.btnStart.Text = "LOGSAVE";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(96, 204);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 96;
            this.btnImport.Text = "LOGLOAD";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.button1_Click);
            // 
            // closeTimer
            // 
            this.closeTimer.Interval = 2000;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 29);
            this.button1.TabIndex = 97;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 248);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ww);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHistory);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.Paste);
            this.Controls.Add(this.ModelName);
            this.Controls.Add(this.Worker);
            this.Controls.Add(this.LotNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Client";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label ww;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtHistory;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox Speed;
        private System.Windows.Forms.TextBox Paste;
        private System.Windows.Forms.TextBox ModelName;
        private System.Windows.Forms.TextBox Worker;
        private System.Windows.Forms.TextBox LotNo;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label ClientName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnImport;
        public System.Windows.Forms.Timer closeTimer;
        private System.Windows.Forms.Button button1;
    }
}

