﻿namespace Server
{
    partial class Form1
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
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.txtPort = new System.Windows.Forms.RichTextBox();
            this.txtHistory = new System.Windows.Forms.RichTextBox();
            this.lotno = new System.Windows.Forms.RichTextBox();
            this.worker = new System.Windows.Forms.RichTextBox();
            this.modelname = new System.Windows.Forms.RichTextBox();
            this.paste = new System.Windows.Forms.RichTextBox();
            this.Speed = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numport = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.EDMS = new System.Windows.Forms.Button();
            this.ColorSensor = new System.Windows.Forms.Button();
            this.Pinhole = new System.Windows.Forms.Button();
            this.StopImage = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(199, 20);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(116, 23);
            this.txtAddress.TabIndex = 0;
            this.txtAddress.Text = "";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(199, 60);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(61, 24);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "";
            // 
            // txtHistory
            // 
            this.txtHistory.Location = new System.Drawing.Point(288, 64);
            this.txtHistory.Name = "txtHistory";
            this.txtHistory.Size = new System.Drawing.Size(128, 137);
            this.txtHistory.TabIndex = 2;
            this.txtHistory.Text = "";
            // 
            // lotno
            // 
            this.lotno.Location = new System.Drawing.Point(108, 1);
            this.lotno.Name = "lotno";
            this.lotno.Size = new System.Drawing.Size(85, 24);
            this.lotno.TabIndex = 3;
            this.lotno.Text = "";
            // 
            // worker
            // 
            this.worker.Location = new System.Drawing.Point(108, 32);
            this.worker.Name = "worker";
            this.worker.Size = new System.Drawing.Size(85, 24);
            this.worker.TabIndex = 4;
            this.worker.Text = "";
            // 
            // modelname
            // 
            this.modelname.Location = new System.Drawing.Point(108, 63);
            this.modelname.Name = "modelname";
            this.modelname.Size = new System.Drawing.Size(85, 24);
            this.modelname.TabIndex = 5;
            this.modelname.Text = "";
            // 
            // paste
            // 
            this.paste.Location = new System.Drawing.Point(108, 94);
            this.paste.Name = "paste";
            this.paste.Size = new System.Drawing.Size(85, 24);
            this.paste.TabIndex = 6;
            this.paste.Text = "";
            // 
            // Speed
            // 
            this.Speed.Location = new System.Drawing.Point(108, 125);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(84, 24);
            this.Speed.TabIndex = 7;
            this.Speed.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "Worker";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "ModelName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "Paste";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "Speed(m/min)";
            // 
            // numport
            // 
            this.numport.AutoSize = true;
            this.numport.Location = new System.Drawing.Point(199, 46);
            this.numport.Name = "numport";
            this.numport.Size = new System.Drawing.Size(27, 12);
            this.numport.TabIndex = 13;
            this.numport.Text = "Port";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "OPEN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(199, 160);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 52);
            this.SendButton.TabIndex = 19;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 12);
            this.label6.TabIndex = 24;
            this.label6.Text = "IP Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(286, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 12);
            this.label9.TabIndex = 25;
            this.label9.Text = "Log";
            // 
            // EDMS
            // 
            this.EDMS.Location = new System.Drawing.Point(37, 160);
            this.EDMS.Name = "EDMS";
            this.EDMS.Size = new System.Drawing.Size(75, 23);
            this.EDMS.TabIndex = 26;
            this.EDMS.Text = "EDMS";
            this.EDMS.UseVisualStyleBackColor = true;
            this.EDMS.Click += new System.EventHandler(this.EDMS_Click);
            // 
            // ColorSensor
            // 
            this.ColorSensor.Location = new System.Drawing.Point(118, 160);
            this.ColorSensor.Name = "ColorSensor";
            this.ColorSensor.Size = new System.Drawing.Size(75, 23);
            this.ColorSensor.TabIndex = 27;
            this.ColorSensor.Text = "ColorSensor";
            this.ColorSensor.UseVisualStyleBackColor = true;
            this.ColorSensor.Click += new System.EventHandler(this.ColorSensor_Click);
            // 
            // Pinhole
            // 
            this.Pinhole.Location = new System.Drawing.Point(37, 189);
            this.Pinhole.Name = "Pinhole";
            this.Pinhole.Size = new System.Drawing.Size(75, 23);
            this.Pinhole.TabIndex = 28;
            this.Pinhole.Text = "PinHole";
            this.Pinhole.UseVisualStyleBackColor = true;
            this.Pinhole.Click += new System.EventHandler(this.Pinhole_Click);
            // 
            // StopImage
            // 
            this.StopImage.Location = new System.Drawing.Point(118, 189);
            this.StopImage.Name = "StopImage";
            this.StopImage.Size = new System.Drawing.Size(75, 23);
            this.StopImage.TabIndex = 29;
            this.StopImage.Text = "StopImage";
            this.StopImage.UseVisualStyleBackColor = true;
            this.StopImage.Click += new System.EventHandler(this.StopImage_Click);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(199, 92);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(75, 23);
            this.btnLog.TabIndex = 32;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(199, 128);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "LogDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 224);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.StopImage);
            this.Controls.Add(this.Pinhole);
            this.Controls.Add(this.ColorSensor);
            this.Controls.Add(this.EDMS);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.paste);
            this.Controls.Add(this.modelname);
            this.Controls.Add(this.worker);
            this.Controls.Add(this.lotno);
            this.Controls.Add(this.txtHistory);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtAddress);
            this.Name = "Form1";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.RichTextBox txtHistory;
        private System.Windows.Forms.RichTextBox lotno;
        private System.Windows.Forms.RichTextBox worker;
        private System.Windows.Forms.RichTextBox modelname;
        private System.Windows.Forms.RichTextBox paste;
        private System.Windows.Forms.RichTextBox Speed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label numport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button EDMS;
        public System.Windows.Forms.Button ColorSensor;
        public System.Windows.Forms.Button Pinhole;
        public System.Windows.Forms.Button StopImage;
        public System.Windows.Forms.RichTextBox txtPort;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Timer timer1;
    }
}