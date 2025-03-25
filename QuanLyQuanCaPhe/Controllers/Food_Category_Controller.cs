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
    public class Food_Category_Controller
    {
        DataProvider dataProvider = new DataProvider();

        public List<Food_Category> List_Category()
        {
            List<Food_Category> arrFood_Category = new List<Food_Category>();
            DataTable dt = new DataTable();

            try
            {
                dt = dataProvider.ExcuteReader("sp_sel_List_Category");

                foreach (DataRow row in dt.Rows)
                {
                    Food_Category objFood_Category = Utility.Map_Row_To_Entity<Food_Category>(row);

                    arrFood_Category.Add(objFood_Category);
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

            return arrFood_Category;
        }
    }
}
