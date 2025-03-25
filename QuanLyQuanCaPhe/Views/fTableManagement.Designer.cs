namespace QuanLyQuanCaPhe
{
    partial class fTableManagement
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
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            adminToolStripMenuItem1 = new ToolStripMenuItem();
            AccountInfoToolStripMenuItem = new ToolStripMenuItem();
            PersonallnfoToolStripMenuItem = new ToolStripMenuItem();
            LogOutToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            txtTable_Name = new TextBox();
            nudCount = new NumericUpDown();
            btnThem_Mon = new Button();
            cbFood = new ComboBox();
            cbFoodCategory = new ComboBox();
            panel3 = new Panel();
            lstBill = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel4 = new Panel();
            txbTotalPrice = new TextBox();
            nudDiscount = new NumericUpDown();
            cbList_Table = new ComboBox();
            btnThanh_Toan = new Button();
            btnDiscount = new Button();
            btnChange_Table = new Button();
            flpTableManager = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCount).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiscount).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, AccountInfoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1183, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adminToolStripMenuItem1 });
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(67, 24);
            adminToolStripMenuItem.Text = "Admin";
            // 
            // adminToolStripMenuItem1
            // 
            adminToolStripMenuItem1.Name = "adminToolStripMenuItem1";
            adminToolStripMenuItem1.Size = new Size(136, 26);
            adminToolStripMenuItem1.Text = "Admin";
            adminToolStripMenuItem1.Click += adminToolStripMenuItem1_Click;
            // 
            // AccountInfoToolStripMenuItem
            // 
            AccountInfoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { PersonallnfoToolStripMenuItem, LogOutToolStripMenuItem });
            AccountInfoToolStripMenuItem.Name = "AccountInfoToolStripMenuItem";
            AccountInfoToolStripMenuItem.Size = new Size(151, 24);
            AccountInfoToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // PersonallnfoToolStripMenuItem
            // 
            PersonallnfoToolStripMenuItem.Name = "PersonallnfoToolStripMenuItem";
            PersonallnfoToolStripMenuItem.Size = new Size(210, 26);
            PersonallnfoToolStripMenuItem.Text = "Thông tin cá nhân";
            PersonallnfoToolStripMenuItem.Click += PersonallnfoToolStripMenuItem_Click;
            // 
            // LogOutToolStripMenuItem
            // 
            LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem";
            LogOutToolStripMenuItem.Size = new Size(210, 26);
            LogOutToolStripMenuItem.Text = "Đăng xuất";
            LogOutToolStripMenuItem.Click += LogOutToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtTable_Name);
            panel2.Controls.Add(nudCount);
            panel2.Controls.Add(btnThem_Mon);
            panel2.Controls.Add(cbFood);
            panel2.Controls.Add(cbFoodCategory);
            panel2.Location = new Point(683, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(488, 133);
            panel2.TabIndex = 2;
            // 
            // txtTable_Name
            // 
            txtTable_Name.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtTable_Name.Location = new Point(245, 23);
            txtTable_Name.Name = "txtTable_Name";
            txtTable_Name.ReadOnly = true;
            txtTable_Name.Size = new Size(116, 30);
            txtTable_Name.TabIndex = 4;
            // 
            // nudCount
            // 
            nudCount.Location = new Point(248, 57);
            nudCount.Name = "nudCount";
            nudCount.Size = new Size(113, 27);
            nudCount.TabIndex = 3;
            // 
            // btnThem_Mon
            // 
            btnThem_Mon.Location = new Point(376, 22);
            btnThem_Mon.Name = "btnThem_Mon";
            btnThem_Mon.Size = new Size(94, 62);
            btnThem_Mon.TabIndex = 2;
            btnThem_Mon.Text = "Thêm món";
            btnThem_Mon.UseVisualStyleBackColor = true;
            btnThem_Mon.Click += btnThem_Mon_Click;
            // 
            // cbFood
            // 
            cbFood.FormattingEnabled = true;
            cbFood.Location = new Point(3, 56);
            cbFood.Name = "cbFood";
            cbFood.Size = new Size(232, 28);
            cbFood.TabIndex = 1;
            // 
            // cbFoodCategory
            // 
            cbFoodCategory.FormattingEnabled = true;
            cbFoodCategory.Location = new Point(3, 22);
            cbFoodCategory.Name = "cbFoodCategory";
            cbFoodCategory.Size = new Size(232, 28);
            cbFoodCategory.TabIndex = 0;
            cbFoodCategory.SelectedIndexChanged += cbFoodCategory_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(lstBill);
            panel3.Location = new Point(683, 181);
            panel3.Name = "panel3";
            panel3.Size = new Size(488, 387);
            panel3.TabIndex = 3;
            // 
            // lstBill
            // 
            lstBill.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lstBill.GridLines = true;
            lstBill.Location = new Point(3, 3);
            lstBill.Name = "lstBill";
            lstBill.Size = new Size(482, 381);
            lstBill.TabIndex = 0;
            lstBill.UseCompatibleStateImageBehavior = false;
            lstBill.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên món";
            columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số lượng";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn giá";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Thành tiền";
            columnHeader4.Width = 100;
            // 
            // panel4
            // 
            panel4.Controls.Add(txbTotalPrice);
            panel4.Controls.Add(nudDiscount);
            panel4.Controls.Add(cbList_Table);
            panel4.Controls.Add(btnThanh_Toan);
            panel4.Controls.Add(btnDiscount);
            panel4.Controls.Add(btnChange_Table);
            panel4.Location = new Point(683, 574);
            panel4.Name = "panel4";
            panel4.Size = new Size(488, 86);
            panel4.TabIndex = 4;
            // 
            // txbTotalPrice
            // 
            txbTotalPrice.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txbTotalPrice.ForeColor = Color.Red;
            txbTotalPrice.Location = new Point(226, 25);
            txbTotalPrice.Name = "txbTotalPrice";
            txbTotalPrice.ReadOnly = true;
            txbTotalPrice.Size = new Size(135, 30);
            txbTotalPrice.TabIndex = 5;
            txbTotalPrice.Text = "0";
            txbTotalPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // nudDiscount
            // 
            nudDiscount.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            nudDiscount.Location = new Point(119, 46);
            nudDiscount.Name = "nudDiscount";
            nudDiscount.Size = new Size(101, 27);
            nudDiscount.TabIndex = 4;
            // 
            // cbList_Table
            // 
            cbList_Table.FormattingEnabled = true;
            cbList_Table.Location = new Point(3, 45);
            cbList_Table.Name = "cbList_Table";
            cbList_Table.Size = new Size(110, 28);
            cbList_Table.TabIndex = 3;
            // 
            // btnThanh_Toan
            // 
            btnThanh_Toan.Location = new Point(363, 3);
            btnThanh_Toan.Name = "btnThanh_Toan";
            btnThanh_Toan.Size = new Size(122, 70);
            btnThanh_Toan.TabIndex = 2;
            btnThanh_Toan.Text = "Thanh toán";
            btnThanh_Toan.UseVisualStyleBackColor = true;
            btnThanh_Toan.Click += btnThanh_Toan_Click;
            // 
            // btnDiscount
            // 
            btnDiscount.Location = new Point(118, 3);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(102, 37);
            btnDiscount.TabIndex = 1;
            btnDiscount.Text = "Giảm giá";
            btnDiscount.UseVisualStyleBackColor = true;
            btnDiscount.Click += btnDiscount_Click;
            // 
            // btnChange_Table
            // 
            btnChange_Table.Location = new Point(3, 3);
            btnChange_Table.Name = "btnChange_Table";
            btnChange_Table.Size = new Size(110, 37);
            btnChange_Table.TabIndex = 0;
            btnChange_Table.Text = "Chuyển bàn";
            btnChange_Table.UseVisualStyleBackColor = true;
            btnChange_Table.Click += btnChange_Table_Click;
            // 
            // flpTableManager
            // 
            flpTableManager.AutoScroll = true;
            flpTableManager.Location = new Point(12, 42);
            flpTableManager.Name = "flpTableManager";
            flpTableManager.Size = new Size(665, 618);
            flpTableManager.TabIndex = 5;
            // 
            // fTableManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 695);
            Controls.Add(flpTableManager);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "fTableManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm quản lý quán cà phê";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCount).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiscount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem AccountInfoToolStripMenuItem;
        private ToolStripMenuItem PersonallnfoToolStripMenuItem;
        private ToolStripMenuItem LogOutToolStripMenuItem;
        private Panel panel2;
        private Button btnThem_Mon;
        private ComboBox cbFood;
        private ComboBox cbFoodCategory;
        private Panel panel3;
        private Panel panel4;
        private NumericUpDown nudCount;
        private NumericUpDown nudDiscount;
        private ComboBox cbList_Table;
        private Button btnThanh_Toan;
        private Button btnDiscount;
        private Button btnChange_Table;
        private ToolStripMenuItem adminToolStripMenuItem1;
        private FlowLayoutPanel flpTableManager;
        private ListView lstBill;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox txbTotalPrice;
        private TextBox txtTable_Name;
    }
}