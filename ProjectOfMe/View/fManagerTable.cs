using ProjectOfMe.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectOfMe.View
{
    public partial class fManagerTable : Form
    {
        public fManagerTable()
        {
            InitializeComponent();
            //ControlExtension.Draggable(btnFinal, true);
            gridBIllDetal.AutoGenerateColumns = false;
            loadTable();
            fillComboxMenu();
            fillComboxFood();
        }
        public void Alert(string msg, fAlert.enmType type)
        {
            fAlert frm = new fAlert();
            frm.showAlert(msg, type);
        }
        CoffeMannagerDataContext coffe = new CoffeMannagerDataContext();
        private void loadTable()
        {
            var listTable = coffe.Tablesses.Select(x=>x);
            foreach (var item in listTable)
            {
                Button b = new Button() { Width=95, Height=95};
                b.Text = item.Name;
                b.Margin  = new Padding(5, 5, 5, 5);
                b.Font = new Font("Modern No. 20", 10);
                b.TextAlign = ContentAlignment.BottomCenter;
                b.Margin = new Padding(5,5,5,5);
                b.Image = Image.FromFile(@"D:\Downloads\icon\Coffee-icon.png");
                b.BackColor = (item.Statuss =="1") ? Color.Green : Color.White;
                b.Tag = item;
                b.Click += button1_Click;
                palTable.Controls.Add(b);
            }
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor2.PrimaryColor;
                    btn.ForeColor = Color.White;
                }
            }
            //label4.ForeColor = ThemeColor.SecondaryColor;
            //label5.ForeColor = ThemeColor.PrimaryColor;
        }
        int tableId;
        private void button1_Click(object sender, EventArgs e)
        {
            tableId = ((sender as Button).Tag as Tabless).Id;
            showBill(tableId);
        }

        private void showBill(int idTable)
        {


            Bill bill =coffe.Bills.FirstOrDefault(x => x.IDTable == idTable && x.Stt=="0" );
            if (bill != null)
            {
                var listBillDetal = coffe.BillDetals.Where(x => x.IDBill == bill.Id);

                var result = from bd in listBillDetal
                             join b in coffe.Bills on bd.IDBill equals b.Id
                             join f in coffe.Foods on bd.IDFood equals f.Id
                             select new
                             {
                                 foodName = f.Name,
                                 countFood = bd.CountFood,
                                 priceFood = f.Price,
                                 totalPrice = bd.CountFood * f.Price,
                             };

                if (listBillDetal != null )
                {
                    gridBIllDetal.DataSource = result;

                    double TotalPrice=0;
                    foreach (var item in result)
                    {
                        TotalPrice += (double)item.totalPrice;
                    }
                    lblTotalPrice.Text = TotalPrice.ToString();
                    decimal q = Convert.ToDecimal(bill.Disscount.ToString());
                    numericDisscount.Value =q ;
                }
            }
            else
            {
                gridBIllDetal.Rows.Clear();
            }
            
        }

        private void  fillComboxMenu()
        {
            var data = coffe.Menus.Select(x => x);
            cbxMenu.DataSource=data;
            cbxMenu.DisplayMember = "Name";
            cbxMenu.ValueMember = "Id";
        }
        private void fillComboxFood()
        {
            var data = coffe.Foods.Where(x => x.IdMenu == 1);
            cbxFood.DataSource = data;
            cbxFood.DisplayMember = "Name";
            cbxFood.ValueMember = "Id";
        }

        private void cbxMenu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int menuId = ((Menu)cbxMenu.SelectedItem).Id;
            var data = coffe.Foods.Where(x=>x.IdMenu==  menuId);
            cbxFood.DataSource = data;
            cbxFood.DisplayMember = "Name";
            cbxFood.ValueMember = "Id";
        }

        private int getIDBillMax()
        {
            return coffe.Bills.Max(x => x.Id);
        }

        // kiểm tra xem có tồn tại id bill có chứa id bàn k   và lấy ra id 
        private int check_Exist_IdBill_By_Table(int idTable) 
        {
            var data = coffe.Bills.FirstOrDefault(x => x.IDTable == idTable && x.Stt=="0");
            return ( data!=null )  ? data.Id : -1;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
            var idBill = check_Exist_IdBill_By_Table(tableId);

            if (idBill == -1)
            //nếu chưa có thì thêm mới 1 bill và inser thêm billdetal
            {
                //insser bill
                Bill billNew = new Bill();
                billNew.IDTable = tableId;
                billNew.DateCheckin = DateTime.Now;
                billNew.Stt = "0";
                billNew.Disscount = 12;
                coffe.Bills.InsertOnSubmit(billNew);
                coffe.SubmitChanges();

                //lấy ra id bill vừa mới thêm để lấy dữ liệu thêm cho billdetal
                //mà id bill vừa thêm là id lớn nhất vì nó tự tăng identity

                //inser billdetal
                BillDetal billdetal = new BillDetal();
                billdetal.IDBill = getIDBillMax();
                billdetal.IDFood = (cbxFood.SelectedItem as Food).Id;
                if ((int)numericCountFood.Value>0)
                {
                    billdetal.CountFood = (int)numericCountFood.Value;
                    coffe.BillDetals.InsertOnSubmit(billdetal);
                    coffe.SubmitChanges();
                    showBill(tableId);
                    numericCountFood.Value = 1;
                    numericDisscount.Value = 0;
                }
                else
                {
                    Alert("số lượng phải lớn hơn 0",fAlert.enmType.Warning);
                }
                
                
            }
            else //nếu đã tồn tại bill rồi thì inseet thêm vào bill đó
            {
                var idFood= (cbxFood.SelectedItem as Food).Id;

                //kiểm tra xem món này đã tồn tại chưa
                var check_exist_idFood = coffe.BillDetals.FirstOrDefault(x => x.IDFood == idFood && x.IDBill== idBill);
                if (check_exist_idFood!=null)  //nếu tồn tại thì cập nhật số lượng
                {
                    check_exist_idFood.CountFood += (int)numericCountFood.Value;//cập nhật lại số lượng food
                    if (check_exist_idFood.CountFood>0)  //nếu số lượng lớn hơn 0 thì cập nhật bình thường
                    {
                        coffe.SubmitChanges();
                        showBill(tableId);
                        numericCountFood.Value = 1;
                        numericDisscount.Value = 0;
                    }
                    else  //nếu số lượng nhỏ hơn 0 thì xóa billdetal đó
                    {
                        coffe.BillDetals.DeleteOnSubmit(check_exist_idFood);
                        coffe.SubmitChanges();
                        showBill(tableId);
                        numericCountFood.Value = 1;
                        numericDisscount.Value = 0;
                    }
                }
                else //nếu món chưa tồn tại thì thêm mới
                {
                    BillDetal billdetal = new BillDetal();
                    billdetal.IDBill = idBill;
                    billdetal.IDFood = (cbxFood.SelectedItem as Food).Id;
                    billdetal.CountFood = (int)numericCountFood.Value;
                    coffe.BillDetals.InsertOnSubmit(billdetal);
                    coffe.SubmitChanges();
                    showBill(tableId);
                    numericCountFood.Value = 1;
                    numericDisscount.Value = 0;
                }
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
