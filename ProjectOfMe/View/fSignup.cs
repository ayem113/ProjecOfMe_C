using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectOfMe.View
{
    public partial class fSignup : Form
    {
        public fSignup()
        {
            InitializeComponent();
            ControlExtension.Draggable(button1, true);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            lblErrorMesseger.Visible = false;
            txtUsername.Text = txtPasswword.Text = txtRepeatPass.Text = txtEmail.Text = "";
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                smgError("vui lòng nhập tên đăng nhập  ");
                txtUsername.Focus();
            }

            else
                if (String.IsNullOrEmpty(txtPasswword.Text))
            {
                smgError("vui lòng nhập mật khẩu  ");
                txtPasswword.Focus();
            }
            else
                if ((txtPasswword.Text.Length <= 4))
            {
                smgError(" mật khẩu phải trên 4 ký tự  ");
                txtPasswword.Focus();
            }
            else
                if (String.IsNullOrEmpty(txtRepeatPass.Text))
            {
                smgError("vui lòng nhập lại mật khẩu  ");
                txtRepeatPass.Focus();
            }
            else
                if (txtPasswword.Text != txtRepeatPass.Text)
            {
                smgError("mật khẩu không khớp nhau  ");
                txtRepeatPass.Focus();
                picCheckPass2.Visible = false;
            }
            else
                if (String.IsNullOrEmpty(txtEmail.Text))
            {
                smgError("vui lòng nhập email  ");
                txtEmail.Focus();
            }
            else
                if (IsEmail(txtEmail.Text) == false)
            {
                smgError("không đúng định dạng email  ");
                txtEmail.Focus();
            }
            else
                if (gunaCheckBox1.Checked == false)
            {
                smgError("click checkbox ? ");
            }
            else
                if (gunaCheckBox1.Checked)
            {
                fLogin f = new fLogin();
                f.Show();
                this.Hide();
            }
        }

        private void smgError(string smg)
        {
            lblErrorMesseger.Text = "     " + smg;
            lblErrorMesseger.Visible = true;
        }
        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fLogin f = new fLogin();
            f.Show();
            this.Hide();
        }

        private void bunifuMaterialTextbox1_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtUsername.ForeColor = Color.Green;
        }

        private void bunifuMaterialTextbox2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtUsername.ForeColor = Color.Green;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            fLogin f = new fLogin();
            f.Show();
        }

        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtUsername.ForeColor = Color.Green;
        }



        private void txtPasswword_Enter(object sender, EventArgs e)
        {
            txtPasswword.ForeColor = Color.Green;
            txtPasswword.Text = "";
        }

        private void txtRepeatPass_Enter(object sender, EventArgs e)
        {
            txtRepeatPass.ForeColor = Color.Green;
            txtRepeatPass.Text = "";
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.ForeColor = Color.Green;
            txtEmail.Text = "";
        }

        bool IsEmail(string s)
        {
            return Regex.IsMatch(s, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        private void txtPasswword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPasswword.Text.Length <= 4 && txtPasswword.Text.Length >= 1)
            {
                picCheckPass.Visible = true;
            }
            if (txtPasswword.Text.Length > 4)
            {
                picCheckPass.Image = Image.FromFile("D:\\Downloads\\icon\\success-icon.png");
            }
        }

        private void txtRepeatPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtRepeatPass.Text == txtPasswword.Text)
            {
                picCheckPass2.Visible = true;
            }
        }

        private void fSignup_Load(object sender, EventArgs e)
        {
        }

        private void picCheckPass_Click(object sender, EventArgs e)
        {

        }
    }
}
