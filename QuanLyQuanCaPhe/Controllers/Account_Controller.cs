using QuanLyQuanCaPhe.DAO;
using QuanLyQuanCaPhe.Entities.Data;
using QuanLyQuanCaPhe.Entities.DataProvider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyQuanCaPhe.Controllers
{
    public class Account_Controller
    {
        DataProvider dataProvider = new DataProvider();

        public Account Get_Account_By_User_Name(string strUser_Name)
        {
            DataTable dt = new DataTable();
            Account objAccount = null;

            try
            {
                dt = dataProvider.ExcuteReader("sp_sel_Get_Account_By_User_Name", strUser_Name);

                if (dt.Rows.Count != 0)
                    objAccount = Utility.Map_Row_To_Entity<Account>(dt.Rows[0]);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            { 
                dt.Dispose();
            }

            return objAccount;

        }

        public void Update_PassWord_Account_By_Id(Account p_objAccount)
        {
            try
            {
                int intResult = dataProvider.ExcuteNonQuery("sp_upd_PassWord_Account_By_Id", p_objAccount.Id, p_objAccount.PassWord);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update_Display_Name_Account_By_Id(Account p_objAccount)
        {
            try
            {
                int intResult = dataProvider.ExcuteNonQuery("sp_upd_Display_Name_Account_By_Id", p_objAccount.Id, p_objAccount.Display_Name);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Account> List_All_User_Account()
        {
            List<Account> arrAccounts = new List<Account>();
            DataTable dataTable = new DataTable();

            try
            {
                dataTable = dataProvider.ExcuteReader("sp_sel_List_All_User_Account");

                foreach (DataRow dr in dataTable.Rows)
                {
                    Account objAccount = Utility.Map_Row_To_Entity<Account>(dr);
                    arrAccounts.Add(objAccount);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dataTable.Dispose();
            }

            return arrAccounts;
        }
    }
}
