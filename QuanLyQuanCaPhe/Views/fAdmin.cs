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

            LoadAccountList();
        }


        #region Events
        private void button18_Click(object sender, EventArgs e)
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

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadDoanhThu(dtpFrom_Date.Value, dtpTo_Date.Value);
        }

        private void btnAdd_Account_Click(object sender, EventArgs e)
        {

        }
    }
}
