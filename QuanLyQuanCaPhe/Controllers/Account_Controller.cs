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
    }
}
