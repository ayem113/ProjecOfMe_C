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
    public partial class fFlatScreen : Form
    {
        public fFlatScreen()
        {
            InitializeComponent();
        }

        private void fFlatScreen_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.TransparencyKey= Color.White;

            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
            timer1.Start();
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            circularProgressBar1.Value += 1;
            circularProgressBar1.Text = circularProgressBar1.Value.ToString();
            if (circularProgressBar1.Value==100)
            {
                timer1.Stop();
                fHome f = new fHome();
                f.Show();
                this.Hide();
            }

        }
    }
}
