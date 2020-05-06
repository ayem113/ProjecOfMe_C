namespace ProjectOfMe
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.chkRemember = new Guna.UI.WinForms.GunaCheckBox();
            this.LinkLabelFoget = new Guna.UI.WinForms.GunaLinkLabel();
            this.btnLogin = new Guna.UI.WinForms.GunaButton();
            this.gunaPictureBox3 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.picShowPassword = new Guna.UI.WinForms.GunaPictureBox();
            this.LinkLabelSigin = new Guna.UI.WinForms.GunaLinkLabel();
            this.lblErrorMesseger = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinkLabel1 = new Guna.UI.WinForms.GunaLinkLabel();
            this.txtUsername = new Guna.UI.WinForms.GunaTextBox();
            this.txtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.timerSignup = new System.Windows.Forms.Timer(this.components);
            this.timerSignup2 = new System.Windows.Forms.Timer(this.components);
            this.timerFoget = new System.Windows.Forms.Timer(this.components);
            this.timerFoget2 = new System.Windows.Forms.Timer(this.components);
            this.timerOpacity = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 30;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.gunaPictureBox1;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(12, 74);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(272, 324);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 102;
            this.gunaPictureBox1.TabStop = false;
            // 
            // chkRemember
            // 
            this.chkRemember.BackColor = System.Drawing.Color.Transparent;
            this.chkRemember.BaseColor = System.Drawing.Color.White;
            this.chkRemember.CheckedOffColor = System.Drawing.Color.Gray;
            this.chkRemember.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chkRemember.FillColor = System.Drawing.Color.White;
            this.chkRemember.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRemember.Location = new System.Drawing.Point(74, 378);
            this.chkRemember.Margin = new System.Windows.Forms.Padding(0);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Size = new System.Drawing.Size(77, 20);
            this.chkRemember.TabIndex = 103;
            this.chkRemember.Text = "Ghi nhớ tôi";
            this.chkRemember.CheckedChanged += new System.EventHandler(this.chkRemember_CheckedChanged);
            // 
            // LinkLabelFoget
            // 
            this.LinkLabelFoget.AutoSize = true;
            this.LinkLabelFoget.BackColor = System.Drawing.Color.Transparent;
            this.LinkLabelFoget.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LinkLabelFoget.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.LinkLabelFoget.LinkColor = System.Drawing.Color.Silver;
            this.LinkLabelFoget.Location = new System.Drawing.Point(53, 420);
            this.LinkLabelFoget.Name = "LinkLabelFoget";
            this.LinkLabelFoget.Size = new System.Drawing.Size(89, 15);
            this.LinkLabelFoget.TabIndex = 104;
            this.LinkLabelFoget.TabStop = true;
            this.LinkLabelFoget.Text = "Quên mật khẩu";
            this.LinkLabelFoget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelFoget_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.AnimationHoverSpeed = 0.07F;
            this.btnLogin.AnimationSpeed = 0.03F;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnLogin.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogin.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Image = null;
            this.btnLogin.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogin.Location = new System.Drawing.Point(154, 381);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLogin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogin.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogin.OnHoverImage = null;
            this.btnLogin.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogin.Radius = 10;
            this.btnLogin.Size = new System.Drawing.Size(80, 17);
            this.btnLogin.TabIndex = 105;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaPictureBox3
            // 
            this.gunaPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox3.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox3.Image")));
            this.gunaPictureBox3.Location = new System.Drawing.Point(98, 3);
            this.gunaPictureBox3.Name = "gunaPictureBox3";
            this.gunaPictureBox3.Size = new System.Drawing.Size(103, 65);
            this.gunaPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox3.TabIndex = 107;
            this.gunaPictureBox3.TabStop = false;
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.Location = new System.Drawing.Point(12, 48);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(272, 77);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 111;
            this.gunaPictureBox2.TabStop = false;
            // 
            // picShowPassword
            // 
            this.picShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.picShowPassword.BaseColor = System.Drawing.Color.White;
            this.picShowPassword.Image = ((System.Drawing.Image)(resources.GetObject("picShowPassword.Image")));
            this.picShowPassword.Location = new System.Drawing.Point(240, 325);
            this.picShowPassword.Name = "picShowPassword";
            this.picShowPassword.Size = new System.Drawing.Size(15, 30);
            this.picShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShowPassword.TabIndex = 112;
            this.picShowPassword.TabStop = false;
            this.picShowPassword.Tag = "2";
            this.picShowPassword.Click += new System.EventHandler(this.gunaPictureBox4_Click);
            // 
            // LinkLabelSigin
            // 
            this.LinkLabelSigin.AutoSize = true;
            this.LinkLabelSigin.BackColor = System.Drawing.Color.Transparent;
            this.LinkLabelSigin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LinkLabelSigin.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LinkLabelSigin.LinkColor = System.Drawing.Color.Silver;
            this.LinkLabelSigin.Location = new System.Drawing.Point(184, 420);
            this.LinkLabelSigin.Name = "LinkLabelSigin";
            this.LinkLabelSigin.Size = new System.Drawing.Size(50, 15);
            this.LinkLabelSigin.TabIndex = 113;
            this.LinkLabelSigin.TabStop = true;
            this.LinkLabelSigin.Text = "Đăng ký";
            this.LinkLabelSigin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelSigin_LinkClicked);
            // 
            // lblErrorMesseger
            // 
            this.lblErrorMesseger.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorMesseger.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblErrorMesseger.ForeColor = System.Drawing.Color.Firebrick;
            this.lblErrorMesseger.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorMesseger.Image")));
            this.lblErrorMesseger.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorMesseger.Location = new System.Drawing.Point(71, 358);
            this.lblErrorMesseger.Name = "lblErrorMesseger";
            this.lblErrorMesseger.Size = new System.Drawing.Size(163, 17);
            this.lblErrorMesseger.TabIndex = 117;
            this.lblErrorMesseger.Text = "ErrorMesseger";
            this.lblErrorMesseger.Visible = false;
            // 
            // gunaLinkLabel1
            // 
            this.gunaLinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLinkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.gunaLinkLabel1.LinkColor = System.Drawing.Color.DimGray;
            this.gunaLinkLabel1.Location = new System.Drawing.Point(248, 9);
            this.gunaLinkLabel1.Name = "gunaLinkLabel1";
            this.gunaLinkLabel1.Size = new System.Drawing.Size(36, 36);
            this.gunaLinkLabel1.TabIndex = 118;
            this.gunaLinkLabel1.TabStop = true;
            this.gunaLinkLabel1.Text = "X";
            this.gunaLinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gunaLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gunaLinkLabel1_LinkClicked);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BaseColor = System.Drawing.Color.White;
            this.txtUsername.BorderColor = System.Drawing.Color.White;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUsername.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtUsername.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(74, 289);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.Radius = 10;
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(160, 30);
            this.txtUsername.TabIndex = 119;
            this.txtUsername.Text = "Tên đăng nhập";
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BaseColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.White;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(74, 325);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Radius = 10;
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(160, 30);
            this.txtPassword.TabIndex = 120;
            this.txtPassword.Text = "Mật khẩu";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            // 
            // timerSignup
            // 
            this.timerSignup.Interval = 1;
            this.timerSignup.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerSignup2
            // 
            this.timerSignup2.Interval = 10;
            this.timerSignup2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timerFoget
            // 
            this.timerFoget.Interval = 10;
            this.timerFoget.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timerFoget2
            // 
            this.timerFoget2.Interval = 10;
            this.timerFoget2.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timerOpacity
            // 
            this.timerOpacity.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(296, 444);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.gunaLinkLabel1);
            this.Controls.Add(this.lblErrorMesseger);
            this.Controls.Add(this.LinkLabelSigin);
            this.Controls.Add(this.picShowPassword);
            this.Controls.Add(this.gunaPictureBox2);
            this.Controls.Add(this.gunaPictureBox3);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.LinkLabelFoget);
            this.Controls.Add(this.chkRemember);
            this.Controls.Add(this.gunaPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLinkLabel LinkLabelFoget;
        private Guna.UI.WinForms.GunaCheckBox chkRemember;
        private Guna.UI.WinForms.GunaButton btnLogin;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox3;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaPictureBox picShowPassword;
        private Guna.UI.WinForms.GunaLinkLabel LinkLabelSigin;
        private Guna.UI.WinForms.GunaLabel lblErrorMesseger;
        private Guna.UI.WinForms.GunaLinkLabel gunaLinkLabel1;
        private Guna.UI.WinForms.GunaTextBox txtPassword;
        private Guna.UI.WinForms.GunaTextBox txtUsername;
        private System.Windows.Forms.Timer timerSignup;
        private System.Windows.Forms.Timer timerSignup2;
        private System.Windows.Forms.Timer timerFoget;
        private System.Windows.Forms.Timer timerFoget2;
        private System.Windows.Forms.Timer timerOpacity;
    }
}

