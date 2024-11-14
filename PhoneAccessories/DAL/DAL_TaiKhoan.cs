using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TaiKhoan:DBConnection
    {
        public DTO_TaiKhoan getTaiKhoan(string TENDN, string MKHAU)
        {
            DTO_TaiKhoan taiKhoan = null;

            if (ConnectionState.Closed == conn.State)
            { 
                conn.Open();
            }

            string sql = "SELECT * FROM TAIKHOAN " +
                        "WHERE TENDN = @TENDN AND MKHAU = @MKHAU";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TENDN", TENDN);
            cmd.Parameters.AddWithValue("@MKHAU", MKHAU);

            try
            {
                SqlDataReader read = cmd.ExecuteReader();
                if (read.Read())
                {
                    taiKhoan = new DTO_TaiKhoan()
                    {
                        TENDN = read["TENDN"].ToString(),
                        MKHAU = read["MKHAU"].ToString(),
                        MAVT = read["MAVT"].ToString()
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return taiKhoan;
        }
    }
}
