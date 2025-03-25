using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.Utilities
{
    public enum Table_Status
    {
        Trong = 0,
        Co_Nguoi = 1
    }

    public enum Bill_Status
    {
        Chua_Thanh_Toan = 0,
        Da_Thanh_Toan = 1
    }

    public enum String_Formatter
    {
        // Currency Formatter
        Currency_Vn = 0,
        Currency_US = 1
    }

    public enum Account_Type
    {
        Admin = 0,
        Employee = 1
    }
}
