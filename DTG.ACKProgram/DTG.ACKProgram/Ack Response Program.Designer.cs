namespace DTG.ACKProgram
{
    partial class AckResponse
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CommunicationBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AckEntry = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ResponseEntry = new System.Windows.Forms.TextBox();
            this.AddButon = new System.Windows.Forms.Button();
            this.PortTimer = new System.Windows.Forms.Timer(this.components);
            this.AckResponseListButton = new System.Windows.Forms.Button();
            this.RecieveData = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IPAddressBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PortNumberBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.UDPButton = new System.Windows.Forms.Button();
            this.UDPComStatus = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ComDropDown = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BaudRateBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SerialButton = new System.Windows.Forms.Button();
            this.SerialComStatus = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.CommunicationsBoxOut = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(889, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.configureToolStripMenuItem.Text = "Configure";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // CommunicationBox
            // 
            this.CommunicationBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CommunicationBox.ForeColor = System.Drawing.Color.LightGreen;
            this.CommunicationBox.Location = new System.Drawing.Point(15, 252);
            this.CommunicationBox.Multiline = true;
            this.CommunicationBox.Name = "CommunicationBox";
            this.CommunicationBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CommunicationBox.Size = new System.Drawing.Size(426, 204);
            this.CommunicationBox.TabIndex = 3;
            this.CommunicationBox.Text = "Communication Closed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Communications IN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(632, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Add Ack/Response";
            // 
            // AckEntry
            // 
            this.AckEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AckEntry.ForeColor = System.Drawing.Color.LightGreen;
            this.AckEntry.Location = new System.Drawing.Point(635, 71);
            this.AckEntry.Name = "AckEntry";
            this.AckEntry.Size = new System.Drawing.Size(242, 22);
            this.AckEntry.TabIndex = 6;
            this.AckEntry.Text = "KA02TA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(479, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Expected Ack Request";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(510, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Request To Send";
            // 
            // ResponseEntry
            // 
            this.ResponseEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ResponseEntry.ForeColor = System.Drawing.Color.LightGreen;
            this.ResponseEntry.Location = new System.Drawing.Point(635, 106);
            this.ResponseEntry.Name = "ResponseEntry";
            this.ResponseEntry.Size = new System.Drawing.Size(242, 22);
            this.ResponseEntry.TabIndex = 8;
            this.ResponseEntry.Text = "Enter Response Here";
            // 
            // AddButon
            // 
            this.AddButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddButon.ForeColor = System.Drawing.Color.Gold;
            this.AddButon.Location = new System.Drawing.Point(635, 134);
            this.AddButon.Name = "AddButon";
            this.AddButon.Size = new System.Drawing.Size(109, 62);
            this.AddButon.TabIndex = 10;
            this.AddButon.Text = "Add Ack/Response";
            this.AddButon.UseVisualStyleBackColor = false;
            this.AddButon.Click += new System.EventHandler(this.AddButon_Click);
            // 
            // PortTimer
            // 
            this.PortTimer.Enabled = true;
            this.PortTimer.Interval = 3000;
            this.PortTimer.Tick += new System.EventHandler(this.PortTimer_Tick);
            // 
            // AckResponseListButton
            // 
            this.AckResponseListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AckResponseListButton.ForeColor = System.Drawing.Color.Gold;
            this.AckResponseListButton.Location = new System.Drawing.Point(750, 134);
            this.AckResponseListButton.Name = "AckResponseListButton";
            this.AckResponseListButton.Size = new System.Drawing.Size(127, 60);
            this.AckResponseListButton.TabIndex = 11;
            this.AckResponseListButton.Text = "List Acks/Responses";
            this.AckResponseListButton.UseVisualStyleBackColor = false;
            this.AckResponseListButton.Click += new System.EventHandler(this.AckResponseListButton_Click);
            // 
            // RecieveData
            // 
            this.RecieveData.Enabled = true;
            this.RecieveData.Interval = 1000;
            this.RecieveData.Tick += new System.EventHandler(this.RecieveData_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Serial";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.panel1);
            this.flowLayoutPanel2.Controls.Add(this.panel2);
            this.flowLayoutPanel2.Controls.Add(this.UDPButton);
            this.flowLayoutPanel2.Controls.Add(this.UDPComStatus);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(220, 71);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(221, 140);
            this.flowLayoutPanel2.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.IPAddressBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 45);
            this.panel1.TabIndex = 18;
            // 
            // IPAddressBox
            // 
            this.IPAddressBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IPAddressBox.ForeColor = System.Drawing.Color.LimeGreen;
            this.IPAddressBox.Location = new System.Drawing.Point(91, 15);
            this.IPAddressBox.Name = "IPAddressBox";
            this.IPAddressBox.Size = new System.Drawing.Size(100, 22);
            this.IPAddressBox.TabIndex = 17;
            this.IPAddressBox.Text = "10.50.10.140";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Com Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "IP Address:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PortNumberBox);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(6, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 45);
            this.panel2.TabIndex = 17;
            // 
            // PortNumberBox
            // 
            this.PortNumberBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PortNumberBox.ForeColor = System.Drawing.Color.LimeGreen;
            this.PortNumberBox.Location = new System.Drawing.Point(103, 15);
            this.PortNumberBox.Name = "PortNumberBox";
            this.PortNumberBox.Size = new System.Drawing.Size(88, 22);
            this.PortNumberBox.TabIndex = 17;
            this.PortNumberBox.Text = "2025";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Com Port";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Port Number:";
            // 
            // UDPButton
            // 
            this.UDPButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UDPButton.ForeColor = System.Drawing.Color.LimeGreen;
            this.UDPButton.Location = new System.Drawing.Point(6, 108);
            this.UDPButton.Name = "UDPButton";
            this.UDPButton.Size = new System.Drawing.Size(97, 23);
            this.UDPButton.TabIndex = 15;
            this.UDPButton.Text = "Connect";
            this.UDPButton.UseVisualStyleBackColor = false;
            this.UDPButton.Click += new System.EventHandler(this.UDPButton_Click);
            // 
            // UDPComStatus
            // 
            this.UDPComStatus.BackColor = System.Drawing.Color.Red;
            this.UDPComStatus.Location = new System.Drawing.Point(109, 108);
            this.UDPComStatus.Name = "UDPComStatus";
            this.UDPComStatus.Size = new System.Drawing.Size(22, 23);
            this.UDPComStatus.TabIndex = 14;
            this.UDPComStatus.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(217, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "UDP";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel3.Controls.Add(this.panel3);
            this.flowLayoutPanel3.Controls.Add(this.panel4);
            this.flowLayoutPanel3.Controls.Add(this.SerialButton);
            this.flowLayoutPanel3.Controls.Add(this.SerialComStatus);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(12, 71);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(202, 140);
            this.flowLayoutPanel3.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ComDropDown);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(195, 45);
            this.panel3.TabIndex = 17;
            // 
            // ComDropDown
            // 
            this.ComDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ComDropDown.ForeColor = System.Drawing.Color.LightGreen;
            this.ComDropDown.FormattingEnabled = true;
            this.ComDropDown.Location = new System.Drawing.Point(85, 12);
            this.ComDropDown.Name = "ComDropDown";
            this.ComDropDown.Size = new System.Drawing.Size(100, 24);
            this.ComDropDown.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 17);
            this.label13.TabIndex = 3;
            this.label13.Text = "Com Port";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 17);
            this.label14.TabIndex = 16;
            this.label14.Text = "Com Port";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BaudRateBox);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Location = new System.Drawing.Point(6, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(195, 45);
            this.panel4.TabIndex = 16;
            // 
            // BaudRateBox
            // 
            this.BaudRateBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BaudRateBox.ForeColor = System.Drawing.Color.LightGreen;
            this.BaudRateBox.FormattingEnabled = true;
            this.BaudRateBox.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "9600",
            "14400",
            "19200",
            "18400",
            "57600",
            "115200"});
            this.BaudRateBox.Location = new System.Drawing.Point(85, 12);
            this.BaudRateBox.Name = "BaudRateBox";
            this.BaudRateBox.Size = new System.Drawing.Size(100, 24);
            this.BaudRateBox.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 138);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 17);
            this.label15.TabIndex = 3;
            this.label15.Text = "Com Port";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 17);
            this.label16.TabIndex = 16;
            this.label16.Text = "Baud Rate";
            // 
            // SerialButton
            // 
            this.SerialButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SerialButton.ForeColor = System.Drawing.Color.LimeGreen;
            this.SerialButton.Location = new System.Drawing.Point(6, 108);
            this.SerialButton.Name = "SerialButton";
            this.SerialButton.Size = new System.Drawing.Size(97, 23);
            this.SerialButton.TabIndex = 18;
            this.SerialButton.Text = "Connect";
            this.SerialButton.UseVisualStyleBackColor = false;
            this.SerialButton.Click += new System.EventHandler(this.SerialButton_Click);
            // 
            // SerialComStatus
            // 
            this.SerialComStatus.BackColor = System.Drawing.Color.Red;
            this.SerialComStatus.Location = new System.Drawing.Point(109, 108);
            this.SerialComStatus.Name = "SerialComStatus";
            this.SerialComStatus.Size = new System.Drawing.Size(22, 23);
            this.SerialComStatus.TabIndex = 19;
            this.SerialComStatus.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(448, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Communications OUT";
            // 
            // CommunicationsBoxOut
            // 
            this.CommunicationsBoxOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CommunicationsBoxOut.ForeColor = System.Drawing.Color.LightGreen;
            this.CommunicationsBoxOut.Location = new System.Drawing.Point(447, 252);
            this.CommunicationsBoxOut.Multiline = true;
            this.CommunicationsBoxOut.Name = "CommunicationsBoxOut";
            this.CommunicationsBoxOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CommunicationsBoxOut.Size = new System.Drawing.Size(426, 204);
            this.CommunicationsBoxOut.TabIndex = 20;
            this.CommunicationsBoxOut.Text = "Communication Closed";
            // 
            // AckResponse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(889, 468);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CommunicationsBoxOut);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AckResponseListButton);
            this.Controls.Add(this.AddButon);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ResponseEntry);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AckEntry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CommunicationBox);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Gold;
            this.Name = "AckResponse";
            this.Text = "Ack Response Program";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox CommunicationBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AckEntry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ResponseEntry;
        private System.Windows.Forms.Button AddButon;
        private System.Windows.Forms.Timer PortTimer;
        private System.Windows.Forms.Button AckResponseListButton;
        private System.Windows.Forms.Timer RecieveData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button UDPButton;
        private System.Windows.Forms.Button UDPComStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox IPAddressBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox PortNumberBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox ComDropDown;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox BaudRateBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button SerialButton;
        private System.Windows.Forms.Button SerialComStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CommunicationsBoxOut;
    }
}

