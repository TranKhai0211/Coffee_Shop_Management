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
    
    public class Bill_Info_Controller
    {
        DataProvider dataProvider = new DataProvider();

        public List<Bill_Info> List_Bill_Info_By_Bill_Id(int p_intBill_Id)
        {
            List<Bill_Info> arrBill_Info = new List<Bill_Info>();
            DataTable dt = new DataTable();

            try
            {
                dt = dataProvider.ExcuteReader("sp_sel_List_Bill_Info_By_Bill_Id", p_intBill_Id);

                foreach (DataRow dr in dt.Rows)
                {
                    Bill_Info objBill_Info = Utility.Map_Row_To_Entity<Bill_Info>(dr);
                    arrBill_Info.Add(objBill_Info);
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

            return arrBill_Info;

        }

        public void Insert_Bill_Info(Bill_Info p_objBill_Info)
        {
            try
            {
                int intResult = dataProvider.ExcuteNonQuery("sp_ins_Bill_Info", p_objBill_Info.Bill_Id, p_objBill_Info.Food_Id, p_objBill_Info.Count);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
