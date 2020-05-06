using ProjectOfMe.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectOfMe
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
            
        }

        private void SaveSettings()
        {
            if (chkRemember.Checked)
            {
                Properties.Settings.Default.UserName = this.txtUsername.Text;
                Properties.Settings.Default.Password = this.txtPassword.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Reset();
            }
        }

        private void ReadSettings()
        {
            txtUsername.Text = Properties.Settings.Default.UserName;
            txtPassword.Text = Properties.Settings.Default.Password;
        }


        fSignup fSignup = new fSignup();
        fFogetPassword fFoget = new fFogetPassword();

        byte i = 1;
        private void gunaPictureBox4_Click(object sender, EventArgs e)
        {
            i++;
            if (i % 2 != 0)
            {
                txtPassword.PasswordChar = '●';
                picShowPassword.Image = Image.FromFile("D:\\Downloads\\icon\\icon4.png");
            }
            else
            {
                txtPassword.PasswordChar = '\0';
                picShowPassword.Image = Image.FromFile("D:\\Downloads\\icon\\eye-watch-icon.png");
            }

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            SaveSettings();
            //smgError("vui lòng nhập đầy đủ");
            if (txtUsername.Text.Length>0)
            {
                fFlatScreen f = new fFlatScreen();
                f.Show();
                this.Hide();
            }

        }
        private void smgError(string smg)
        {
            lblErrorMesseger.Text = "     " + smg;
            lblErrorMesseger.Visible = true;
        }

        private void LinkLabelSigin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fSignup.Show(); timerSignup.Start();
        }

        private void LinkLabelFoget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fFoget.Show(); timerFoget.Start();
            

            fBackground log = new fBackground();
            //try
            //{
            //    using (fFogetPassword f = new fFogetPassword())
            //    {
            //        log.StartPosition = FormStartPosition.Manual;
            //        log.FormBorderStyle = FormBorderStyle.None;
            //        log.BackColor = Color.Black;
            //        log.WindowState = FormWindowState.Maximized;
            //        log.TopMost = true;
            //        log.Location = this.Location;
            //        log.ShowInTaskbar = false;
            //        log.Show();

            //        f.Owner = log;
            //        f.ShowDialog();
            //        log.Dispose();
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            //finally
            //{
            //    log.Dispose();
            //    this.Hide();
            //}

        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            timerOpacity.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            fSignup.Left += 30;
            if (fSignup.Left >= 820)
            {
                timerSignup.Stop();
                timerSignup2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            fSignup.Left -= 10;
            if (fSignup.Left <= 430)
            {
                timerSignup2.Stop();
                this.Hide();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            fFoget.Left -= 10;
            if (fFoget.Left == 10)
            {
                timerFoget.Stop();
                timerFoget2.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            fFoget.Left += 10;
            if (fFoget.Left >= 430)
            {
                timerFoget2.Stop();
                this.Hide();
            }
        }
        string kq;

        // k dùng 2 cái này
        public static string GetMD52(string chuoi)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(chuoi);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";

            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            return hasPass;
        }
        public static string EncodePasswordToBase64(string password)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] inArray = HashAlgorithm.Create("SHA1").ComputeHash(bytes);
            return Convert.ToBase64String(inArray);
        }



        //dung cái này
        public static string EncodePassword(string password)
        {
            UnicodeEncoding uEncode = new UnicodeEncoding();
            byte[] bytPassword = uEncode.GetBytes(password);
            SHA512Managed sha = new SHA512Managed();
            byte[] hash = sha.ComputeHash(bytPassword);
            return Convert.ToBase64String(hash);
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (this.Opacity>0)
            {
                this.Opacity -= 0.05;
            }
            else
            {
                Application.Exit();
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.Text = "";

        }

        private void chkRemember_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            ReadSettings();
        }
    }
}
