using QuanLyQuanCaPhe.DAO;
using QuanLyQuanCaPhe.Entities.Data;
using QuanLyQuanCaPhe.Entities.DataProvider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.Controllers
{
    public class Table_Coffee_Controller
    {
        DataProvider dataProvider = new DataProvider();

        public List<Table_Coffee> List_Table_Coffee()
        {
            List<Table_Coffee> arrRet = new List<Table_Coffee>();
            DataTable data = new DataTable();

            try
            {
                data = dataProvider.ExcuteReader("sp_sel_List_Table_Coffee");

                foreach (DataRow row in data.Rows)
                {
                    Table_Coffee objRet = Utility.Map_Row_To_Entity<Table_Coffee>(row);
                    arrRet.Add(objRet);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                data.Dispose();
            }

            return arrRet;
        }

        public Table_Coffee Get_Table_Coffee_By_Id(int p_Table_Coffee_Id)
        {
            DataTable data = new DataTable();
            Table_Coffee objRet = new Table_Coffee();

            try
            {
                data = dataProvider.ExcuteReader("sp_sel_Get_Table_Coffee_By_Id", p_Table_Coffee_Id);

                objRet = Utility.Map_Row_To_Entity<Table_Coffee>(data.Rows[0]);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                data.Dispose();
            }

            return objRet;
        }

        public void Update_Table_Coffee_Status(int p_Table_Id, int p_Table_Status_Id)
        {
            try
            {
                int intResult = dataProvider.ExcuteNonQuery("sp_upd_Status_Table_Coffee_By_Id", p_Table_Id, p_Table_Status_Id);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }

   
}
