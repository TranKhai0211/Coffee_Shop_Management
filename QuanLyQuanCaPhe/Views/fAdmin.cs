using QuanLyQuanCaPhe.Controllers;
using QuanLyQuanCaPhe.DAO;
using QuanLyQuanCaPhe.Entities.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCaPhe
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();

            LoadData();
        }

        public void LoadData()
        {
            #region form_Doanh_Thu

            DateTime now = DateTime.Now;
            int intCurrent_Year = now.Year;
            int intCurrent_Month = now.Month;

            // Ngày đầu tháng
            DateTime firstDate = new DateTime(intCurrent_Year, intCurrent_Month, 1);

            // Ngày cuối tháng
            DateTime lastDate = new DateTime(intCurrent_Year, intCurrent_Month, DateTime.DaysInMonth(intCurrent_Year, intCurrent_Month));

            // Gán dữ liệu DateTime Picker
            dtpFrom_Date.Value = firstDate;
            dtpTo_Date.Value = lastDate;

            LoadDoanhThu(firstDate, lastDate);

            #endregion


            #region form_Thuc_An
            #endregion


            #region form_Danh_Muc
            #endregion


            #region form_Ban_An
            #endregion


            #region form_Tai_Khoan

            LoadAccountList();

            // Thiết lập tooltip cho button reset mật khẩu
            toolTipResetPassword.SetToolTip(btnReset_PassWord, "Thiết lập password về mật khẩu mặc định: 1");
            toolTipResetPassword.AutoPopDelay = 5000;
            toolTipResetPassword.InitialDelay = 500;

            // List User to dataGridView
            dtgvListUser.AutoGenerateColumns = false;

            dtgvListUser.Columns.Clear();
            dtgvListUser.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", DataPropertyName = "Id", HeaderText = "Id" });
            dtgvListUser.Columns.Add(new DataGridViewTextBoxColumn { Name = "User_Name", DataPropertyName = "User_Name", HeaderText = "User Name" });
            dtgvListUser.Columns.Add(new DataGridViewTextBoxColumn { Name = "Display_Name", DataPropertyName = "Display_Name", HeaderText = "Display Name" });
            dtgvListUser.Columns.Add(new DataGridViewTextBoxColumn { Name = "Type", DataPropertyName = "Type_Text", HeaderText = "Type" });

            Account_Controller objCtrl_Account = new Account_Controller();
            dtgvListUser.DataSource = objCtrl_Account.List_All_User_Account();

            #endregion

        }


        #region Events

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadDoanhThu(dtpFrom_Date.Value, dtpTo_Date.Value);
        }

        private void btnAdd_Account_Click(object sender, EventArgs e)
        {

        }

        #endregion


        #region Handler Functions
        public void LoadAccountList()
        {

        }

        public void LoadDoanhThu(DateTime p_FromDate, DateTime p_ToDate)
        {
            lstDoanh_thu.Items.Clear();

            Bill_Controller objCtrlBill = new Bill_Controller();
            List<Bill> arrBill = objCtrlBill.List_Doanh_Thu_From_Date_To_Date(p_FromDate, p_ToDate);

            // Đưa dữ liệu vào list view
            foreach (Bill objBill in arrBill)
            {
                ListViewItem item = new ListViewItem(objBill.Id.ToString());
                item.SubItems.Add(objBill.Table_Name);
                item.SubItems.Add(objBill.CheckIn_Time.ToString());
                item.SubItems.Add(objBill.CheckOut_Time.ToString());
                item.SubItems.Add(objBill.Discount.ToString());
                item.SubItems.Add(objBill.Total_Price.ToString());

                lstDoanh_thu.Items.Add(item);
            }
        }
        #endregion


        private void dtgvListUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)                 // Đảm bảo không click vào tiêu đề cột
            {
                DataGridViewRow row = dtgvListUser.Rows[e.RowIndex];

                // Lấy thông tin record từ dataGridView
                int intId = Convert.ToInt32(row.Cells["Id"].Value.ToString());
                string strUser_Name = row.Cells["User_Name"].Value.ToString();
                string strDisplay_Name = row.Cells["Display_Name"].Value.ToString();

                // Gán vào các textBox tương ứng
                txbId.Text = intId.ToString();
                txbUerName.Text = strUser_Name;
                txbDisplay_Name.Text = strDisplay_Name;
            }
        }
    }
}
