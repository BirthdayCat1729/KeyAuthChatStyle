namespace KeyAuthChatStyle
{
    public partial class Main : global::System.Windows.Forms.Form
    {
        protected override void Dispose(bool disposing)
        {
            bool flag = disposing && this.components != null;
            if (flag)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox2 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.key = new Siticone.UI.WinForms.SiticoneLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Sender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sendmsg = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.lastLogin = new Siticone.UI.WinForms.SiticoneLabel();
            this.onlineUsersBox = new Siticone.UI.WinForms.SiticoneComboBox();
            this.siticoneLabel2 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneShadowForm = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numOnlineUsers = new Siticone.UI.WinForms.SiticoneLabel();
            this.createDate = new Siticone.UI.WinForms.SiticoneLabel();
            this.subscription = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticonePanel1 = new Siticone.UI.WinForms.SiticonePanel();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.chatmsg = new DrakeUI.Framework.DrakeUITextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.siticonePanel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.siticoneControlBox1.BorderRadius = 10;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.siticoneControlBox1.HoveredState.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(544, 2);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox1.TabIndex = 1;
            this.siticoneControlBox1.Click += new System.EventHandler(this.siticoneControlBox1_Click);
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.siticoneControlBox2.BorderRadius = 10;
            this.siticoneControlBox2.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(499, 2);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(2, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 27;
            this.label2.Text = "Loader Main";
            // 
            // key
            // 
            this.key.BackColor = System.Drawing.Color.Transparent;
            this.key.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.key.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.key.Location = new System.Drawing.Point(2, 154);
            this.key.Margin = new System.Windows.Forms.Padding(2);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(119, 23);
            this.key.TabIndex = 37;
            this.key.Text = "usernameLabel";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sender,
            this.Message,
            this.Time});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(31, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 4;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Red;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(452, 192);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Sender
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.Sender.DefaultCellStyle = dataGridViewCellStyle2;
            this.Sender.HeaderText = "Sent From";
            this.Sender.Name = "Sender";
            this.Sender.ReadOnly = true;
            this.Sender.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Sender.Width = 150;
            // 
            // Message
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.Message.DefaultCellStyle = dataGridViewCellStyle3;
            this.Message.HeaderText = "Message";
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            this.Message.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Message.Width = 150;
            // 
            // Time
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.Time.DefaultCellStyle = dataGridViewCellStyle4;
            this.Time.HeaderText = "Time";
            this.Time.MaxInputLength = 50000;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Time.Width = 150;
            // 
            // sendmsg
            // 
            this.sendmsg.BorderColor = System.Drawing.Color.Red;
            this.sendmsg.BorderThickness = 1;
            this.sendmsg.CheckedState.Parent = this.sendmsg;
            this.sendmsg.CustomImages.Parent = this.sendmsg;
            this.sendmsg.FillColor = System.Drawing.Color.Red;
            this.sendmsg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendmsg.ForeColor = System.Drawing.Color.White;
            this.sendmsg.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.sendmsg.HoveredState.Parent = this.sendmsg;
            this.sendmsg.Location = new System.Drawing.Point(360, 250);
            this.sendmsg.Name = "sendmsg";
            this.sendmsg.ShadowDecoration.Parent = this.sendmsg;
            this.sendmsg.Size = new System.Drawing.Size(151, 27);
            this.sendmsg.TabIndex = 42;
            this.sendmsg.Text = "Send Message";
            this.sendmsg.Click += new System.EventHandler(this.sendmsg_Click);
            // 
            // lastLogin
            // 
            this.lastLogin.BackColor = System.Drawing.Color.Transparent;
            this.lastLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lastLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lastLogin.Location = new System.Drawing.Point(2, 181);
            this.lastLogin.Margin = new System.Windows.Forms.Padding(2);
            this.lastLogin.Name = "lastLogin";
            this.lastLogin.Size = new System.Drawing.Size(114, 23);
            this.lastLogin.TabIndex = 47;
            this.lastLogin.Text = "lastLoginLabel";
            // 
            // onlineUsersBox
            // 
            this.onlineUsersBox.BackColor = System.Drawing.Color.Transparent;
            this.onlineUsersBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.onlineUsersBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.onlineUsersBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlineUsersBox.ForeColor = System.Drawing.Color.Black;
            this.onlineUsersBox.FormattingEnabled = true;
            this.onlineUsersBox.HoveredState.Parent = this.onlineUsersBox;
            this.onlineUsersBox.ItemHeight = 30;
            this.onlineUsersBox.Items.AddRange(new object[] {
            ""});
            this.onlineUsersBox.ItemsAppearance.Parent = this.onlineUsersBox;
            this.onlineUsersBox.Location = new System.Drawing.Point(234, 74);
            this.onlineUsersBox.Name = "onlineUsersBox";
            this.onlineUsersBox.ShadowDecoration.Parent = this.onlineUsersBox;
            this.onlineUsersBox.Size = new System.Drawing.Size(269, 36);
            this.onlineUsersBox.TabIndex = 54;
            // 
            // siticoneLabel2
            // 
            this.siticoneLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.siticoneLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticoneLabel2.Location = new System.Drawing.Point(234, 54);
            this.siticoneLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneLabel2.Name = "siticoneLabel2";
            this.siticoneLabel2.Size = new System.Drawing.Size(103, 23);
            this.siticoneLabel2.TabIndex = 55;
            this.siticoneLabel2.Text = "Online Users:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // numOnlineUsers
            // 
            this.numOnlineUsers.BackColor = System.Drawing.Color.Transparent;
            this.numOnlineUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.numOnlineUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numOnlineUsers.Location = new System.Drawing.Point(16, 54);
            this.numOnlineUsers.Margin = new System.Windows.Forms.Padding(2);
            this.numOnlineUsers.Name = "numOnlineUsers";
            this.numOnlineUsers.Size = new System.Drawing.Size(171, 23);
            this.numOnlineUsers.TabIndex = 49;
            this.numOnlineUsers.Text = "numOnlineUsersLabel";
            // 
            // createDate
            // 
            this.createDate.BackColor = System.Drawing.Color.Transparent;
            this.createDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.createDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createDate.Location = new System.Drawing.Point(2, 223);
            this.createDate.Margin = new System.Windows.Forms.Padding(2);
            this.createDate.Name = "createDate";
            this.createDate.Size = new System.Drawing.Size(127, 23);
            this.createDate.TabIndex = 46;
            this.createDate.Text = "createDateLabel";
            // 
            // subscription
            // 
            this.subscription.BackColor = System.Drawing.Color.Transparent;
            this.subscription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.subscription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subscription.Location = new System.Drawing.Point(2, 256);
            this.subscription.Margin = new System.Windows.Forms.Padding(2);
            this.subscription.Name = "subscription";
            this.subscription.Size = new System.Drawing.Size(41, 23);
            this.subscription.TabIndex = 39;
            this.subscription.Text = "Role:";
            this.subscription.Click += new System.EventHandler(this.subscription_Click);
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.guna2Separator3);
            this.siticonePanel1.Controls.Add(this.guna2Separator2);
            this.siticonePanel1.Controls.Add(this.guna2Separator1);
            this.siticonePanel1.Controls.Add(this.createDate);
            this.siticonePanel1.Controls.Add(this.subscription);
            this.siticonePanel1.Controls.Add(this.key);
            this.siticonePanel1.Controls.Add(this.siticoneLabel2);
            this.siticonePanel1.Controls.Add(this.onlineUsersBox);
            this.siticonePanel1.Controls.Add(this.lastLogin);
            this.siticonePanel1.Controls.Add(this.label2);
            this.siticonePanel1.Controls.Add(this.numOnlineUsers);
            this.siticonePanel1.Location = new System.Drawing.Point(12, 64);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(522, 298);
            this.siticonePanel1.TabIndex = 56;
            this.siticonePanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.siticonePanel1_Paint);
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.Location = new System.Drawing.Point(0, 139);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(519, 10);
            this.guna2Separator3.TabIndex = 58;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Location = new System.Drawing.Point(2, 208);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(519, 10);
            this.guna2Separator2.TabIndex = 57;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(0, 284);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(519, 10);
            this.guna2Separator1.TabIndex = 56;
            // 
            // chatmsg
            // 
            this.chatmsg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.chatmsg.DecLength = 3;
            this.chatmsg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.chatmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatmsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.chatmsg.Location = new System.Drawing.Point(16, 253);
            this.chatmsg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chatmsg.Maximum = 2147483647D;
            this.chatmsg.Minimum = -2147483648D;
            this.chatmsg.Name = "chatmsg";
            this.chatmsg.Padding = new System.Windows.Forms.Padding(5);
            this.chatmsg.RectColor = System.Drawing.Color.Red;
            this.chatmsg.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.chatmsg.Size = new System.Drawing.Size(337, 24);
            this.chatmsg.Style = DrakeUI.Framework.UIStyle.Custom;
            this.chatmsg.TabIndex = 57;
            this.chatmsg.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.chatmsg.Watermark = "Type in here";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.dataGridView1);
            this.guna2Panel1.Controls.Add(this.chatmsg);
            this.guna2Panel1.Controls.Add(this.sendmsg);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 64);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(522, 298);
            this.guna2Panel1.TabIndex = 58;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Location = new System.Drawing.Point(31, 7);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(452, 29);
            this.guna2Panel2.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(350, 4);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 63;
            this.label5.Text = "Sent Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(173, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 62;
            this.label4.Text = "Message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(2, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 61;
            this.label3.Text = "Sent From";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2Button4);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Location = new System.Drawing.Point(43, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 49);
            this.panel1.TabIndex = 59;
            // 
            // guna2Button4
            // 
            this.guna2Button4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.ImageOffset = new System.Drawing.Point(-4, 0);
            this.guna2Button4.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2Button4.Location = new System.Drawing.Point(227, 3);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.PressedColor = System.Drawing.Color.Blue;
            this.guna2Button4.Size = new System.Drawing.Size(223, 45);
            this.guna2Button4.TabIndex = 60;
            this.guna2Button4.Text = "Settings / Account Info";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.guna2Button1.Checked = true;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.ImageOffset = new System.Drawing.Point(-4, 0);
            this.guna2Button1.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2Button1.Location = new System.Drawing.Point(3, 3);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.Blue;
            this.guna2Button1.Size = new System.Drawing.Size(223, 45);
            this.guna2Button1.TabIndex = 48;
            this.guna2Button1.Text = "Chat";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 15);
            this.label6.TabIndex = 66;
            this.label6.Text = "Styled By: BirthdayCat1729";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(587, 374);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siticoneControlBox2);
            this.Controls.Add(this.siticoneControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loader";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Token: 0x04000001 RID: 1
        private global::System.ComponentModel.IContainer components = null;

        // Token: 0x04000002 RID: 2
        private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

        // Token: 0x04000004 RID: 4
        private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

        // Token: 0x04000005 RID: 5
        private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

        // Token: 0x0400000A RID: 10
        private global::System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;
        private Siticone.UI.WinForms.SiticoneLabel key;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Siticone.UI.WinForms.SiticoneRoundedButton sendmsg;
        private System.Windows.Forms.Timer timer1;
        private Siticone.UI.WinForms.SiticoneLabel lastLogin;
        private Siticone.UI.WinForms.SiticoneComboBox onlineUsersBox;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel2;
        private Siticone.UI.WinForms.SiticoneLabel numOnlineUsers;
        private Siticone.UI.WinForms.SiticoneLabel createDate;
        private Siticone.UI.WinForms.SiticoneLabel subscription;
        private Siticone.UI.WinForms.SiticonePanel siticonePanel1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private DrakeUI.Framework.DrakeUITextBox chatmsg;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
    }
}
