namespace Server
{
    partial class Form3
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
            this.ww = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.txtHistory = new System.Windows.Forms.RichTextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Speed = new System.Windows.Forms.TextBox();
            this.Paste = new System.Windows.Forms.TextBox();
            this.ModelName = new System.Windows.Forms.TextBox();
            this.Worker = new System.Windows.Forms.TextBox();
            this.LotNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ClientName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(21, 249);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(92, 23);
            this.ClearButton.TabIndex = 94;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click_1);
            // 
            // ww
            // 
            this.ww.AutoSize = true;
            this.ww.Location = new System.Drawing.Point(334, 45);
            this.ww.Name = "ww";
            this.ww.Size = new System.Drawing.Size(16, 12);
            this.ww.TabIndex = 93;
            this.ww.Text = "IP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 12);
            this.label6.TabIndex = 92;
            this.label6.Text = "Port";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(126, 179);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(44, 12);
            this.lbl6.TabIndex = 91;
            this.lbl6.Text = "History";
            // 
            // txtHistory
            // 
            this.txtHistory.Location = new System.Drawing.Point(128, 198);
            this.txtHistory.Name = "txtHistory";
            this.txtHistory.Size = new System.Drawing.Size(190, 96);
            this.txtHistory.TabIndex = 90;
            this.txtHistory.Text = "";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(356, 84);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 21);
            this.txtPort.TabIndex = 89;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(356, 41);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 21);
            this.txtIP.TabIndex = 88;
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Gulim", 9F);
            this.btnConnect.Location = new System.Drawing.Point(21, 198);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(92, 27);
            this.btnConnect.TabIndex = 87;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(254, 144);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(64, 21);
            this.textBox7.TabIndex = 86;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(254, 86);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(64, 21);
            this.textBox6.TabIndex = 85;
            // 
            // Speed
            // 
            this.Speed.Location = new System.Drawing.Point(254, 40);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(64, 21);
            this.Speed.TabIndex = 84;
            // 
            // Paste
            // 
            this.Paste.Location = new System.Drawing.Point(99, 148);
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(73, 21);
            this.Paste.TabIndex = 83;
            // 
            // ModelName
            // 
            this.ModelName.Location = new System.Drawing.Point(99, 118);
            this.ModelName.Name = "ModelName";
            this.ModelName.Size = new System.Drawing.Size(73, 21);
            this.ModelName.TabIndex = 82;
            // 
            // Worker
            // 
            this.Worker.Location = new System.Drawing.Point(99, 84);
            this.Worker.Name = "Worker";
            this.Worker.Size = new System.Drawing.Size(73, 21);
            this.Worker.TabIndex = 81;
            // 
            // LotNo
            // 
            this.LotNo.Location = new System.Drawing.Point(99, 44);
            this.LotNo.Name = "LotNo";
            this.LotNo.Size = new System.Drawing.Size(73, 21);
            this.LotNo.TabIndex = 80;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Gulim", 9F);
            this.label11.Location = new System.Drawing.Point(180, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 12);
            this.label11.TabIndex = 79;
            this.label11.Text = "RollDia";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gulim", 9F);
            this.label10.Location = new System.Drawing.Point(180, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 12);
            this.label10.TabIndex = 78;
            this.label10.Text = "ComSpeed";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gulim", 9F);
            this.label9.Location = new System.Drawing.Point(180, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 77;
            this.label9.Text = "Speed";
            // 
            // ClientName
            // 
            this.ClientName.AutoSize = true;
            this.ClientName.Font = new System.Drawing.Font("Gulim", 10F);
            this.ClientName.Location = new System.Drawing.Point(12, 9);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(89, 14);
            this.ClientName.TabIndex = 76;
            this.ClientName.Text = "ColorSensor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gulim", 9F);
            this.label4.Location = new System.Drawing.Point(19, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 12);
            this.label4.TabIndex = 75;
            this.label4.Text = "Paste";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gulim", 9F);
            this.label3.Location = new System.Drawing.Point(19, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 12);
            this.label3.TabIndex = 74;
            this.label3.Text = "ModelName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gulim", 9F);
            this.label2.Location = new System.Drawing.Point(19, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 12);
            this.label2.TabIndex = 73;
            this.label2.Text = "Worker";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 9F);
            this.label1.Location = new System.Drawing.Point(19, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 12);
            this.label1.TabIndex = 72;
            this.label1.Text = "LotNo.";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 313);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ww);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.txtHistory);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.Paste);
            this.Controls.Add(this.ModelName);
            this.Controls.Add(this.Worker);
            this.Controls.Add(this.LotNo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label ww;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.RichTextBox txtHistory;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox Speed;
        private System.Windows.Forms.TextBox Paste;
        private System.Windows.Forms.TextBox ModelName;
        private System.Windows.Forms.TextBox Worker;
        private System.Windows.Forms.TextBox LotNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label ClientName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}