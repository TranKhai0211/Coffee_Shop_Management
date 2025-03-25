using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.Entities.Data
{
    public class Bill_Info
    {
        private int id;
        private int bill_Id;
        private int food_Id;
        private int count;
        private string food_Name;
        private double don_Gia;
        private double thanh_Tien;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Bill_Id
        {
            get { return bill_Id; }
            set { bill_Id = value; }
        }

        public int Food_Id
        {
            get { return food_Id; }
            set { food_Id = value; }
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public string Food_Name
        {
            get { return food_Name; }
            set { food_Name = value; }
        }

        public double Don_Gia
        {
            get { return don_Gia; }
            set { don_Gia = value; }
        }

        public double Thanh_Tien
        {
            get { return thanh_Tien; }
            set { thanh_Tien = value; }
        }
    }
}
