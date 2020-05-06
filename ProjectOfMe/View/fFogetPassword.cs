using System;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace ProjectOfMe.View
{
    public partial class fFogetPassword : Form
    {
        public fFogetPassword()
        {
            InitializeComponent();
        }
        string xxx = "Halinhchi@@";

        private void smgError(string smg)
        {
            lblErrorMesseger.Text = "     " + smg;
            lblErrorMesseger.Visible = true;
        }
        private void smgErrorOTP(string smg)
        {
            lblCheckOTP.Text = "     " + smg;
            lblCheckOTP.Visible = true;
        }

        string OTP;
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            if (checkEmail(txtEmalAddrees.Text))
            {
                SendMail();
            }
            else
            {
                smgError("Email không chính xác");
            }

        }

        private bool checkEmail(string s)
        {
            return true;
        }

        private void SendMail()
        {
            try
            {
                OTP = new Random().Next(999999).ToString();
                using (MailMessage message = new MailMessage("ayem113halinhchi@gmail.com", txtEmalAddrees.Text, "Thông báo", "Mã của bạn là: " + OTP))
                {
                    using (SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587))
                    {
                        mailclient.EnableSsl = true;
                        mailclient.Credentials = new NetworkCredential("ayem113halinhchi@gmail.com", xxx);
                        mailclient.Send(message);
                        MessageBox.Show("Mail đã được gửi đi: Vui lòng kiểm tra email của bạn", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtOTP.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fLogin f = new fLogin();
            f.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            fLogin f = new fLogin();
            f.Show();
        }

        private void txtEmalAddrees_Enter(object sender, EventArgs e)
        {
            txtEmalAddrees.Text = "";
            txtEmalAddrees.ForeColor = Color.Purple;
        }

        private void txtOTP_Enter(object sender, EventArgs e)
        {
            ac = (Control)sender;
        }

        private void txtNewPass_Enter(object sender, EventArgs e)
        {
            txtNewPass.Text = "";
            txtNewPass.ForeColor = Color.Purple;
        }

        private void txtNewPass2_Enter(object sender, EventArgs e)
        {
            txtNewPass2.Text = "";
            txtNewPass2.ForeColor = Color.Purple;
        }

        private void btnCheckOtp_Click(object sender, EventArgs e)
        {
            if (txtOTP.Text == OTP)
            {
                panel1.Visible = true;
            }
            else
            {
                smgErrorOTP("Mã không chính xác!");
            }
        }

        private void BtnSucssec_Click(object sender, EventArgs e)
        {
            if (txtNewPass2.Text != txtNewPass.Text)
            {
                fLogin f = new fLogin();
                f.Show();
                this.Hide();
            }
        }

        private void txtNewPass_OnValueChanged(object sender, EventArgs e)
        {
            if (txtNewPass.Text.Length <= 4 && txtNewPass.Text.Length >= 1)
            {
                picCheckPass.Visible = true;
            }
            if (txtNewPass.Text.Length > 4)
            {
                picCheckPass.Image = Image.FromFile("D:\\Downloads\\icon\\success-icon.png");
            }

        }
        private void txtNewPass2_OnValueChanged(object sender, EventArgs e)
        {
            if (txtNewPass2.Text == txtNewPass.Text)
            {
                picCheckPass2.Visible = true;
            }
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void fFogetPassword_Load(object sender, EventArgs e)
        {

        }

        Control ac;
        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            txtOTP.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            SendKeys.Send(btn.Text);
        }

        private void txtOTP_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
