using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class formDangNhap : Form
    {
        BLL_TaiKhoan taiKhoanBLL = new BLL_TaiKhoan();
        BLL_NhanVien nhanVienBLL = new BLL_NhanVien();
        BLL_KhachHang khachhangBLL = new BLL_KhachHang();
        public formDangNhap()
        {
            InitializeComponent();
        }

        private void formDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
            else
                Application.ExitThread();
        }

        private void chkHienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienThiMK.Checked)
            {
                txtMatKhau.PasswordChar = '\0';
            }
            else
                txtMatKhau.PasswordChar = '*';
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDN = txtTenDN.Text.Trim();
            string matkhau = txtMatKhau.Text.Trim();
            DTO_TaiKhoan taiKhoan = taiKhoanBLL.Login(tenDN, matkhau);

            if (txtTenDN.Text.Length == 0 || txtMatKhau.Text.Length == 0)
            {
                MessageBox.Show("Không được bỏ trống nội dung!", "Cảnh báo");
            }
            else if (taiKhoan != null) //Nếu taiKhoan có thông tin
            {
                if (taiKhoan.MAVT.Trim().Equals("admin")) //Nếu vai trò tài khoản là admin
                {
                    this.Hide();
                    formMain formMain = new formMain(taiKhoan.MAVT, tenDN);
                    formMain.ShowDialog();
                }
                else if (taiKhoan.MAVT.Trim().Equals("VT000") == false) //Nếu vai trò tài khoản không phải khách hàng
                {
                    DTO_NhanVien nhanvien = nhanVienBLL.layTheoTenDN(tenDN);
                    if (nhanvien.TRANGTHAI.Equals("Đã nghỉ"))
                    {
                        MessageBox.Show("Nhân viên đã nghỉ không thể đăng nhập!", "Thông báo");
                    }
                    else //Nếu nhân viên này vẫn còn làm
                    {
                        this.Hide();
                        formMain formMain = new formMain(taiKhoan.MAVT, tenDN);
                        formMain.ShowDialog();
                    }
                }
                else //Nếu vai trò tài khoản là khách hàng
                {
                    DTO_KhachHang khachhang = khachhangBLL.layTheoTenDN(tenDN);
                    this.Hide();
                    formMain formMain = new formMain(taiKhoan.MAVT, tenDN);
                    formMain.ShowDialog();
                }
            }
            else //Nếu tài khoản không có thông tin
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo");
            }
        }

        private void formDangNhap_Load(object sender, EventArgs e)
        {
            txtTenDN.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string vaiTro = "Khách Vãng Lai";
            string tenDN = "Không có tài khoản";
            this.Hide();
            formMain formMain = new formMain(vaiTro, tenDN);
            formMain.ShowDialog();
        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            this.Hide();
            formDangKy formDangKy = new formDangKy();
            formDangKy.ShowDialog();
        }
    }
}
