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
    public partial class fAccountInfo : Form
    {
        private Account objAccount;

        public fAccountInfo(Account objAcc)
        {
            objAccount = objAcc;

            InitializeComponent();

            LoadData();
        }

        public void LoadData()
        {
            txbUserName.Text = objAccount.User_Name;
            txbDisplayName.Text = objAccount.Display_Name;
        }

        #region Events
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


        #region Handler Functions
        #endregion

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string strNew_PassWord = txbNew_PassWord.Text;
            string strReType_PassWord = txbReType_PassWord.Text;

            if (strNew_PassWord == "")
            {
                // Cập nhật Password
            } else
            {
                // Cập nhật tên hiển thị
            }
        }
    }
}
