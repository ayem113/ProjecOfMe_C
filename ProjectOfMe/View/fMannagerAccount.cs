using ProjectOfMe.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectOfMe.View
{
    public partial class fMannagerAccount : Form
    {
        public fMannagerAccount()
        {
            InitializeComponent();
            loadGridAccount();
        }
        CoffeMannagerDataContext Coffe = new CoffeMannagerDataContext();

        public void Alert(string msg, fAlert.enmType type)
        {
            fAlert frm = new fAlert();
            frm.showAlert(msg, type);
        }

        private void loadGridAccount()
        {
            var data = Coffe.Accounts.Select(f => f);
            gridAccount.DataSource = data;
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Label))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor2.SecondaryColor;
                    btn.ForeColor = Color.White;
                }
            }
            //label4.ForeColor = ThemeColor.SecondaryColor;
            //label5.ForeColor = ThemeColor.PrimaryColor;
        }

        private void fMannager_Load(object sender, EventArgs e)
        {
        }

        private void gridAccount_SelectionChanged(object sender, EventArgs e)
        {
            txtId.Text = gridAccount.CurrentRow.Cells[0].Value.ToString();
            txtUser.Text = gridAccount.CurrentRow.Cells[1].Value.ToString();
            txtPass.Text = gridAccount.CurrentRow.Cells[2].Value.ToString();
            txtDissplayName.Text = gridAccount.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = gridAccount.CurrentRow.Cells[4].Value.ToString();
            txtLink.Text = gridAccount.CurrentRow.Cells[5].Value.ToString();
            picAccount.Image = (txtLink.Text.Length > 0) ? Image.FromFile(txtLink.Text) : Resources.kisspng_dr_patrick_rein_facharzt_fr_urologie_fmh_urolo_employees_icon_5b44154fa09718_7164931515311885596578;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (isCheckAllTextbox())
            {
                var acc = new Account();
                acc.UserName = txtUser.Text;
                acc.Passwords = txtPass.Text;
                acc.Email = txtEmail.Text;
                acc.DisplayName = txtDissplayName.Text;
                if (File.Exists(txtLink.Text))
                {
                    acc.Img = txtLink.Text;
                    Coffe.Accounts.InsertOnSubmit(acc);
                    Coffe.SubmitChanges();
                    loadGridAccount();
                    Alert("Thêm mới thành công ", fAlert.enmType.Success);
                }
                else
                {
                    Alert("link ảnh không tồn tại", fAlert.enmType.Error);
                }
            }
            else
            {
                Alert("vui lòng không để trống các ô trên", fAlert.enmType.Error);
            }
            
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            var acc = Coffe.Accounts.First(x=>x.Id == Convert.ToByte(txtId.Text));
            edit(acc);
        }

        private bool isCheckAllTextbox()
        {
            return (txtUser.Text == "" || txtPass.Text == "" || txtDissplayName.Text == "" || txtEmail.Text == "" || txtLink.Text == "") ? false : true;
        }
        private void edit(Account acc)
        {
            if (isCheckAllTextbox())
            {
                acc.UserName = txtUser.Text;
                acc.Passwords = txtPass.Text;
                acc.Email = txtEmail.Text;
                acc.DisplayName = txtDissplayName.Text;
                if (File.Exists(txtLink.Text))
                {
                    acc.Img = txtLink.Text;
                    Coffe.SubmitChanges();
                    loadGridAccount();
                    Alert("Đã sửa tài khoản có id= " + acc.Id, fAlert.enmType.Success);
                }
                else
                {
                    Alert("link ảnh không tồn tại", fAlert.enmType.Error);
                }
            }
            else
            {
                Alert("vui lòng không để trống các ô trên", fAlert.enmType.Error);
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            var acc = Coffe.Accounts.First(x => x.Id == Convert.ToByte(txtId.Text));
            Coffe.Accounts.DeleteOnSubmit(acc);
            Coffe.SubmitChanges();
            loadGridAccount();
            Alert("Đã xóa tài khoản có id= " + acc.Id, fAlert.enmType.Success);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtLink.Text = dlg.FileName;
                picAccount.Image= Image.FromFile(dlg.FileName);
            }
        }

        private void gridAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
