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
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string sql = "SELECT TENDN, MKHAU, MAVT FROM TAIKHOAN WHERE TENDN = @TENDN AND MKHAU = @MKHAU";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@TENDN", TENDN);
                    cmd.Parameters.AddWithValue("@MKHAU", MKHAU);

                    using (SqlDataReader read = cmd.ExecuteReader())
                    {
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
                }
            }
            catch (SqlException sqlEx)
            {
                throw new Exception("Lỗi cơ sở dữ liệu: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khác: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return taiKhoan;
        }
    }
}
