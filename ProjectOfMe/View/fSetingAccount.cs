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
    public partial class fSetingAccount : Form
    {
        public fSetingAccount()
        {
            InitializeComponent();
            loadGridAccount();
        }
        CoffeMannagerDataContext coffe = new CoffeMannagerDataContext();
        private void loadGridAccount() {
            var data = coffe.Accounts.Select(a => a);
            gridAccount.DataSource=data;
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

        private void fSetingAccount_Load(object sender, EventArgs e)
        {
        }

        private void gridAccount2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
