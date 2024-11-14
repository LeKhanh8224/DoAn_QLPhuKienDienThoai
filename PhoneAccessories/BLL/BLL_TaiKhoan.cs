using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_TaiKhoan
    {
        DAL_TaiKhoan taiKhoanDAL = new DAL_TaiKhoan();
        public DTO_TaiKhoan Login(string TENDN, string MKHAU)
        {
            DTO_TaiKhoan taiKhoan = taiKhoanDAL.getTaiKhoan(TENDN, MKHAU);
            if (taiKhoan != null)
            {
                return taiKhoan;
            }
            return null;
        }
    }
}
