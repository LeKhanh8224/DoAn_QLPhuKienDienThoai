﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhachHang
    {
        public string MAKH { get; set; }
        public string TENKH { get; set; }
        public string GIOITINH { get; set; }
        public string SDT { get; set; }

        public DTO_KhachHang() { }

        public DTO_KhachHang(string mAKH, string tENKH, string gIOITINH, string sDT)
        {
            MAKH = mAKH;
            TENKH = tENKH;
            GIOITINH = gIOITINH;
            SDT = sDT;
        }
    }
}
