using BCrypt.Net;
using QuanLyQuanCaPhe.Controllers;
using QuanLyQuanCaPhe.DAO;
using QuanLyQuanCaPhe.Entities.Data;
using System.Data;

namespace QuanLyQuanCaPhe
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();

            LoadData();
        }

        public void LoadData()
        {

        }

        #region Events
        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            if (userName == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.");
                return;
            }

            string passWord = txtPassWord.Text;
            if (passWord == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.");
                return;
            }

            if (Login(userName, passWord))
            {
                Account_Controller objCtrlAccount = new Account_Controller();
                Account objAccount = objCtrlAccount.Get_Account_By_User_Name(userName);

                fTableManagement ftm = new fTableManagement(objAccount);
                this.Hide();
                ftm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }

        }
        #endregion


        #region Handler Functions
        public bool Login(string userName, string passWord)
        {
            Account_Controller ctrlAccount = new Account_Controller();
            Account objAccount = ctrlAccount.Get_Account_By_User_Name(userName);

            if (objAccount == null)
                return false;

            if (BCrypt.Net.BCrypt.Verify(passWord, objAccount.PassWord))
                return true;
            else
                return false;

        }
        #endregion

    }
}
