using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.Entities.Data
{
    public class Table_Coffee
    {
        private int id;
        private string name;
        private int status;

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

        public int Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
