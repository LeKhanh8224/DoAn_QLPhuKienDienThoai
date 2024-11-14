using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhanVien
    {
        public string MANV { get; set; }
        public string TENNV { get; set; }
        public string GIOITINH { get; set; }
        public string SDT { get; set; }
        public DateTime NGAYSINH { get; set; }
        public string DCNV { get; set; }
        public string TRANGTHAI { get; set; }
        public string TENDN { get; set; }

        public DTO_NhanVien()
        {

        }

        public DTO_NhanVien(string _MANV, string _TENNV, string _GIOITINH, string _SDT, DateTime _NGAYSINH, string _DCNV, string _TRANGTHAI, string _TENDN)
        {
            MANV = _MANV;
            TENNV = _TENNV;
            GIOITINH = _GIOITINH;
            SDT = _SDT;
            NGAYSINH = _NGAYSINH;
            DCNV = _DCNV;
            TRANGTHAI = _TRANGTHAI;
            TENDN = _TENDN;
        }
    }
}
