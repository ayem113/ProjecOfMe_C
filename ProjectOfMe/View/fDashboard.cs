using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectOfMe.View
{
    public partial class fDashboard : Form
    {
        public fDashboard()
        {
            InitializeComponent();
            LoadTheme();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                lblSecons.Text = DateTime.Now.ToString("ss");
                lblTime.Text = DateTime.Now.ToString("hh:mm");
                lblMonth.Text = DateTime.Now.ToString("dddd");
                lblYear.Text = DateTime.Now.ToString("dd/M/yyyy");
                circularProgressBar1.Value = Convert.ToInt32(lblSecons.Text);

            }
            catch (Exception)
            {
                return;
            }
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor2.SecondaryColor;
                    btn.ForeColor = Color.White;
                }
            }
            //label4.ForeColor = ThemeColor.SecondaryColor;
            //label5.ForeColor = ThemeColor.PrimaryColor;
        }
        private void fDashboard_Load(object sender, EventArgs e)
        {
            AnimateHOme.AnimateWindow(this.Handle, 2000, AnimateHOme.HOR_POSSITIVE);
            tmClock.Start();
        }
    }
}
