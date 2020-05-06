using ProjectOfMe.Properties;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ProjectOfMe.View
{
    public partial class fHome : Form
    {
        public fHome()
        {

            InitializeComponent();
            customizeSubMenuPane();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void moveSidePanel(Button b)
        {
            sidePanel.Height = b.Height;
            sidePanel.Top = b.Top;
        }
        //void exportExcel(string path)
        //{
        //    var x = Type.Missing;
        //    Excel._Application app = new Excel.Application();
        //    Excel._Workbook workbook = app.Workbooks.Add(x);
        //    Excel._Worksheet worksheet = workbook.Sheets["Sheet1"];
        //    for (int i = 1; i < DATA.Columns.Count + 1; i++)
        //    {
        //        worksheet.Cells[1, i] = DATA.Columns[i - 1].HeaderText;
        //    }
        //    for (int i = 0; i < DATA.RowCount - 1; i++)
        //    {
        //        for (int j = 0; j < DATA.ColumnCount; j++)
        //        {
        //            worksheet.Cells[i + 2, j + 1] = DATA.Rows[i].Cells[j].Value.ToString();
        //        }
        //    }
        //    workbook.SaveAs(path, x, x, x, x, x, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, x, x, x, x);
        //    MessageBox.Show("Excel file successful", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}
        private Button currentButton;
        private Random random = new Random();
        private int tempIndex;

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor2.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor2.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor2.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }


        private void ActivateButton(object btnSender)  // tạo hành động cho btn được click
        {
            if (btnSender != null)
            {

                if (currentButton != (Button)btnSender) //nếu btn hiện tại mà khác btn được click
                {

                    DisableButton(); //khôi phục btn mới click lần trước
                        
                    //thay đổi các đặc tính btn mới click theo ý
                    Color color = SelectThemeColor(); 
                    currentButton = (Button)btnSender;
                    //sidePanel.BackColor = color;
                    sidePanel.Visible = true;
                    currentButton.BackColor = color;
                    //currentButton.ImageAlign = ContentAlignment.MiddleRight;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular);
                    panelTitleBar.BackColor = color;
                    ThemeColor2.PrimaryColor = color;
                    ThemeColor2.SecondaryColor = ThemeColor2.ChangeColorBrightness(color, -0.3);

                    lblCloseChildForm.Visible = true;
                }
                


            }
        }
        private void DisableButton() //khôi phục btn mới click lần trước
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(51, 51, 76);
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 08F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }

        private void fHome_Load(object sender, EventArgs e)
        {
            AnimateHOme.AnimateWindow(this.Handle, 2000, AnimateHOme.CENTER);
            Mdi_Load2(new fManagerTable(), sender);
            lblTitle.Text = "HOME";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            timerOpacity.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            // có  hiệu ứng
            if (pnlSiderMenu.Width == 53)
            {
                pnlSiderMenu.Visible = false;
                pnlSiderMenu.Width = 150;
                PanelAnimator.ShowSync(pnlSiderMenu);
                LogoAnimator.ShowSync(piclogo);
            }
            else
            {
                LogoAnimator.Hide(piclogo);
                pnlSiderMenu.Visible = false;
                pnlSiderMenu.Width = 53;
                PanelAnimator.ShowSync(pnlSiderMenu);
            }


            // k hiệu ứng
            //if (sideMenu.Width==190)
            //{
            //    sideMenu.Width = 50;
            //}
            //else
            //{
            //    sideMenu.Width = 190;
            //}
        }

        private void Mdi_Load(Form frm)
        {
            frm.MdiParent = this;
            // Định dạng form trước khi mở
            frm.StartPosition = FormStartPosition.Manual;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            // Kiểm tra xem có form con nào đang mở chưa?
            if (this.ActiveMdiChild != null) // Nếu có
            {
                // Lấy form hiện tại
                Form frmCurrent = this.ActiveMdiChild;

                if (frmCurrent.Name != frm.Name)
                {
                    frmCurrent.Close();
                    frm.Show();
                }
            }
            else
            {
                frm.Show();
            }
        }
        private void Mdi_Load2(Form frm, object btnSender)
        {
            frm.MdiParent = this;
            // Định dạng form trước khi mở
            frm.StartPosition = FormStartPosition.Manual;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            // Kiểm tra xem có form con nào đang mở chưa?
            if (this.ActiveMdiChild != null) // Nếu có
            {
                // Lấy form hiện tại
                Form frmCurrent = this.ActiveMdiChild;
                ActivateButton(btnSender);
                if (frmCurrent.Name != frm.Name)
                {
                    frmCurrent.Close();
                    frm.Show();
                    lblTitle.Text = frm.Text;
                }
            }
            else
            {
                frm.Show();
            }
        }

        private void timerOpacity_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.05;
            }
            else
            {
                Application.Exit();
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {
            ResetPage();
            Mdi_Load(new fManagerTable());
        }

        private void ResetPage()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            currentButton = null;
            lblCloseChildForm.Visible = false;

        }

        private void piclogo_Click(object sender, EventArgs e)
        {
            ResetPage();
            Mdi_Load(new fManagerTable());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            moveSidePanel((Button)sender);
            showSubMenuPane(pnlSubMenu4);
        }

        private void btnMannager_Click_1(object sender, EventArgs e)
        {
            moveSidePanel((Button)sender);
            showSubMenuPane(pnlSubMenu2); 
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            moveSidePanel((Button)sender);
            Mdi_Load2(new fDashboard(), sender);
        }

        private void btnSystem_Click_1(object sender, EventArgs e)
        {
            moveSidePanel((Button)sender);
            showSubMenuPane(pnlSubMenu1);
        }

        bool ok=true;

        private void tmDropdownButon_Tick(object sender, EventArgs e)
        {
            if (ok==true)
            {
                btnDropdown.Image = Resources.dollar_stats_icon;
                panel1.Height += 10;
                if (panel1.Size==panel1.MaximumSize)
                {
                    tmDropdownButon.Stop();
                    ok = false;
                }
            }
            else
            {
                btnDropdown.Image = Resources.camera_icon__1_;
                panel1.Height -= 10;
                if (panel1.Size == panel1.MinimumSize)
                {
                    tmDropdownButon.Stop();
                    ok = true;
                }
            }
        }

        private void btnDropdown_Click(object sender, EventArgs e)
        {
            tmDropdownButon.Start();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            timerOpacity.Start();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label4_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            Mdi_Load2(new fSystem(), sender);
        }

        public void Alert(string msg, fAlert.enmType type)
        {
            fAlert frm = new fAlert();
            frm.showAlert(msg, type);
        }

        private void customizeSubMenuPane() {
            pnlSubMenu1.Visible = false;
            pnlSubMenu2.Visible = false;
            pnlSubMenu4.Visible = false;
        }

        private void showSubMenuPane(Panel p)
        {
            if (p.Visible==false)
            {
                hideSubMenuPane();
                p.Visible = true;
            }
            else
            {
                p.Visible = false;
            }
        }
        private void hideSubMenuPane()
        {
            if (pnlSubMenu1.Visible==true) pnlSubMenu1.Visible = false;
            if (pnlSubMenu2.Visible==true) pnlSubMenu2.Visible = false;
            if (pnlSubMenu4.Visible==true) pnlSubMenu4.Visible = false;
            
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            f.Show();
            this.Hide();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Mdi_Load2(new fMannagerMenu(), sender);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Mdi_Load2(new fMannagerFood(), sender);
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tmDropdownButon.Start();
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            //Alert("Warning Alert", fAlert.enmType.Warning);
            Mdi_Load2(new fSetingAccount(), sender);
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            Alert("Error Alert", fAlert.enmType.Error);
            Mdi_Load2(new fChanagePassword(), sender);
        }

        private void iconButton1_Click_2(object sender, EventArgs e)
        {
            Mdi_Load2(new fReport(), sender);
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            Mdi_Load2(new fMannagerAccount(), sender);
        }
    }
}
