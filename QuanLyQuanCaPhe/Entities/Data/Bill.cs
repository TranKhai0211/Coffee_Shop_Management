using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.Entities.Data
{
    public class Bill
    {
        private int id;
        private DateTime checkIn_Time;
        private DateTime checkOut_Time;
        private int table_Id;
        private int status_Id;
        private double discount;
        private double total_Price;
        private string table_Name;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime CheckIn_Time
        {
            get { return checkIn_Time; }
            set { checkIn_Time = value; }
        }

        public DateTime CheckOut_Time
        {
            get { return checkOut_Time; }
            set { checkOut_Time = value; }
        }

        public int Table_Id
        {
            get { return table_Id; }
            set { table_Id = value; }
        }

        public int Status_Id
        {
            get { return status_Id; }
            set { status_Id = value; }
        }

        public double Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        public double Total_Price
        {
            get { return total_Price; }
            set { total_Price = value; }
        }

        public string Table_Name
        {
            get { return table_Name; }
            set { table_Name = value; }
        }
    }
}
