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
    public partial class fMannagerMenu : Form
    {
        public fMannagerMenu()
        {
            InitializeComponent();
            loadGridMenu();
    }
        CoffeMannagerDataContext coffe = new CoffeMannagerDataContext();

        private void loadGridMenu()
        {
            var data = coffe.Menus.Select(a => a);
            gridMenu.DataSource = data;
        }
        public void Alert(string msg, fAlert.enmType type)
        {
            fAlert frm = new fAlert();
            frm.showAlert(msg, type);
        }
        private bool isCheckAllTextbox() {
            return (txtName.Text=="") ? false : true;
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (isCheckAllTextbox())
            {
                Menu data = new Menu();
                data.Name = txtName.Text;

                var da = coffe.Menus.FirstOrDefault(x => x.Name.Equals(txtName.Text));
                if (da==null)
                {
                    coffe.Menus.InsertOnSubmit(data);
                    coffe.SubmitChanges();
                    Alert("Thêm thành công", fAlert.enmType.Success);
                    loadGridMenu();
                }
                else
                {
                    Alert("tên menu không được trùng",fAlert.enmType.Error);
                }
                
            }
            else
            {
                Alert("vui lòng nhập tên Menu", fAlert.enmType.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (isCheckAllTextbox())
            {
                var data = coffe.Menus.First(x => x.Id == Convert.ToInt32(txtId.Text));
                data.Name = txtName.Text;
                coffe.SubmitChanges();
                Alert("Cập nhật thành công menu có id la "+data.Id, fAlert.enmType.Success);
                loadGridMenu();
            }
            else
            {
                Alert("vui lòng nhập tên Menu", fAlert.enmType.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            var data = coffe.Menus.First(x => x.Id == id);
            coffe.Menus.DeleteOnSubmit(data);
            coffe.SubmitChanges();
            Alert("xóa thành công menu có id là " + data.Id, fAlert.enmType.Success);
            loadGridMenu();
        }

        private void gridMenu_SelectionChanged(object sender, EventArgs e)
        {
            txtId.Text = gridMenu.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = gridMenu.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
