using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.Entities.DataProvider
{
    public class Procedure_Param
    {
        private string name;
        private string typeName;

        public Procedure_Param(string name, string type)
        {
            this.Name = name;
            this.Type_Name = type;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Type_Name
        {
            get { return typeName; }
            set { typeName = value; }
        }

        public SqlDbType DbType
        {
            get
            {
                SqlDbType ret;
                switch(this.Type_Name)
                {
                    case "": ret = SqlDbType.NVarChar; break;
                    default: ret = SqlDbType.NVarChar; break;
                }

                return ret; 
            }
        }
    }
}
