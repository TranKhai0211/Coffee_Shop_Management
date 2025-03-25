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
    public class Bill_Controller
    {
        DataProvider dataProvider = new DataProvider();

        public Bill Get_Bill_By_Table_Id_With_Unchecked(int p_Table_Id)
        {
            Bill objBill = new Bill();

            DataTable dt = new DataTable();

            try
            {
                dt = dataProvider.ExcuteReader("sp_sel_Get_Bill_By_Table_Id_With_Unchecked", p_Table_Id);
                
                if (dt.Rows.Count != 0)
                    objBill = Utility.Map_Row_To_Entity<Bill>(dt.Rows[0]);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dt.Dispose();
            }

            return objBill;
        }

        public void Insert_Bill(Bill p_objBill)
        {
            try
            {
                int intResult = dataProvider.ExcuteNonQuery("sp_ins_Bill", p_objBill.CheckIn_Time, p_objBill.Table_Id, p_objBill.Status_Id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update_Bill_To_Check(Bill p_objBill)
        {
            try
            {
                int intResult = dataProvider.ExcuteNonQuery("sp_upd_Bill_To_Check_By_Table_Id", p_objBill.Table_Id, p_objBill.Discount, p_objBill.Total_Price, p_objBill.Status_Id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update_Bill_To_Change_Table(int p_New_Table_Id, int p_Old_Table_Id)
        {
            try
            {
                int intResult = dataProvider.ExcuteNonQuery("sp_upd_Bill_Change_Table_Id", p_New_Table_Id, p_Old_Table_Id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Bill> List_Doanh_Thu_From_Date_To_Date(DateTime p_From_Date, DateTime p_To_Date)
        {
            List<Bill> arr_Bill = new List<Bill>();
            DataTable dt = new DataTable(); 

            try
            {
                dt = dataProvider.ExcuteReader("sp_sel_List_Doanh_Thu_From_Date_To_Date", p_From_Date, p_To_Date);

                foreach (DataRow dr in dt.Rows)
                {
                    Bill objBill = Utility.Map_Row_To_Entity<Bill>(dr);
                    arr_Bill.Add(objBill);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dt.Dispose();
            }
            
            return arr_Bill;
        }

    }
}
