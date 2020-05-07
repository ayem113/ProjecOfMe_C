namespace ProjectOfMe.View
{
    partial class fSignup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSignup));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPasswword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRepeatPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReset = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnOk = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gunaCheckBox1 = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaLinkLabel1 = new Guna.UI.WinForms.GunaLinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErrorMesseger = new Guna.UI.WinForms.GunaLabel();
            this.picCheckPass = new Guna.UI.WinForms.GunaPictureBox();
            this.picCheckPass2 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheckPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheckPass2)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaPictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 468);
            this.panel1.TabIndex = 0;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(300, 468);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(317, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên đăng nhập";
            // 
            // txtUsername
            // 
            this.txtUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUsername.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.HintForeColor = System.Drawing.Color.Empty;
            this.txtUsername.HintText = "";
            this.txtUsername.isPassword = false;
            this.txtUsername.LineFocusedColor = System.Drawing.Color.Lime;
            this.txtUsername.LineIdleColor = System.Drawing.Color.Red;
            this.txtUsername.LineMouseHoverColor = System.Drawing.Color.Lime;
            this.txtUsername.LineThickness = 3;
            this.txtUsername.Location = new System.Drawing.Point(320, 64);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(252, 33);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.Text = "Nhập tên đăng nhập";
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername.Enter += new System.EventHandler(this.bunifuMaterialTextbox1_Enter);
            // 
            // txtPasswword
            // 
            this.txtPasswword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPasswword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPasswword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPasswword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPasswword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPasswword.HintForeColor = System.Drawing.Color.Empty;
            this.txtPasswword.HintText = "";
            this.txtPasswword.isPassword = true;
            this.txtPasswword.LineFocusedColor = System.Drawing.Color.Lime;
            this.txtPasswword.LineIdleColor = System.Drawing.Color.Red;
            this.txtPasswword.LineMouseHoverColor = System.Drawing.Color.Lime;
            this.txtPasswword.LineThickness = 3;
            this.txtPasswword.Location = new System.Drawing.Point(321, 146);
            this.txtPasswword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasswword.MaxLength = 32767;
            this.txtPasswword.Name = "txtPasswword";
            this.txtPasswword.Size = new System.Drawing.Size(252, 33);
            this.txtPasswword.TabIndex = 5;
            this.txtPasswword.Text = "bunifuMaterialTextbox2";
            this.txtPasswword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPasswword.Enter += new System.EventHandler(this.txtPasswword_Enter);
            this.txtPasswword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPasswword_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(318, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu";
            // 
            // txtRepeatPass
            // 
            this.txtRepeatPass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtRepeatPass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtRepeatPass.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRepeatPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRepeatPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtRepeatPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRepeatPass.HintForeColor = System.Drawing.Color.Empty;
            this.txtRepeatPass.HintText = "";
            this.txtRepeatPass.isPassword = true;
            this.txtRepeatPass.LineFocusedColor = System.Drawing.Color.Lime;
            this.txtRepeatPass.LineIdleColor = System.Drawing.Color.Red;
            this.txtRepeatPass.LineMouseHoverColor = System.Drawing.Color.Lime;
            this.txtRepeatPass.LineThickness = 3;
            this.txtRepeatPass.Location = new System.Drawing.Point(321, 228);
            this.txtRepeatPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtRepeatPass.MaxLength = 32767;
            this.txtRepeatPass.Name = "txtRepeatPass";
            this.txtRepeatPass.Size = new System.Drawing.Size(252, 33);
            this.txtRepeatPass.TabIndex = 7;
            this.txtRepeatPass.Text = "bunifuMaterialTextbox3";
            this.txtRepeatPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRepeatPass.Enter += new System.EventHandler(this.txtRepeatPass_Enter);
            this.txtRepeatPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRepeatPass_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(317, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nhắc lại";
            // 
            // txtEmail
            // 
            this.txtEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEmail.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.HintForeColor = System.Drawing.Color.Empty;
            this.txtEmail.HintText = "";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.Lime;
            this.txtEmail.LineIdleColor = System.Drawing.Color.Red;
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.Lime;
            this.txtEmail.LineThickness = 3;
            this.txtEmail.Location = new System.Drawing.Point(321, 295);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(252, 33);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.Text = "Nhập địa chỉ Email";
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(318, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // btnReset
            // 
            this.btnReset.Active = false;
            this.btnReset.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.BorderRadius = 0;
            this.btnReset.ButtonText = "Làm lại";
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.DisabledColor = System.Drawing.Color.Gray;
            this.btnReset.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReset.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReset.Iconimage")));
            this.btnReset.Iconimage_right = null;
            this.btnReset.Iconimage_right_Selected = null;
            this.btnReset.Iconimage_Selected = null;
            this.btnReset.IconMarginLeft = 0;
            this.btnReset.IconMarginRight = 0;
            this.btnReset.IconRightVisible = true;
            this.btnReset.IconRightZoom = 0D;
            this.btnReset.IconVisible = true;
            this.btnReset.IconZoom = 50D;
            this.btnReset.IsTab = false;
            this.btnReset.Location = new System.Drawing.Point(320, 412);
            this.btnReset.Name = "btnReset";
            this.btnReset.Normalcolor = System.Drawing.Color.Red;
            this.btnReset.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnReset.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReset.selected = false;
            this.btnReset.Size = new System.Drawing.Size(98, 35);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Làm lại";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Textcolor = System.Drawing.Color.White;
            this.btnReset.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btnOk
            // 
            this.btnOk.Active = false;
            this.btnOk.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnOk.BackColor = System.Drawing.Color.Red;
            this.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOk.BorderRadius = 0;
            this.btnOk.ButtonText = "Xác Nhận";
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.DisabledColor = System.Drawing.Color.Gray;
            this.btnOk.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOk.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnOk.Iconimage")));
            this.btnOk.Iconimage_right = null;
            this.btnOk.Iconimage_right_Selected = null;
            this.btnOk.Iconimage_Selected = null;
            this.btnOk.IconMarginLeft = 0;
            this.btnOk.IconMarginRight = 0;
            this.btnOk.IconRightVisible = true;
            this.btnOk.IconRightZoom = 0D;
            this.btnOk.IconVisible = true;
            this.btnOk.IconZoom = 90D;
            this.btnOk.IsTab = false;
            this.btnOk.Location = new System.Drawing.Point(465, 412);
            this.btnOk.Name = "btnOk";
            this.btnOk.Normalcolor = System.Drawing.Color.Red;
            this.btnOk.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnOk.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOk.selected = false;
            this.btnOk.Size = new System.Drawing.Size(107, 35);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "Xác Nhận";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Textcolor = System.Drawing.Color.White;
            this.btnOk.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // gunaCheckBox1
            // 
            this.gunaCheckBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCheckBox1.CheckedOffColor = System.Drawing.Color.Gray;
            this.gunaCheckBox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaCheckBox1.FillColor = System.Drawing.Color.White;
            this.gunaCheckBox1.Location = new System.Drawing.Point(320, 386);
            this.gunaCheckBox1.Name = "gunaCheckBox1";
            this.gunaCheckBox1.Size = new System.Drawing.Size(237, 20);
            this.gunaCheckBox1.TabIndex = 12;
            this.gunaCheckBox1.Text = "Các thông tin bạn vừa nhập là chính xác?";
            // 
            // gunaLinkLabel1
            // 
            this.gunaLinkLabel1.AutoSize = true;
            this.gunaLinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLinkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.gunaLinkLabel1.LinkColor = System.Drawing.Color.Silver;
            this.gunaLinkLabel1.Location = new System.Drawing.Point(317, 9);
            this.gunaLinkLabel1.Name = "gunaLinkLabel1";
            this.gunaLinkLabel1.Size = new System.Drawing.Size(39, 15);
            this.gunaLinkLabel1.TabIndex = 123;
            this.gunaLinkLabel1.TabStop = true;
            this.gunaLinkLabel1.Text = "Trở về";
            this.gunaLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gunaLinkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 124;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblErrorMesseger
            // 
            this.lblErrorMesseger.BackColor = System.Drawing.Color.Magenta;
            this.lblErrorMesseger.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblErrorMesseger.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorMesseger.Image")));
            this.lblErrorMesseger.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorMesseger.Location = new System.Drawing.Point(318, 344);
            this.lblErrorMesseger.Name = "lblErrorMesseger";
            this.lblErrorMesseger.Size = new System.Drawing.Size(252, 22);
            this.lblErrorMesseger.TabIndex = 125;
            this.lblErrorMesseger.Text = "gunaLabel1";
            this.lblErrorMesseger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblErrorMesseger.Visible = false;
            // 
            // picCheckPass
            // 
            this.picCheckPass.BaseColor = System.Drawing.Color.White;
            this.picCheckPass.Image = ((System.Drawing.Image)(resources.GetObject("picCheckPass.Image")));
            this.picCheckPass.Location = new System.Drawing.Point(531, 146);
            this.picCheckPass.Name = "picCheckPass";
            this.picCheckPass.Size = new System.Drawing.Size(27, 25);
            this.picCheckPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCheckPass.TabIndex = 126;
            this.picCheckPass.TabStop = false;
            this.picCheckPass.Visible = false;
            this.picCheckPass.Click += new System.EventHandler(this.picCheckPass_Click);
            // 
            // picCheckPass2
            // 
            this.picCheckPass2.BaseColor = System.Drawing.Color.White;
            this.picCheckPass2.Image = ((System.Drawing.Image)(resources.GetObject("picCheckPass2.Image")));
            this.picCheckPass2.Location = new System.Drawing.Point(531, 228);
            this.picCheckPass2.Name = "picCheckPass2";
            this.picCheckPass2.Size = new System.Drawing.Size(27, 25);
            this.picCheckPass2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCheckPass2.TabIndex = 127;
            this.picCheckPass2.TabStop = false;
            this.picCheckPass2.Visible = false;
            // 
            // gunaDragControl2
            // 
            this.gunaDragControl2.TargetControl = this.gunaPictureBox1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 128;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 468);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picCheckPass2);
            this.Controls.Add(this.picCheckPass);
            this.Controls.Add(this.lblErrorMesseger);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaLinkLabel1);
            this.Controls.Add(this.gunaCheckBox1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRepeatPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPasswword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fSignup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký";
            this.Load += new System.EventHandler(this.fSignup_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheckPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheckPass2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaCheckBox gunaCheckBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnOk;
        private Bunifu.Framework.UI.BunifuFlatButton btnReset;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtRepeatPass;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPasswword;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLinkLabel gunaLinkLabel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLabel lblErrorMesseger;
        private Guna.UI.WinForms.GunaPictureBox picCheckPass;
        private Guna.UI.WinForms.GunaPictureBox picCheckPass2;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl2;
        private System.Windows.Forms.Button button1;
    }
}