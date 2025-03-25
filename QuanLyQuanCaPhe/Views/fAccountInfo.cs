using BCrypt.Net;
using QuanLyQuanCaPhe.Controllers;
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
            txbPassWord.Text = "";
            txbNew_PassWord.Text = "";
            txbReType_PassWord.Text = "";
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
            string strPassWord = txbPassWord.Text.Trim();
            string strNew_PassWord = txbNew_PassWord.Text.Trim();
            string strReType_PassWord = txbReType_PassWord.Text.Trim();

            Account_Controller objCtrl_Account = new Account_Controller();

            if (strNew_PassWord != "")
            {
                // Cập nhật Password

                // Kiểm tra mật khẩu hiện tại
                if (BCrypt.Net.BCrypt.Verify(strPassWord, objAccount.PassWord))
                {
                    // Kiểm tra mật khẩu mới và mật khẩu nhập lại
                    if (strNew_PassWord == strReType_PassWord)
                    {
                        objAccount.PassWord = BCrypt.Net.BCrypt.HashPassword(strNew_PassWord);
                        objCtrl_Account.Update_PassWord_Account_By_Id(objAccount);

                        MessageBox.Show("Đổi mật khẩu thành công !");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập lại mật khẩu khớp với mật khẩu mới.");
                    }
                } 
                else
                {
                    MessageBox.Show("Sai mật khẩu xác thực!");
                }


            } else
            {
                // Cập nhật tên hiển thị dựa theo tên đăng nhập

                // Xác thực mật khẩu trước khi thay đổi
                if (BCrypt.Net.BCrypt.Verify(strPassWord, objAccount.PassWord))
                {
                    objAccount.Display_Name = txbDisplayName.Text;
                    objCtrl_Account.Update_Display_Name_Account_By_Id(objAccount);

                    MessageBox.Show("Cập nhật tên hiển thị thành công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu xác thực!");
                }
            }
        }
    }
}
