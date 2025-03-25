using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.Entities.Data
{
    public class Account
    {
        private int id;
        private string displayName;
        private string userName;
        private string passWord;
        private int typeId;

        public int ID
        {
            get { return id; }
        }

        public string Display_Name
        {
            get { return displayName; }
            set { displayName = value; }
        }

        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }

        public string User_Name
        {
            get { return userName; }
            set { userName = value; }
        }

        public int Type_Id
        {
            get { return typeId; }
            set { typeId = value; }
        }
    }
}
