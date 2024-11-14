using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_NhanVien
    {
        DAL_NhanVien nhanvienDAL;

        public BLL_NhanVien()
        {
            nhanvienDAL = new DAL_NhanVien();
        }

        public List<DTO_NhanVien> layTatCa()
        {
            return nhanvienDAL.layTatCa();
        }

        public DTO_NhanVien layTheoTenDN(string tenDN)
        {
            return nhanvienDAL.layTheoTenDN(tenDN);
        }

        public string layTenNV(string tenDN)
        {
            return nhanvienDAL.layTenNV(tenDN);
        }
    }
}
