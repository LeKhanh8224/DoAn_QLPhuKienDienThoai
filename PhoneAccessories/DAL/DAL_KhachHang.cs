using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KhachHang : DBConnection
    {
        public List<DTO_KhachHang> layTatCa()
        {
            List<DTO_KhachHang> lst_khachHang = new List<DTO_KhachHang>();
            if (ConnectionState.Closed == conn.State)
            {
                conn.Open();
            }

            string sql = "SELECT * FROM KHACHHANG ";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    DTO_KhachHang khachHang = new DTO_KhachHang()
                    {
                        MAKH = read[0].ToString(),
                        TENKH = read[1].ToString(),
                        GIOITINH = read[2].ToString(),
                        SDT = read[3].ToString(),
                    };

                    lst_khachHang.Add(khachHang);
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

            return lst_khachHang;
        }

        public DTO_KhachHang layTheoTenDN(string tenDN)
        {
            DTO_KhachHang khachhang = null;
            if (ConnectionState.Closed == conn.State)
            {
                conn.Open();
            }

            string sql = "Select * From KHACHHANG Where TENDN = @TENDN";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TENDN", tenDN);

            try
            {
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    khachhang = new DTO_KhachHang()
                    {
                        MAKH = read[0].ToString(),
                        TENKH = read[1].ToString(),
                        GIOITINH = read[2].ToString(),
                        SDT = read[3].ToString(),
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

            return khachhang;
        }

        public string layTenKH(string tenDN)
        {
            string tenNV = null;
            if (ConnectionState.Closed == conn.State)
            {
                conn.Open();
            }
            string sql = "Select TENKH From KHACHHANG Where TENDN = @TENDN";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TENDN", tenDN);

            try
            {
                SqlDataReader read = cmd.ExecuteReader();
                if (read.Read())
                    tenNV = read["TENKH"].ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return tenNV;
        }
    }
}
