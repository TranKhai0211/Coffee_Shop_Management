using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.Entities.Data
{
    public class Food
    {
        private int id;
        private string name;
        private int category_Id;
        private double price;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Category_Id
        {
            get { return category_Id; }
            set { category_Id = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
