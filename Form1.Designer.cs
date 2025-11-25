namespace YemenWhatsApp
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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.chatTabPage = new System.Windows.Forms.TabPage();
            this.settingsTabPage = new System.Windows.Forms.TabPage();
            this.topPanel = new System.Windows.Forms.Panel();
            this.appTitleLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.connectionPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.onlineCountLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.usersListBox = new System.Windows.Forms.ListBox();
            this.chatPanel = new System.Windows.Forms.Panel();
            this.messagesPanel = new System.Windows.Forms.Panel();
            this.sendPanel = new System.Windows.Forms.Panel();
            this.chatHeaderPanel = new System.Windows.Forms.Panel();
            this.chatStatusLabel = new System.Windows.Forms.Label();
            this.chatTitleLabel = new System.Windows.Forms.Label();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.messagesFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.attachButton = new System.Windows.Forms.Button();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.publicRadioButton = new System.Windows.Forms.RadioButton();
            this.privateRadioButton = new System.Windows.Forms.RadioButton();
            this.targetUsersComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.serverUrlTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mainTabControl.SuspendLayout();
            this.chatTabPage.SuspendLayout();
            this.settingsTabPage.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.connectionPanel.SuspendLayout();
            this.chatPanel.SuspendLayout();
            this.messagesPanel.SuspendLayout();
            this.sendPanel.SuspendLayout();
            this.chatHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.inputPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.chatTabPage);
            this.mainTabControl.Controls.Add(this.settingsTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1182, 753);
            this.mainTabControl.TabIndex = 0;
            // 
            // chatTabPage
            // 
            this.chatTabPage.Controls.Add(this.mainPanel);
            this.chatTabPage.Controls.Add(this.topPanel);
            this.chatTabPage.Location = new System.Drawing.Point(4, 25);
            this.chatTabPage.Name = "chatTabPage";
            this.chatTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.chatTabPage.Size = new System.Drawing.Size(1174, 724);
            this.chatTabPage.TabIndex = 0;
            this.chatTabPage.Text = " الدردشة";
            this.chatTabPage.UseVisualStyleBackColor = true;
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.Controls.Add(this.groupBox2);
            this.settingsTabPage.Controls.Add(this.groupBox1);
            this.settingsTabPage.Location = new System.Drawing.Point(4, 25);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTabPage.Size = new System.Drawing.Size(1174, 724);
            this.settingsTabPage.TabIndex = 1;
            this.settingsTabPage.Text = "⚙️ الإعدادات";
            this.settingsTabPage.UseVisualStyleBackColor = true;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.topPanel.Controls.Add(this.statusLabel);
            this.topPanel.Controls.Add(this.appTitleLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topPanel.Location = new System.Drawing.Point(3, 3);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1168, 70);
            this.topPanel.TabIndex = 1;
            // 
            // appTitleLabel
            // 
            this.appTitleLabel.AutoSize = true;
            this.appTitleLabel.ForeColor = System.Drawing.Color.White;
            this.appTitleLabel.Location = new System.Drawing.Point(20, 20);
            this.appTitleLabel.Name = "appTitleLabel";
            this.appTitleLabel.Size = new System.Drawing.Size(283, 38);
            this.appTitleLabel.TabIndex = 0;
            this.appTitleLabel.Text = "🇾🇪 Yemen WhatsApp";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Location = new System.Drawing.Point(309, 20);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(181, 38);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "🔴 غير متصل";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.mainPanel.Controls.Add(this.chatPanel);
            this.mainPanel.Controls.Add(this.sidePanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(3, 73);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1168, 648);
            this.mainPanel.TabIndex = 2;
            // 
            // sidePanel
            // 
            this.sidePanel.Controls.Add(this.usersListBox);
            this.sidePanel.Controls.Add(this.label2);
            this.sidePanel.Controls.Add(this.connectionPanel);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(300, 648);
            this.sidePanel.TabIndex = 0;
            // 
            // connectionPanel
            // 
            this.connectionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.connectionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.connectionPanel.Controls.Add(this.connectButton);
            this.connectionPanel.Controls.Add(this.usernameTextBox);
            this.connectionPanel.Controls.Add(this.label3);
            this.connectionPanel.Controls.Add(this.onlineCountLabel);
            this.connectionPanel.Controls.Add(this.label1);
            this.connectionPanel.Location = new System.Drawing.Point(10, 9);
            this.connectionPanel.Name = "connectionPanel";
            this.connectionPanel.Size = new System.Drawing.Size(280, 150);
            this.connectionPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "👥 حالة الاتصال";
            // 
            // onlineCountLabel
            // 
            this.onlineCountLabel.AutoSize = true;
            this.onlineCountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlineCountLabel.ForeColor = System.Drawing.Color.Gray;
            this.onlineCountLabel.Location = new System.Drawing.Point(200, 19);
            this.onlineCountLabel.Name = "onlineCountLabel";
            this.onlineCountLabel.Size = new System.Drawing.Size(65, 20);
            this.onlineCountLabel.TabIndex = 1;
            this.onlineCountLabel.Text = "0 متصل ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "اسم المستخدم";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.Green;
            this.usernameTextBox.ForeColor = System.Drawing.Color.White;
            this.usernameTextBox.Location = new System.Drawing.Point(135, 52);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(130, 24);
            this.usernameTextBox.TabIndex = 3;
            this.usernameTextBox.Text = "new+ مستخدم";
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.connectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.connectButton.Location = new System.Drawing.Point(10, 102);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(255, 33);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "📡 الاتصال";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "المستخدمون النشطون:";
            // 
            // usersListBox
            // 
            this.usersListBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersListBox.FormattingEnabled = true;
            this.usersListBox.ItemHeight = 25;
            this.usersListBox.Location = new System.Drawing.Point(10, 200);
            this.usersListBox.Name = "usersListBox";
            this.usersListBox.Size = new System.Drawing.Size(280, 379);
            this.usersListBox.TabIndex = 2;
            // 
            // chatPanel
            // 
            this.chatPanel.BackColor = System.Drawing.Color.White;
            this.chatPanel.Controls.Add(this.sendPanel);
            this.chatPanel.Controls.Add(this.messagesPanel);
            this.chatPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatPanel.Location = new System.Drawing.Point(300, 0);
            this.chatPanel.Name = "chatPanel";
            this.chatPanel.Size = new System.Drawing.Size(868, 648);
            this.chatPanel.TabIndex = 1;
            // 
            // messagesPanel
            // 
            this.messagesPanel.AutoScroll = true;
            this.messagesPanel.Controls.Add(this.chatHeaderPanel);
            this.messagesPanel.Controls.Add(this.messagesFlowPanel);
            this.messagesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messagesPanel.Location = new System.Drawing.Point(0, 0);
            this.messagesPanel.Name = "messagesPanel";
            this.messagesPanel.Size = new System.Drawing.Size(868, 648);
            this.messagesPanel.TabIndex = 1;
            // 
            // sendPanel
            // 
            this.sendPanel.Controls.Add(this.inputPanel);
            this.sendPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sendPanel.Location = new System.Drawing.Point(0, 568);
            this.sendPanel.Name = "sendPanel";
            this.sendPanel.Size = new System.Drawing.Size(868, 80);
            this.sendPanel.TabIndex = 2;
            // 
            // chatHeaderPanel
            // 
            this.chatHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.chatHeaderPanel.Controls.Add(this.chatStatusLabel);
            this.chatHeaderPanel.Controls.Add(this.chatTitleLabel);
            this.chatHeaderPanel.Controls.Add(this.profilePictureBox);
            this.chatHeaderPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.chatHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.chatHeaderPanel.Name = "chatHeaderPanel";
            this.chatHeaderPanel.Size = new System.Drawing.Size(868, 70);
            this.chatHeaderPanel.TabIndex = 1;
            this.chatHeaderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.chatHeaderPanel_Paint);
            // 
            // chatStatusLabel
            // 
            this.chatStatusLabel.AutoSize = true;
            this.chatStatusLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatStatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.chatStatusLabel.Location = new System.Drawing.Point(336, 20);
            this.chatStatusLabel.Name = "chatStatusLabel";
            this.chatStatusLabel.Size = new System.Drawing.Size(144, 25);
            this.chatStatusLabel.TabIndex = 2;
            this.chatStatusLabel.Text = "   ⚡ اتصال فوري";
            // 
            // chatTitleLabel
            // 
            this.chatTitleLabel.AutoSize = true;
            this.chatTitleLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatTitleLabel.ForeColor = System.Drawing.Color.White;
            this.chatTitleLabel.Location = new System.Drawing.Point(70, 15);
            this.chatTitleLabel.Name = "chatTitleLabel";
            this.chatTitleLabel.Size = new System.Drawing.Size(213, 31);
            this.chatTitleLabel.TabIndex = 1;
            this.chatTitleLabel.Text = "Yemen Chat Group";
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.BackColor = System.Drawing.Color.White;
            this.profilePictureBox.Location = new System.Drawing.Point(15, 12);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(45, 45);
            this.profilePictureBox.TabIndex = 0;
            this.profilePictureBox.TabStop = false;
            // 
            // messagesFlowPanel
            // 
            this.messagesFlowPanel.AutoScroll = true;
            this.messagesFlowPanel.BackColor = System.Drawing.Color.White;
            this.messagesFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messagesFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.messagesFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.messagesFlowPanel.Name = "messagesFlowPanel";
            this.messagesFlowPanel.Size = new System.Drawing.Size(868, 648);
            this.messagesFlowPanel.TabIndex = 2;
            this.messagesFlowPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.messagesFlowPanel_Paint);
            // 
            // inputPanel
            // 
            this.inputPanel.Controls.Add(this.targetUsersComboBox);
            this.inputPanel.Controls.Add(this.privateRadioButton);
            this.inputPanel.Controls.Add(this.publicRadioButton);
            this.inputPanel.Controls.Add(this.sendButton);
            this.inputPanel.Controls.Add(this.messageTextBox);
            this.inputPanel.Controls.Add(this.attachButton);
            this.inputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputPanel.Location = new System.Drawing.Point(0, 0);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(868, 80);
            this.inputPanel.TabIndex = 0;
            // 
            // attachButton
            // 
            this.attachButton.BackColor = System.Drawing.Color.Transparent;
            this.attachButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attachButton.Font = new System.Drawing.Font("Segoe UI", 13.2F);
            this.attachButton.Location = new System.Drawing.Point(10, 10);
            this.attachButton.Name = "attachButton";
            this.attachButton.Size = new System.Drawing.Size(40, 40);
            this.attachButton.TabIndex = 0;
            this.attachButton.Text = "📎";
            this.attachButton.UseVisualStyleBackColor = false;
            // 
            // messageTextBox
            // 
            this.messageTextBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.messageTextBox.Location = new System.Drawing.Point(60, 10);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(600, 40);
            this.messageTextBox.TabIndex = 1;
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendButton.ForeColor = System.Drawing.Color.White;
            this.sendButton.Location = new System.Drawing.Point(670, 10);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(50, 43);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "🔼";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // publicRadioButton
            // 
            this.publicRadioButton.AutoSize = true;
            this.publicRadioButton.Checked = true;
            this.publicRadioButton.Location = new System.Drawing.Point(729, 15);
            this.publicRadioButton.Name = "publicRadioButton";
            this.publicRadioButton.Size = new System.Drawing.Size(77, 21);
            this.publicRadioButton.TabIndex = 3;
            this.publicRadioButton.TabStop = true;
            this.publicRadioButton.Text = "  📢 عام";
            this.publicRadioButton.UseVisualStyleBackColor = true;
            // 
            // privateRadioButton
            // 
            this.privateRadioButton.AutoSize = true;
            this.privateRadioButton.Location = new System.Drawing.Point(730, 42);
            this.privateRadioButton.Name = "privateRadioButton";
            this.privateRadioButton.Size = new System.Drawing.Size(76, 21);
            this.privateRadioButton.TabIndex = 4;
            this.privateRadioButton.Text = "🔒 خاص";
            this.privateRadioButton.UseVisualStyleBackColor = true;
            this.privateRadioButton.CheckedChanged += new System.EventHandler(this.privateRadioButton_CheckedChanged);
            // 
            // targetUsersComboBox
            // 
            this.targetUsersComboBox.FormattingEnabled = true;
            this.targetUsersComboBox.Location = new System.Drawing.Point(812, 12);
            this.targetUsersComboBox.Name = "targetUsersComboBox";
            this.targetUsersComboBox.Size = new System.Drawing.Size(51, 24);
            this.targetUsersComboBox.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.serverUrlTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(50, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "إعدادات الخادم";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "عنوان الخادم:";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(20, 37);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(141, 119);
            this.infoLabel.TabIndex = 1;
            this.infoLabel.Text = "Yemen WhatsApp \r\nتطبيق الدردشة اليمني\r\n\\مميزات:دردشة فورية\r\nرسائل خاصة\r\n• واجهة و" +
    "اتساب\r\n• قاعدة بيانات\r\nn• متعدد المستخدمين\r\n";
            // 
            // serverUrlTextBox
            // 
            this.serverUrlTextBox.Location = new System.Drawing.Point(120, 35);
            this.serverUrlTextBox.Name = "serverUrlTextBox";
            this.serverUrlTextBox.Size = new System.Drawing.Size(350, 24);
            this.serverUrlTextBox.TabIndex = 1;
            this.serverUrlTextBox.Text = "http://localhost:5000/chatHub";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.infoLabel);
            this.groupBox2.Location = new System.Drawing.Point(50, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 300);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "معلومات التطبيق";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.mainTabControl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " 🇾🇪 Yemen WhatsApp";
            this.mainTabControl.ResumeLayout(false);
            this.chatTabPage.ResumeLayout(false);
            this.settingsTabPage.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            this.connectionPanel.ResumeLayout(false);
            this.connectionPanel.PerformLayout();
            this.chatPanel.ResumeLayout(false);
            this.messagesPanel.ResumeLayout(false);
            this.sendPanel.ResumeLayout(false);
            this.chatHeaderPanel.ResumeLayout(false);
            this.chatHeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage chatTabPage;
        private System.Windows.Forms.TabPage settingsTabPage;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label appTitleLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel connectionPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label onlineCountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Panel chatPanel;
        private System.Windows.Forms.ListBox usersListBox;
        private System.Windows.Forms.Panel messagesPanel;
        private System.Windows.Forms.Panel sendPanel;
        private System.Windows.Forms.Panel chatHeaderPanel;
        private System.Windows.Forms.Label chatStatusLabel;
        private System.Windows.Forms.Label chatTitleLabel;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.FlowLayoutPanel messagesFlowPanel;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Button attachButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.RadioButton privateRadioButton;
        private System.Windows.Forms.RadioButton publicRadioButton;
        private System.Windows.Forms.ComboBox targetUsersComboBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox serverUrlTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

