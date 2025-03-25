using QuanLyQuanCaPhe.Entities.DataProvider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyQuanCaPhe.DAO
{
    public class DataProvider
    {
        private string connectionSTR = "Data Source=MSI\\SQLSERVER;Initial Catalog=QuanLyQuanCafe;Integrated Security=true";

        public DataTable ExcuteQuery(string query)
        {
            // dùng using để giải phóng tài nguyên khi hoàn tất thực thi
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);

                return data;
            }
                
        }

        // Hàm lấy thông tin Store Procedure
        public List<Procedure_Param> Get_Procedure_Param_Info(string strStore_Procedure_Name)
        {
            // Tạo danh sách tham số của store procedure
            List<Procedure_Param> arrPP = new List<Procedure_Param>();

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                conn.Open();
                string query = @"SELECT 
	                                prm.name AS ParameterName,
	                                t.name AS DataType,
	                                prm.max_length
                                FROM sys.procedures p 
                                LEFT JOIN sys.parameters prm ON p.object_id = prm.object_id
                                LEFT JOIN sys.types t ON prm.user_type_id = t.user_type_id
                                WHERE P.name = @ProcedureName";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProcedureName", strStore_Procedure_Name);         // gán tham số cho câu truy vấn

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["ParameterName"].ToString() != "")
                                arrPP.Add(new Procedure_Param(reader["ParameterName"].ToString(), reader["DataType"].ToString()));
                        }
                    }
                }
            }

            return arrPP;
        }

        // Thiết lập tham số cho SqlCommand
        public void SetProcedureParameters(SqlCommand p_cmd, string strProcedureName, params object[] procedureParams)
        {
            List<Procedure_Param> arrProcedure_Param = Get_Procedure_Param_Info(strProcedureName);
            int paramCount = arrProcedure_Param.Count;

            if (procedureParams.Count() != paramCount)
                throw new Exception("Số lượng tham số không tương thích");

            // Truyền các tham số cần thiết cho đối tượng command
            for (int i = 0; i < paramCount; i++)
            {
                p_cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = arrProcedure_Param[i].Name,
                    SqlDbType = arrProcedure_Param[i].DbType,
                    Value = procedureParams[i]
                });
            }

        }

        // Thực thi store để lấy về dữ liệu (Get data)
        public DataTable ExcuteReader(string strProcedureName, params object[] procedureParams)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(strProcedureName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SetProcedureParameters(cmd, strProcedureName, procedureParams);         // Thiết lập tham số cho store procedure

                SqlDataReader reader = cmd.ExecuteReader();                             // Thực thi store

                if (reader.HasRows)
                    dt.Load(reader);

                return dt;
            }
        }


        // Thực thi store để trả về kết quả (số dòng ảnh hưởng): Insert, Delete, Update, ...
        public int ExcuteNonQuery(string strProcedureName, params object[] procedureParams)
        {
            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                conn.Open();
                
                SqlCommand cmd = new SqlCommand(strProcedureName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SetProcedureParameters(cmd, strProcedureName, procedureParams);         // Thiết lập tham số store procedure

                return cmd.ExecuteNonQuery();                                           // Thực thi và trả về kết quả là số dòng ảnh hưởng
            }
        }

    }
}
