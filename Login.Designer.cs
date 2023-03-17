namespace KeyAuthChatStyle
{
    // Token: 0x02000002 RID: 2
    public partial class Login : global::System.Windows.Forms.Form
    {
        // Token: 0x06000011 RID: 17 RVA: 0x0000215C File Offset: 0x0000035C
        protected override void Dispose(bool disposing)
        {
            bool flag = disposing && this.components != null;
            if (flag)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x06000012 RID: 18 RVA: 0x00002194 File Offset: 0x00000394
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox2 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginBtn = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.status = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneShadowForm = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
            this.password = new DrakeUI.Framework.DrakeUITextBox();
            this.username = new DrakeUI.Framework.DrakeUITextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.label4 = new System.Windows.Forms.Label();
            this.drakeUITextBox1 = new DrakeUI.Framework.DrakeUITextBox();
            this.drakeUITextBox2 = new DrakeUI.Framework.DrakeUITextBox();
            this.siticoneRoundedButton1 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BorderRadius = 10;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.siticoneControlBox1.HoveredState.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(607, 4);
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
            this.siticoneControlBox2.Location = new System.Drawing.Point(561, 4);
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
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(243, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "KeyAuthChatStyle";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BorderColor = System.Drawing.Color.Red;
            this.LoginBtn.BorderThickness = 1;
            this.LoginBtn.CheckedState.Parent = this.LoginBtn;
            this.LoginBtn.CustomImages.Parent = this.LoginBtn;
            this.LoginBtn.FillColor = System.Drawing.Color.Red;
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.LoginBtn.HoveredState.Parent = this.LoginBtn;
            this.LoginBtn.Location = new System.Drawing.Point(408, 182);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.ShadowDecoration.Parent = this.LoginBtn;
            this.LoginBtn.Size = new System.Drawing.Size(151, 27);
            this.LoginBtn.TabIndex = 26;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // status
            // 
            this.status.AutoSize = false;
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.status.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.status.Location = new System.Drawing.Point(0, 261);
            this.status.Margin = new System.Windows.Forms.Padding(2);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(656, 42);
            this.status.TabIndex = 38;
            this.status.Text = "Login Status:";
            this.status.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.status.Click += new System.EventHandler(this.status_Click);
            // 
            // password
            // 
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.DecLength = 3;
            this.password.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.password.Location = new System.Drawing.Point(370, 139);
            this.password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.password.Maximum = 2147483647D;
            this.password.Minimum = -2147483648D;
            this.password.Name = "password";
            this.password.Padding = new System.Windows.Forms.Padding(5);
            this.password.RectColor = System.Drawing.Color.Red;
            this.password.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.password.Size = new System.Drawing.Size(236, 24);
            this.password.Style = DrakeUI.Framework.UIStyle.Custom;
            this.password.TabIndex = 59;
            this.password.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.password.Watermark = "Password";
            // 
            // username
            // 
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.DecLength = 3;
            this.username.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.username.Location = new System.Drawing.Point(370, 105);
            this.username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.username.Maximum = 2147483647D;
            this.username.Minimum = -2147483648D;
            this.username.Name = "username";
            this.username.Padding = new System.Windows.Forms.Padding(5);
            this.username.RectColor = System.Drawing.Color.Red;
            this.username.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.username.Size = new System.Drawing.Size(236, 24);
            this.username.Style = DrakeUI.Framework.UIStyle.Custom;
            this.username.TabIndex = 60;
            this.username.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.username.Watermark = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(96, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 37);
            this.label3.TabIndex = 61;
            this.label3.Text = "Regsiter";
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(322, 57);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 178);
            this.guna2VSeparator1.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(441, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 37);
            this.label4.TabIndex = 63;
            this.label4.Text = "Login";
            // 
            // drakeUITextBox1
            // 
            this.drakeUITextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.drakeUITextBox1.DecLength = 3;
            this.drakeUITextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.drakeUITextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUITextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.drakeUITextBox1.Location = new System.Drawing.Point(40, 105);
            this.drakeUITextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drakeUITextBox1.Maximum = 2147483647D;
            this.drakeUITextBox1.Minimum = -2147483648D;
            this.drakeUITextBox1.Name = "drakeUITextBox1";
            this.drakeUITextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.drakeUITextBox1.RectColor = System.Drawing.Color.Red;
            this.drakeUITextBox1.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.drakeUITextBox1.Size = new System.Drawing.Size(236, 24);
            this.drakeUITextBox1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUITextBox1.TabIndex = 63;
            this.drakeUITextBox1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.drakeUITextBox1.Watermark = "Username";
            // 
            // drakeUITextBox2
            // 
            this.drakeUITextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.drakeUITextBox2.DecLength = 3;
            this.drakeUITextBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.drakeUITextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUITextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.drakeUITextBox2.Location = new System.Drawing.Point(40, 139);
            this.drakeUITextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drakeUITextBox2.Maximum = 2147483647D;
            this.drakeUITextBox2.Minimum = -2147483648D;
            this.drakeUITextBox2.Name = "drakeUITextBox2";
            this.drakeUITextBox2.Padding = new System.Windows.Forms.Padding(5);
            this.drakeUITextBox2.RectColor = System.Drawing.Color.Red;
            this.drakeUITextBox2.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.drakeUITextBox2.Size = new System.Drawing.Size(236, 24);
            this.drakeUITextBox2.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUITextBox2.TabIndex = 62;
            this.drakeUITextBox2.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.drakeUITextBox2.Watermark = "Password";
            // 
            // siticoneRoundedButton1
            // 
            this.siticoneRoundedButton1.BorderColor = System.Drawing.Color.Red;
            this.siticoneRoundedButton1.BorderThickness = 1;
            this.siticoneRoundedButton1.CheckedState.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.CustomImages.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.FillColor = System.Drawing.Color.Red;
            this.siticoneRoundedButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton1.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton1.HoveredState.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.Location = new System.Drawing.Point(79, 182);
            this.siticoneRoundedButton1.Name = "siticoneRoundedButton1";
            this.siticoneRoundedButton1.ShadowDecoration.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.Size = new System.Drawing.Size(151, 27);
            this.siticoneRoundedButton1.TabIndex = 61;
            this.siticoneRoundedButton1.Text = "Regsiter";
            this.siticoneRoundedButton1.Click += new System.EventHandler(this.siticoneRoundedButton1_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(14, 245);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(630, 10);
            this.guna2Separator1.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 15);
            this.label5.TabIndex = 65;
            this.label5.Text = "Styled By: BirthdayCat1729";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(656, 303);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.drakeUITextBox1);
            this.Controls.Add(this.drakeUITextBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.siticoneRoundedButton1);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.username);
            this.Controls.Add(this.password);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siticoneControlBox2);
            this.Controls.Add(this.siticoneControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loader";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Login_Load);
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
        private Siticone.UI.WinForms.SiticoneRoundedButton LoginBtn;
        private Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;
        private Siticone.UI.WinForms.SiticoneLabel status;
        private DrakeUI.Framework.DrakeUITextBox username;
        private DrakeUI.Framework.DrakeUITextBox password;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private DrakeUI.Framework.DrakeUITextBox drakeUITextBox1;
        private DrakeUI.Framework.DrakeUITextBox drakeUITextBox2;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton1;
        private System.Windows.Forms.Label label5;
    }
}
