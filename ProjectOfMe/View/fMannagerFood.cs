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
    public partial class fMannagerFood : Form
    {
        public fMannagerFood()
        {
            InitializeComponent();
            loadGridFood();
            
        }
        CoffeMannagerDataContext Coffe = new CoffeMannagerDataContext();

        private void loadGridFood()
        {
            var data = Coffe.Foods.Select(f => f);
            gridFood.DataSource = data;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtLink.Text = dlg.FileName;
                picFood.Image = Image.FromFile(dlg.FileName);
            }
        }
        public void Alert(string msg, fAlert.enmType type)
        {
            fAlert frm = new fAlert();
            frm.showAlert(msg, type);
        }

        private bool isCheckAllTextbox()
        {
            return (txtIdMEnu.Text==""|| txtLink.Text == "" || txtName.Text == "" || txtPrice.Text == "") ? false : true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isCheckAllTextbox())
            {
                Food data = new Food();
                data.Name = txtName.Text;
                data.Price = Convert.ToDouble(txtPrice.Text);
                data.Img = txtLink.Text;
                data.IdMenu = Convert.ToInt32(txtIdMEnu.Text);

                if (File.Exists(txtLink.Text))
                {
                    data.Img = txtLink.Text;
                    data.IdMenu = Convert.ToInt32(txtIdMEnu.Text);
                    Coffe.Foods.InsertOnSubmit(data);
                    Coffe.SubmitChanges();
                    loadGridFood();
                    Alert("Sửa thành công sản phẩm có id= " + data.Id, fAlert.enmType.Success);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var food = Coffe.Foods.First(x => x.Id == Convert.ToByte(txtId.Text));
            edit(food);
        }
        private void edit(Food acc)
        {
            if (isCheckAllTextbox())
            {
                acc.Name = txtName.Text;
                acc.Price = Convert.ToDouble(txtPrice.Text);
                if (File.Exists(txtLink.Text))
                {
                    acc.Img = txtLink.Text;
                    acc.IdMenu = Convert.ToInt32(txtIdMEnu.Text);
                    Coffe.SubmitChanges();
                    loadGridFood();
                    Alert("Sửa thành công sản phẩm có id= " + acc.Id, fAlert.enmType.Success);
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var food = Coffe.Foods.First(x => x.Id == Convert.ToByte(txtId.Text));
            Coffe.Foods.DeleteOnSubmit(food);
            Alert("xóa thành công sản phẩm có id= " + food.Id, fAlert.enmType.Success);
        }

        private void gridFood_SelectionChanged(object sender, EventArgs e)
        {
            txtId.Text = gridFood.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = gridFood.CurrentRow.Cells[1].Value.ToString();
            txtPrice.Text = gridFood.CurrentRow.Cells[2].Value.ToString();
            txtLink.Text = gridFood.CurrentRow.Cells[3].Value.ToString();
            txtIdMEnu.Text = gridFood.CurrentRow.Cells[4].Value.ToString();
            picFood.Image = (txtLink.Text.Length > 0) ? Image.FromFile(txtLink.Text) : Resources.drink_4_icon;
        }
    }
}
