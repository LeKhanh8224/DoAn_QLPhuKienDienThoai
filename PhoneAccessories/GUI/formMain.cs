using BLL;
using DTO;
using GUI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class formMain : Form
    {
        public formMain(string vaiTro, string tenDN)
        {
            InitializeComponent();
            if (vaiTro.Trim().Equals("admin"))
            {
                UC_TrangChu uc = new UC_TrangChu();
                add_uc(uc);
                lbl_title.Text = "Trang Chủ";
                lbl_nguoidung.Text = "Administrator";
            } 
            else if (vaiTro.Trim().Equals("VT001")) //Nếu là nhân viên quản lí nhân sự
            {
                UC_TrangChu uc = new UC_TrangChu();
                add_uc(uc);
                lbl_title.Text = "Trang Chủ";
                BLL_NhanVien nvX = new BLL_NhanVien();
                lbl_nguoidung.Text = "Nhân Viên\n" + nvX.layTenNV(tenDN);
                //Hiện Nhân sự 
                btn_nhanSu.Location = btn_khoHang.Location;
                btn_khoHang.Visible = false;
                btn_hoaDon.Visible = false;
                btn_phieuNhap.Visible = false;
                btn_ThongKe.Visible = false;

            }
            else if (vaiTro.Trim().Equals("VT002")) //Nếu là nhân viên kho
            {
                UC_TrangChu uc = new UC_TrangChu();
                add_uc(uc);
                lbl_title.Text = "Trang Chủ";
                BLL_NhanVien nvX = new BLL_NhanVien();
                lbl_nguoidung.Text = "Nhân Viên\n" + nvX.layTenNV(tenDN);
                //Hiện Kho hàng
                btn_nhanSu.Visible = false;
                btn_hoaDon.Visible = false;
                btn_phieuNhap.Visible = false;
                btn_ThongKe.Visible = false;
            }
            else if (vaiTro.Trim().Equals("VT003")) //Nếu là nhân viên kế toán
            {
                UC_TrangChu uc = new UC_TrangChu();
                add_uc(uc);
                lbl_title.Text = "Trang Chủ";
                BLL_NhanVien nvX = new BLL_NhanVien();
                lbl_nguoidung.Text = "Nhân Viên\n" + nvX.layTenNV(tenDN);
                //Hiện Hóa đơn và Phiếu nhập
                btn_hoaDon.Location = btn_khoHang.Location;
                btn_phieuNhap.Location = btn_nhanSu.Location;
                btn_khoHang.Visible = false;
                btn_nhanSu.Visible = false;
                btn_ThongKe.Visible = false;
            }
            else if (vaiTro.Trim().Equals("VT004")) //Nếu là nhân viên báo cáo tài chính
            {
                UC_TrangChu uc = new UC_TrangChu();
                add_uc(uc);
                lbl_title.Text = "Trang Chủ";
                BLL_NhanVien nvX = new BLL_NhanVien();
                lbl_nguoidung.Text = "Nhân Viên\n" + nvX.layTenNV(tenDN);
                //Hiện Thống kê
                btn_ThongKe.Location = btn_khoHang.Location;
                btn_khoHang.Visible = false;
                btn_nhanSu.Visible = false;
                btn_hoaDon.Visible = false;
                btn_phieuNhap.Visible = false;
            }
            else //Nếu là khách tham quan
            {
                UC_TrangChu uc = new UC_TrangChu();
                add_uc(uc);
                lbl_title.Text = "Trang Chủ";
                lbl_nguoidung.Text = "Khách Hàng\nVãng Lai";
                btn_dangxuat.Text = "Đăng Nhập";
                //Hiện mỗi trang chủ
                btn_profile.Visible = false;
                btn_khoHang.Visible = false;
                btn_nhanSu.Visible = false;
                btn_hoaDon.Visible = false;
                btn_phieuNhap.Visible = false;
                btn_ThongKe.Visible = false;
            }
        }

        public void add_uc(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(uc);
            uc.BringToFront();
        }

        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
            else
                Application.ExitThread();
        }

        bool isLogout = false;
        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            isLogout = true;
            this.Hide();
            formDangNhap frmdn = new formDangNhap();
            frmdn.ShowDialog();
            this.Show();
        }

        private void btn_trangChu_Click(object sender, EventArgs e)
        {
            UC_TrangChu uc = new UC_TrangChu();
            add_uc(uc);
            lbl_title.Text = "Trang Chủ";
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            UC_Profile uc = new UC_Profile();
            add_uc(uc);
            lbl_title.Text = "Thông Tin Cá Nhân";
        }

        private void btn_khoHang_Click(object sender, EventArgs e)
        {
            UC_KhoHang uc = new UC_KhoHang();
            add_uc(uc);
            lbl_title.Text = "Thông Tin Kho Hàng";
        }

        private void btn_nhanSu_Click(object sender, EventArgs e)
        {
            UC_NhanSu uc = new UC_NhanSu();
            add_uc(uc);
            lbl_title.Text = "Thông Tin Nhân Sự";
        }

        private void btn_hoaDon_Click(object sender, EventArgs e)
        {
            UC_HoaDon uc = new UC_HoaDon();
            add_uc(uc);
            lbl_title.Text = "Thông Tin Hóa Đơn";
        }

        private void btn_phieuNhap_Click(object sender, EventArgs e)
        {
            UC_PhieuNhap uc = new UC_PhieuNhap();
            add_uc(uc);
            lbl_title.Text = "Thông Tin Phiếu Nhập";
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            UC_ThongKe uc = new UC_ThongKe();
            add_uc(uc);
            lbl_title.Text = "Thông Tin Thống Kê";
        }
    }
}
