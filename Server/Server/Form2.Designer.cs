namespace Server
{
    partial class Form2
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
            this.ClearButton = new System.Windows.Forms.Button();
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
            this.label6 = new System.Windows.Forms.Label();
            this.ww = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(12, 204);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(153, 23);
            this.ClearButton.TabIndex = 71;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // txtHistory
            // 
            this.txtHistory.Location = new System.Drawing.Point(172, 115);
            this.txtHistory.Name = "txtHistory";
            this.txtHistory.Size = new System.Drawing.Size(122, 95);
            this.txtHistory.TabIndex = 67;
            this.txtHistory.Text = "";
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Gulim", 9F);
            this.btnConnect.Location = new System.Drawing.Point(14, 171);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(87, 27);
            this.btnConnect.TabIndex = 64;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Speed
            // 
            this.Speed.Location = new System.Drawing.Point(107, 144);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(58, 21);
            this.Speed.TabIndex = 61;
            // 
            // Paste
            // 
            this.Paste.Location = new System.Drawing.Point(92, 115);
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(73, 21);
            this.Paste.TabIndex = 60;
            // 
            // ModelName
            // 
            this.ModelName.Location = new System.Drawing.Point(92, 88);
            this.ModelName.Name = "ModelName";
            this.ModelName.Size = new System.Drawing.Size(73, 21);
            this.ModelName.TabIndex = 59;
            // 
            // Worker
            // 
            this.Worker.Location = new System.Drawing.Point(92, 61);
            this.Worker.Name = "Worker";
            this.Worker.Size = new System.Drawing.Size(73, 21);
            this.Worker.TabIndex = 58;
            // 
            // LotNo
            // 
            this.LotNo.Location = new System.Drawing.Point(92, 34);
            this.LotNo.Name = "LotNo";
            this.LotNo.Size = new System.Drawing.Size(73, 21);
            this.LotNo.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gulim", 9F);
            this.label9.Location = new System.Drawing.Point(12, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 54;
            this.label9.Text = "Speed(m/min)";
            // 
            // ClientName
            // 
            this.ClientName.AutoSize = true;
            this.ClientName.Font = new System.Drawing.Font("Gulim", 10F);
            this.ClientName.Location = new System.Drawing.Point(6, 9);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(99, 14);
            this.ClientName.TabIndex = 53;
            this.ClientName.Text = "<ClientName>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gulim", 9F);
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 12);
            this.label4.TabIndex = 52;
            this.label4.Text = "Paste";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gulim", 9F);
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 12);
            this.label3.TabIndex = 51;
            this.label3.Text = "ModelName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gulim", 9F);
            this.label2.Location = new System.Drawing.Point(10, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 12);
            this.label2.TabIndex = 50;
            this.label2.Text = "Worker";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 9F);
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 12);
            this.label1.TabIndex = 49;
            this.label1.Text = "LotNo.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 12);
            this.label6.TabIndex = 69;
            this.label6.Text = "Port";
            // 
            // ww
            // 
            this.ww.AutoSize = true;
            this.ww.Location = new System.Drawing.Point(176, 37);
            this.ww.Name = "ww";
            this.ww.Size = new System.Drawing.Size(16, 12);
            this.ww.TabIndex = 70;
            this.ww.Text = "IP";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(198, 34);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(93, 21);
            this.txtIP.TabIndex = 65;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(234, 61);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(57, 21);
            this.txtPort.TabIndex = 66;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(108, 171);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(58, 27);
            this.btnClose.TabIndex = 72;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 12);
            this.label5.TabIndex = 73;
            this.label5.Text = "History";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 236);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
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
            this.Name = "Form2";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.RichTextBox txtHistory;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox Speed;
        private System.Windows.Forms.TextBox Paste;
        private System.Windows.Forms.TextBox ModelName;
        private System.Windows.Forms.TextBox Worker;
        private System.Windows.Forms.TextBox LotNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ww;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPort;
        public System.Windows.Forms.Label ClientName;
        public System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label5;
    }
}