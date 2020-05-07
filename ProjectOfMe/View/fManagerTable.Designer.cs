namespace ProjectOfMe.View
{
    partial class fManagerTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.palTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.numericDisscount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnFinal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnOrderfood = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.numericCountFood = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxFood = new System.Windows.Forms.ComboBox();
            this.cbxMenu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridBIllDetal = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDisscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCountFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBIllDetal)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // palTable
            // 
            this.palTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.palTable.AutoScroll = true;
            this.palTable.Location = new System.Drawing.Point(0, 0);
            this.palTable.MinimumSize = new System.Drawing.Size(20, 20);
            this.palTable.Name = "palTable";
            this.palTable.Size = new System.Drawing.Size(142, 450);
            this.palTable.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.gridBIllDetal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(148, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 450);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.numericDisscount);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblTotalPrice);
            this.panel2.Controls.Add(this.btnFinal);
            this.panel2.Controls.Add(this.btnOrderfood);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.numericCountFood);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbxFood);
            this.panel2.Controls.Add(this.cbxMenu);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 346);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 101);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Giảm giá";
            // 
            // numericDisscount
            // 
            this.numericDisscount.Location = new System.Drawing.Point(313, 67);
            this.numericDisscount.Name = "numericDisscount";
            this.numericDisscount.Size = new System.Drawing.Size(61, 20);
            this.numericDisscount.TabIndex = 19;
            this.numericDisscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(257, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tổng tiền(Nghìn)";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(327, 6);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(164, 48);
            this.lblTotalPrice.TabIndex = 17;
            this.lblTotalPrice.Text = "0";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFinal
            // 
            this.btnFinal.Active = false;
            this.btnFinal.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnFinal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFinal.BorderRadius = 0;
            this.btnFinal.ButtonText = "Thanh toán";
            this.btnFinal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinal.DisabledColor = System.Drawing.Color.Gray;
            this.btnFinal.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFinal.Iconimage = global::ProjectOfMe.Properties.Resources.US_dollar_icon;
            this.btnFinal.Iconimage_right = null;
            this.btnFinal.Iconimage_right_Selected = null;
            this.btnFinal.Iconimage_Selected = null;
            this.btnFinal.IconMarginLeft = 0;
            this.btnFinal.IconMarginRight = 0;
            this.btnFinal.IconRightVisible = true;
            this.btnFinal.IconRightZoom = 0D;
            this.btnFinal.IconVisible = true;
            this.btnFinal.IconZoom = 60D;
            this.btnFinal.IsTab = false;
            this.btnFinal.Location = new System.Drawing.Point(384, 61);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnFinal.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnFinal.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFinal.selected = false;
            this.btnFinal.Size = new System.Drawing.Size(107, 31);
            this.btnFinal.TabIndex = 16;
            this.btnFinal.Text = "Thanh toán";
            this.btnFinal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinal.Textcolor = System.Drawing.Color.White;
            this.btnFinal.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinal.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // btnOrderfood
            // 
            this.btnOrderfood.Active = false;
            this.btnOrderfood.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnOrderfood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnOrderfood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOrderfood.BorderRadius = 0;
            this.btnOrderfood.ButtonText = "Gọi món";
            this.btnOrderfood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrderfood.DisabledColor = System.Drawing.Color.Gray;
            this.btnOrderfood.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOrderfood.Iconimage = global::ProjectOfMe.Properties.Resources.Actions_list_add_icon;
            this.btnOrderfood.Iconimage_right = null;
            this.btnOrderfood.Iconimage_right_Selected = null;
            this.btnOrderfood.Iconimage_Selected = null;
            this.btnOrderfood.IconMarginLeft = 0;
            this.btnOrderfood.IconMarginRight = 0;
            this.btnOrderfood.IconRightVisible = true;
            this.btnOrderfood.IconRightZoom = 0D;
            this.btnOrderfood.IconVisible = true;
            this.btnOrderfood.IconZoom = 60D;
            this.btnOrderfood.IsTab = false;
            this.btnOrderfood.Location = new System.Drawing.Point(141, 61);
            this.btnOrderfood.Name = "btnOrderfood";
            this.btnOrderfood.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnOrderfood.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnOrderfood.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOrderfood.selected = false;
            this.btnOrderfood.Size = new System.Drawing.Size(97, 31);
            this.btnOrderfood.TabIndex = 14;
            this.btnOrderfood.Text = "Gọi món";
            this.btnOrderfood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderfood.Textcolor = System.Drawing.Color.White;
            this.btnOrderfood.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderfood.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số lượng";
            // 
            // numericCountFood
            // 
            this.numericCountFood.Location = new System.Drawing.Point(74, 65);
            this.numericCountFood.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericCountFood.Name = "numericCountFood";
            this.numericCountFood.Size = new System.Drawing.Size(61, 20);
            this.numericCountFood.TabIndex = 6;
            this.numericCountFood.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericCountFood.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên món";
            // 
            // cbxFood
            // 
            this.cbxFood.FormattingEnabled = true;
            this.cbxFood.Location = new System.Drawing.Point(74, 32);
            this.cbxFood.Name = "cbxFood";
            this.cbxFood.Size = new System.Drawing.Size(164, 21);
            this.cbxFood.TabIndex = 4;
            // 
            // cbxMenu
            // 
            this.cbxMenu.FormattingEnabled = true;
            this.cbxMenu.Location = new System.Drawing.Point(74, 3);
            this.cbxMenu.Name = "cbxMenu";
            this.cbxMenu.Size = new System.Drawing.Size(164, 21);
            this.cbxMenu.TabIndex = 3;
            this.cbxMenu.SelectionChangeCommitted += new System.EventHandler(this.cbxMenu_SelectionChangeCommitted);
            this.cbxMenu.Click += new System.EventHandler(this.cbxMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu";
            // 
            // gridBIllDetal
            // 
            this.gridBIllDetal.AllowUserToAddRows = false;
            this.gridBIllDetal.AllowUserToDeleteRows = false;
            this.gridBIllDetal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridBIllDetal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBIllDetal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBIllDetal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.gridBIllDetal.Location = new System.Drawing.Point(3, 3);
            this.gridBIllDetal.Name = "gridBIllDetal";
            this.gridBIllDetal.ReadOnly = true;
            this.gridBIllDetal.Size = new System.Drawing.Size(494, 337);
            this.gridBIllDetal.TabIndex = 1;
            this.gridBIllDetal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBIllDetal_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "foodName";
            this.Column1.HeaderText = "Tên món";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "countFood";
            this.Column2.HeaderText = "Số lượng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "priceFood";
            this.Column3.HeaderText = "Đơn giá";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "totalPrice";
            this.Column4.HeaderText = "Thành tiền";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // fManagerTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.palTable);
            this.Name = "fManagerTable";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Quản lý bàn";
            this.Load += new System.EventHandler(this.fManagerTable_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDisscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCountFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBIllDetal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.FlowLayoutPanel palTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridBIllDetal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericCountFood;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxFood;
        private System.Windows.Forms.ComboBox cbxMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnOrderfood;
        private Bunifu.Framework.UI.BunifuFlatButton btnFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericDisscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}