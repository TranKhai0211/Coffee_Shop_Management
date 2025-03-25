using QuanLyQuanCaPhe.Controllers;
using QuanLyQuanCaPhe.Entities.Data;
using QuanLyQuanCaPhe.Entities.DataProvider;
using QuanLyQuanCaPhe.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCaPhe
{
    public partial class fTableManagement : Form
    {
        private Account account;

        public fTableManagement(Account account)
        {
            this.account = account;
            InitializeComponent();

            if (account.Type_Id != (int) Account_Type.Admin)
            {
                adminToolStripMenuItem.Visible = false;
            }

            LoadData();

            LoadCategory();

            Load_ComboBox_Table_Coffee();
        }

        public void LoadData()
        {
            Table_Coffee_Controller objCtrlTableCoffee = new Table_Coffee_Controller();
            List<Table_Coffee> arrTable_Coffee = objCtrlTableCoffee.List_Table_Coffee();

            flpTableManager.Controls.Clear();

            foreach (Table_Coffee obj in arrTable_Coffee)
            {
                string strStatusName = obj.Name;
                switch (obj.Status)
                {
                    case (int)Table_Status.Trong: strStatusName += "\n Trống"; break;
                    case (int)Table_Status.Co_Nguoi: strStatusName += "\n Có người"; break;
                }

                Button btnTable = new Button()
                {
                    Width = 200,
                    Height = 100,
                    Text = strStatusName,
                    BackColor = obj.Status == 0 ? Color.Cyan : Color.Yellow,
                    ForeColor = Color.Black,
                    Tag = obj.Id
                };

                btnTable.Click += btnTable_Click;

                flpTableManager.Controls.Add(btnTable);
            }


        }

        #region Events

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fAdmin fam = new fAdmin();
            fam.ShowDialog();
        }

        private void PersonallnfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountInfo fai = new fAccountInfo(account);
            fai.ShowDialog();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {

            // Lấy Id bàn từ Tag của button.
            Button btnTable = (Button)sender;
            int intTable_Id = (int)btnTable.Tag;

            Load_Bill(intTable_Id);

            Table_Coffee_Controller objCtrlTC_Controller = new Table_Coffee_Controller();
            txtTable_Name.Text = objCtrlTC_Controller.Get_Table_Coffee_By_Id(intTable_Id).Name;
        }

        private void cbFoodCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbFood_Category = (ComboBox)sender;

            if (cbFood_Category == null) return;

            Food_Category fcSelected = (Food_Category)cbFoodCategory.SelectedItem;

            LoadFoodByCategoryId(fcSelected.Id);
        }

        private void btnThem_Mon_Click(object sender, EventArgs e)
        {
            int intTable_Id = (int)lstBill.Tag;

            // Kiểm tra số bàn hiện có bill hay không để thực hiện Insert / Update tương ứng
            Bill_Controller objCtrlBill_Controller = new Bill_Controller();
            Bill objBill = objCtrlBill_Controller.Get_Bill_By_Table_Id_With_Unchecked(intTable_Id);

            if (objBill.Id == 0)
            {
                // Tạo bill mới
                Bill objNew = new Bill();
                objNew.Table_Id = intTable_Id;
                objNew.CheckIn_Time = DateTime.Now;
                objNew.Status_Id = (int)Bill_Status.Chua_Thanh_Toan;

                objCtrlBill_Controller.Insert_Bill(objNew);

                // Lấy dữ liệu bill vừa tạo 
                Bill objNewBill = objCtrlBill_Controller.Get_Bill_By_Table_Id_With_Unchecked(intTable_Id);

                Insert_Bill_Info_From_Form(objNewBill.Id);

                // Cập nhật lại list table 
                Table_Coffee_Controller objTCC = new Table_Coffee_Controller();
                objTCC.Update_Table_Coffee_Status(intTable_Id, (int)Table_Status.Co_Nguoi);

                LoadData();
            }
            else
            {
                Insert_Bill_Info_From_Form(objBill.Id);
            }


            Load_Bill(intTable_Id);

            Load_ComboBox_Table_Coffee();
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            // Lấy giá trị ô discount và tính toán lại tổng tiền.
            double dblDiscount = (double)nudDiscount.Value;
            int intTable_Id = (int)lstBill.Tag;

            // Get_Bill_By_Table_Id_With_Unchecked
            Bill_Controller objCtrlBill = new Bill_Controller();
            Bill objBill = objCtrlBill.Get_Bill_By_Table_Id_With_Unchecked(intTable_Id);

            // Get_Bill_Info_By_Bill_Id
            Bill_Info_Controller objCtrlBillInfo = new Bill_Info_Controller();
            List<Bill_Info> arrBill_Info = objCtrlBillInfo.List_Bill_Info_By_Bill_Id(objBill.Id);

            double dblTotalPrice = 0;

            // Đưa dữ liệu vào listView để hiển thị bill
            foreach (Bill_Info obj in arrBill_Info)
            {
                dblTotalPrice += obj.Thanh_Tien;
            }

            double dblDiscount_Price = dblTotalPrice - (dblTotalPrice * dblDiscount) / 100;
            txbTotalPrice.Text = Utility.Convert_To_String(dblDiscount_Price, (int)String_Formatter.Currency_US);
        }

        private void btnThanh_Toan_Click(object sender, EventArgs e)
        {
            int intTable_Id = (int)lstBill.Tag;

            Table_Coffee_Controller objCtrlTCC = new Table_Coffee_Controller();
            Table_Coffee objTable_Coffee = objCtrlTCC.Get_Table_Coffee_By_Id(intTable_Id);

            string strMessage = "Bạn có muốn thanh toán cho " + objTable_Coffee.Name + "\n Số tiền: " + txbTotalPrice.Text;

            // Hiện thông báo 
            if (MessageBox.Show(strMessage, "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                // Cập nhật Discount, total Price và trạng thái của bill
                Bill_Controller objCtrlBill = new Bill_Controller();
                Bill objBill = objCtrlBill.Get_Bill_By_Table_Id_With_Unchecked(intTable_Id);

                objBill.Discount = Convert.ToInt32(nudDiscount.Value);
                objBill.Total_Price = Convert.ToDouble(txbTotalPrice.Text);
                objBill.Status_Id = (int)Bill_Status.Da_Thanh_Toan;
                objCtrlBill.Update_Bill_To_Check(objBill);

                // Chuyển trạng thái table
                objCtrlTCC.Update_Table_Coffee_Status(intTable_Id, (int)Table_Status.Trong);

                // Load lại view Table
                LoadData();

                // Loại lại Bill
                Load_Bill(intTable_Id);
            }
        }
        #endregion


        #region Handler Functions
        private void LoadCategory()
        {
            Food_Category_Controller objCtrlFC = new Food_Category_Controller();
            List<Food_Category> arrFood_Category = objCtrlFC.List_Category();

            cbFoodCategory.DataSource = arrFood_Category;
            cbFoodCategory.DisplayMember = "Name";
            cbFoodCategory.SelectedIndexChanged += cbFoodCategory_SelectedIndexChanged;
        }

        private void LoadFoodByCategoryId(int p_CategoryId)
        {
            Food_Controller objCtrlFood = new Food_Controller();
            List<Food> arrFood = objCtrlFood.List_Food_By_Category_Id(p_CategoryId);

            cbFood.DataSource = arrFood;
            cbFood.DisplayMember = "Name";
        }

        private void Load_Bill(int p_Table_Id)
        {
            lstBill.Items.Clear();
            lstBill.Tag = p_Table_Id;

            // Get_Bill_By_Table_Id_With_Unchecked
            Bill_Controller objCtrlBill = new Bill_Controller();
            Bill objBill = objCtrlBill.Get_Bill_By_Table_Id_With_Unchecked(p_Table_Id);

            // Get_Bill_Info_By_Bill_Id
            Bill_Info_Controller objCtrlBillInfo = new Bill_Info_Controller();
            List<Bill_Info> arrBill_Info = objCtrlBillInfo.List_Bill_Info_By_Bill_Id(objBill.Id);

            double dblTotalPrice = 0;

            // Đưa dữ liệu vào listView để hiển thị bill
            foreach (Bill_Info obj in arrBill_Info)
            {
                ListViewItem lvItem = new ListViewItem(obj.Food_Name);
                lvItem.SubItems.Add(obj.Count.ToString());
                lvItem.SubItems.Add(Utility.Convert_To_String(obj.Don_Gia, (int)String_Formatter.Currency_US));
                lvItem.SubItems.Add(Utility.Convert_To_String(obj.Thanh_Tien, (int)String_Formatter.Currency_US));
                lstBill.Items.Add(lvItem);

                dblTotalPrice += obj.Thanh_Tien;
            }

            // Hiển thị tổng số tiền
            txbTotalPrice.Text = Utility.Convert_To_String(dblTotalPrice, (int)String_Formatter.Currency_US);
        }

        private void Insert_Bill_Info_From_Form(int p_Bill_Id)
        {
            Bill_Info_Controller objCtrlBill_Info_Controller = new Bill_Info_Controller();
            Bill_Info objNew_Bill_Info = new Bill_Info();
            objNew_Bill_Info.Bill_Id = p_Bill_Id;
            objNew_Bill_Info.Food_Id = (cbFood.SelectedItem as Food).Id;
            objNew_Bill_Info.Count = Convert.ToInt32(nudCount.Value);

            objCtrlBill_Info_Controller.Insert_Bill_Info(objNew_Bill_Info);
        }

        private void Load_ComboBox_Table_Coffee()
        {
            Table_Coffee_Controller objCtrlTCC = new Table_Coffee_Controller();
            List<Table_Coffee> arrTable_Coffee = objCtrlTCC.List_Table_Coffee();

            cbList_Table.DataSource = arrTable_Coffee;
            cbList_Table.DisplayMember = "Name";
        }

        #endregion


        private void btnChange_Table_Click(object sender, EventArgs e)
        {
            // Kiểm tra bàn cần chuyển đến có trống hay không
            Table_Coffee_Controller objCtrlTCC = new Table_Coffee_Controller();
            Table_Coffee objOld_Table = objCtrlTCC.Get_Table_Coffee_By_Id((int) lstBill.Tag);
            Table_Coffee objNew_Table = (Table_Coffee) cbList_Table.SelectedItem;

            if (objNew_Table.Id == objOld_Table.Id) 
            {
                MessageBox.Show("Đây là cùng một bàn."); return;
            }
            
            if (objNew_Table.Status == (int)Table_Status.Co_Nguoi)
            {
                MessageBox.Show(objNew_Table.Name + " hiện đang có người.");
                return;
            } 
            else
            {
                if (MessageBox.Show("Bạn muốn chuyển từ bàn " + objOld_Table.Name + " sang bàn " + objNew_Table.Name + " ?", "thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    // Nếu trống thì lấy New_Table_Id gán vào Table_Id của bill unchecked where Table_Id = Old_Table_Id
                    Bill_Controller objCtrlBill = new Bill_Controller();
                    objCtrlBill.Update_Bill_To_Change_Table(objNew_Table.Id, objOld_Table.Id);

                    // Update Status Table
                    objCtrlTCC.Update_Table_Coffee_Status(objNew_Table.Id, (int) Table_Status.Co_Nguoi);
                    objCtrlTCC.Update_Table_Coffee_Status(objOld_Table.Id, (int) Table_Status.Trong);
                }

            }


            // LoadData
            LoadData();

            // LoadBill
            Load_Bill((int) lstBill.Tag);
        }
    }
}
