using System;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Drawing.Drawing2D;
using YemenWhatsApp.Data;
using YemenWhatsApp.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YemenWhatsApp
{
    public partial class Form1 : Form
    {
        private HubConnection _hubConnection;
        private string _currentUser = "";
        private bool _isConnected = false;


        public Form1()
        {
            InitializeComponent();

            InitializeDatabase();
            SetupEvents();
            SetupInitialState();

        }


        private void InitializeDatabase()
        {
            try
            {
                 var db = new ChatDbContext();

                // تأكد من إنشاء قاعدة البيانات
                db.Database.EnsureCreated();

                // إضافة بعض البيانات التجريبية للاختبار
                if (!db.Users.Any())
                {
                    db.Users.Add(new User
                    {
                        Username = "مستخدم تجريبي",
                        IsOnline = false,
                        Status = "غير متصل"
                    });
                    db.SaveChanges();
                }

                // اختبار إضافة رسالة تجريبية
                if (!db.Messages.Any())
                {
                    db.Messages.Add(new Models.Message
                    {
                        Sender = "النظام",
                        Receiver = "الجميع",
                        Content = "مرحباً بك في Yemen WhatsApp! 🎉",
                        IsPrivate = false
                    });

                    db.SaveChanges();
                }

                Console.WriteLine("✅ تم تهيئة قاعدة البيانات في الذاكرة بنجاح");
                AddSystemMessage("تم تحميل قاعدة البيانات بنجاح ✅");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"⚠ خطأ في قاعدة البيانات: {ex.Message}");
                AddSystemMessage("تم التحميل بدون حفظ في قاعدة البيانات ⚠");
            }
        }
        private void SetupEvents()
        {
            // الأحداث المربوطة من المصمم
            connectButton.Click += connectButton_Click;
            sendButton.Click += sendButton_Click;
            messageTextBox.KeyPress += MessageTextBox_KeyPress;
            privateRadioButton.CheckedChanged += privateRadioButton_CheckedChanged;
            profilePictureBox.Paint += ProfilePictureBox_Paint;
        }

        private void SetupInitialState()
        {
            sendButton.Enabled = false;
            serverUrlTextBox.Text = "http://localhost:5000/chatHub";
            usernameTextBox.Text = "مستخدم" + new Random().Next(1000);
            AddSystemMessage("مرحباً بك في Yemen WhatsApp! 👋");
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void ئ(object sender, EventArgs e)
        {

        }

        private void messagesFlowPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chatHeaderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            ShowDatabaseInfo();


            try
            {
                _currentUser = usernameTextBox.Text.Trim();
                if (string.IsNullOrEmpty(_currentUser))
                {
                    MessageBox.Show("الرجاء إدخال اسم المستخدم");
                    return;
                }

                if (!_isConnected)
                {
                    statusLabel.Text = "🟡 جاري الاتصال...";

                    _hubConnection = new HubConnectionBuilder()
                        .WithUrl(serverUrlTextBox.Text)
                        .WithAutomaticReconnect()
                        .Build();

                    SetupSignalREvents();
                     _hubConnection.StartAsync();
                      _hubConnection.InvokeAsync("JoinChat", _currentUser);

                    _isConnected = true;
                    connectButton.Text = "🔌 قطع الاتصال";
                    sendButton.Enabled = true;
                    usernameTextBox.Enabled = false;

                    statusLabel.Text = "🟢 متصل";
                    AddSystemMessage($"✅ تم الاتصال كـ {_currentUser}");
                }
                else
                {
                     _hubConnection.StopAsync();
                    _isConnected = false;
                    connectButton.Text = "📡 الاتصال";
                    sendButton.Enabled = false;
                    usernameTextBox.Enabled = true;
                    statusLabel.Text = "🔴 غير متصل";
                    AddSystemMessage("❌ تم قطع الاتصال");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"فشل الاتصال: {ex.Message}");
            }
        }

        private void SetupSignalREvents()
        {
            _hubConnection.On<string, string>("ReceiveMessage", (user, message) =>
            {
                AddWhatsAppMessage(user, message, DateTime.Now, user == _currentUser, false);
            });

            _hubConnection.On<string, string>("ReceivePrivateMessage", (user, message) =>
            {
                AddWhatsAppMessage(user, message, DateTime.Now, false, true);
            });

            _hubConnection.On<List<string>>("UpdateUsers", (users) =>
            {
                UpdateUsersList(users);
            });
        }

        private async void sendButton_Click(object sender, EventArgs e)
        {
            await SendMessage();
        }


        private async void MessageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                await SendMessage();
                e.Handled = true;
            }
        }

        private async Task SendMessage()
        {
            if (string.IsNullOrWhiteSpace(messageTextBox.Text) || !_isConnected)
                return;

            string message = messageTextBox.Text.Trim();
            bool isPrivate = privateRadioButton.Checked;

            // عرض الرسالة فوراً
            AddWhatsAppMessage(_currentUser, message, DateTime.Now, true, isPrivate);

            try
            {
                if (isPrivate && targetUsersComboBox.SelectedItem != null)
                {
                    string targetUser = targetUsersComboBox.SelectedItem.ToString();
                    await _hubConnection.InvokeAsync("SendPrivateMessage", targetUser, message);
                }
                else
                {
                    await _hubConnection.InvokeAsync("SendMessageToAll", message);
                }

                await SaveMessageToDatabase(_currentUser, message, isPrivate);
                messageTextBox.Clear();
            }
            catch (Exception ex)
            {
                AddSystemMessage($"❌ فشل إرسال الرسالة: {ex.Message}");
            }
        }

        private void privateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            targetUsersComboBox.Enabled = privateRadioButton.Checked;
        }

        private void ProfilePictureBox_Paint(object sender, PaintEventArgs e)
        {
            // رسم صورة مستديرة
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillEllipse(Brushes.White, 0, 0, 44, 44);
            e.Graphics.DrawString("👤", new Font("Segoe UI", 14), Brushes.Gray, 8, 8);



        }

        private void AddWhatsAppMessage(string sender, string message, DateTime timestamp, bool isMe, bool isPrivate)
        {
            if (messagesFlowPanel.InvokeRequired)
            {
                messagesFlowPanel.Invoke(new Action<string, string, DateTime, bool, bool>(AddWhatsAppMessage),
                    sender, message, timestamp, isMe, isPrivate);
                return;
            }

            // إنشاء رسالة واتساب
            Panel messageContainer = new Panel();
            messageContainer.Margin = new Padding(0, 5, 0, 5);
            messageContainer.Width = messagesFlowPanel.Width - 25;
            messageContainer.BackColor = Color.Transparent;

            // الفقاعة
            Panel bubble = new Panel();
            bubble.MaximumSize = new Size(400, 0);
            bubble.AutoSize = true;
            bubble.Padding = new Padding(15, 10, 15, 25);
            bubble.BackColor = isMe ? Color.FromArgb(220, 248, 198) : Color.White;

            // النص
            Label messageLabel = new Label();
            messageLabel.Text = message;
            messageLabel.Font = new Font("Segoe UI", 11);
            messageLabel.ForeColor = Color.Black;
            messageLabel.BackColor = Color.Transparent;
            messageLabel.AutoSize = true;
            messageLabel.MaximumSize = new Size(350, 0);

            // الوقت
            Label timeLabel = new Label();
            timeLabel.Text = timestamp.ToString("HH:mm");
            timeLabel.Font = new Font("Segoe UI", 9);
            timeLabel.ForeColor = Color.Gray;
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(15, messageLabel.Height + 5);

            bubble.Controls.Add(messageLabel);
            bubble.Controls.Add(timeLabel);
            bubble.Height = messageLabel.Height + 30;

            if (isMe)
            {
                bubble.Location = new Point(messageContainer.Width - bubble.Width - 10, 0);
            }
            else
            {
                bubble.Location = new Point(10, 0);
                if (isPrivate)
                {
                    Label senderLabel = new Label();
                    senderLabel.Text = $"{sender} ↙";
                    senderLabel.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    senderLabel.ForeColor = Color.FromArgb(0, 100, 200);
                    senderLabel.AutoSize = true;
                    senderLabel.Location = new Point(15, -15);
                    messageContainer.Controls.Add(senderLabel);
                    messageContainer.Height = bubble.Height + 15;
                }
            }

            messageContainer.Controls.Add(bubble);
            messagesFlowPanel.Controls.Add(messageContainer);
            ScrollToBottom();
        }

        private void AddSystemMessage(string message)
        {
            Label systemLabel = new Label();
            systemLabel.Text = $"• {message} •";
            systemLabel.Font = new Font("Segoe UI", 9);
            systemLabel.ForeColor = Color.Gray;
            systemLabel.BackColor = Color.FromArgb(240, 240, 240);
            systemLabel.AutoSize = true;
            systemLabel.Padding = new Padding(10, 5, 10, 5);
            systemLabel.TextAlign = ContentAlignment.MiddleCenter;

            messagesFlowPanel.Controls.Add(systemLabel);
            ScrollToBottom();
        }

        private void UpdateUsersList(List<string> users)
        {
            if (usersListBox.InvokeRequired)
            {
                usersListBox.Invoke(new Action<List<string>>(UpdateUsersList), users);
                return;
            }

            usersListBox.Items.Clear();
            targetUsersComboBox.Items.Clear();

            foreach (string user in users)
            {
                if (user != _currentUser)
                {
                    usersListBox.Items.Add($"🟢 {user}");
                    targetUsersComboBox.Items.Add(user);
                }
            }

            onlineCountLabel.Text = $"{users.Count} متصل";

            if (targetUsersComboBox.Items.Count > 0)
            {
                targetUsersComboBox.SelectedIndex = 0;
            }
        }

        private async Task SaveMessageToDatabase(string sender, string message, bool isPrivate)
        {
            try
            {
                 var db = new ChatDbContext();

                var msg = new Models.Message
                {
                    Sender = sender,
                    Receiver = isPrivate ? targetUsersComboBox.SelectedItem?.ToString() : "الجميع",
                    Content = message,
                    IsPrivate = isPrivate,
                    Timestamp = DateTime.Now
                };

                db.Messages.Add(msg);
                await db.SaveChangesAsync();

                Console.WriteLine($"✅ تم حفظ الرسالة في قاعدة البيانات: {message}");
            }
            catch (Exception ex)
            {
                // لا تعرض رسالة خطأ للمستخدم، فقط سجل في الكونسول
                Console.WriteLine($"⚠ لم يتم حفظ الرسالة في قاعدة البيانات: {ex.Message}");
            }
        }
        private void ShowDatabaseInfo()
        {
            try
            {
                 var db = new ChatDbContext();
                var userCount = db.Users.Count();
                var messageCount = db.Messages.Count();

                AddSystemMessage($"📊 إحصائيات قاعدة البيانات: {userCount} مستخدم، {messageCount} رسالة");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"خطأ في عرض الإحصائيات: {ex.Message}");
            }
        }
        private void ScrollToBottom()
        {
            messagesFlowPanel.ScrollControlIntoView(messagesFlowPanel.Controls[messagesFlowPanel.Controls.Count - 1]);
        }

        protected override async void OnFormClosing(FormClosingEventArgs e)
        {
            if (_hubConnection != null)
            {
                await _hubConnection.StopAsync();
            }
            base.OnFormClosing(e);
        }

    }
}
