using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_KhachHang
    {
        DAL_KhachHang khachHangDAL;

        public BLL_KhachHang()
        {
            khachHangDAL = new DAL_KhachHang();
        }

        public List<DTO_KhachHang> layTatCa()
        {
            return khachHangDAL.layTatCa();
        }

        public DTO_KhachHang layTheoTenDN(string tenDN)
        {
            return khachHangDAL.layTheoTenDN(tenDN);
        }

        public string layTenKH(string tenDN)
        {
            return khachHangDAL.layTenKH(tenDN);
        }
    }
}
