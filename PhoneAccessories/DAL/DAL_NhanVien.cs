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
    public class DAL_NhanVien : DBConnection
    {
        public List<DTO_NhanVien> layTatCa()
        {
            List<DTO_NhanVien> lst_nhanvien = new List<DTO_NhanVien>(); 
            if(ConnectionState.Closed == conn.State)
            {
                conn.Open();
            }

            string sql = "SELECT * FROM NHANVIEN ";
            
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    DTO_NhanVien nhanvien = new DTO_NhanVien()
                    {
                        MANV = read[0].ToString(),
                        TENNV = read[1].ToString(),
                        GIOITINH = read[2].ToString(),
                        SDT = read[3].ToString(),
                        NGAYSINH = read.GetDateTime(4),
                        DCNV = read[5].ToString(),    
                        TRANGTHAI = read[6].ToString(),
                        TENDN = read[7].ToString(),
                    };

                    lst_nhanvien.Add(nhanvien);
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

            return lst_nhanvien;
        }

        public DTO_NhanVien layTheoTenDN(string tenDN)
        {
            DTO_NhanVien nhanvien = null;
            if (ConnectionState.Closed == conn.State)
            {
                conn.Open();
            }

            string sql = "Select * From NHANVIEN Where TenDN = @tenDN";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@tenDN", tenDN);
            
            try
            {
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    nhanvien = new DTO_NhanVien()
                    {
                        MANV = read[0].ToString(),
                        TENNV = read[1].ToString(),
                        GIOITINH = read[2].ToString(),
                        SDT = read[3].ToString(),
                        NGAYSINH = read.GetDateTime(4),
                        DCNV = read[5].ToString(),
                        TRANGTHAI = read[6].ToString(),
                        TENDN = read[7].ToString(),
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
            return nhanvien;
        }

        public string layTenNV(string tenDN)
        {
            string tenNV = null;
            if (ConnectionState.Closed == conn.State)
            {
                conn.Open();
            }
            string sql = "Select TENNV From NHANVIEN Where TENDN = @TENDN";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TENDN", tenDN);

            try
            {
                SqlDataReader read = cmd.ExecuteReader();
                if (read.Read())
                    tenNV = read["TENNV"].ToString();
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
