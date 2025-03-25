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
    public class Food_Controller
    {
        DataProvider dataProvider = new DataProvider();

        public List<Food> List_Food_By_Category_Id(int p_Category_Id)
        {
            List<Food> arrFood = new List<Food>();
            DataTable dt = new DataTable();

            try
            {
                dt = dataProvider.ExcuteReader("sp_sel_List_Food_By_Category_Id", p_Category_Id);

                foreach (DataRow dr in dt.Rows)
                {
                    Food objFood = Utility.Map_Row_To_Entity<Food>(dr);
                    arrFood.Add(objFood);
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

            return arrFood;
        }
    }
}
