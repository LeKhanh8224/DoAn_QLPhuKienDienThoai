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

            if (string.IsNullOrWhiteSpace(tenDN) || string.IsNullOrWhiteSpace(matkhau))
            {
                MessageBox.Show("Không được bỏ trống nội dung!", "Cảnh báo");
                return;
            }

            DTO_TaiKhoan taiKhoan;
            try
            {
                taiKhoan = taiKhoanBLL.Login(tenDN, matkhau);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối cơ sở dữ liệu: {ex.Message}", "Thông báo lỗi");
                return;
            }

            if (taiKhoan != null)
            {
                if (taiKhoan.MAVT.Trim().Equals("admin"))
                {
                    this.Hide();
                    formMain formMain = new formMain(taiKhoan.MAVT, tenDN);
                    formMain.ShowDialog();
                }
                else
                {
                    DTO_NhanVien nhanvien;
                    try
                    {
                        nhanvien = nhanVienBLL.layTheoTenDN(tenDN);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi tải thông tin nhân viên: {ex.Message}", "Thông báo lỗi");
                        return;
                    }

                    if (nhanvien.TRANGTHAI.Equals("Đã nghỉ"))
                    {
                        MessageBox.Show("Nhân viên đã nghỉ không thể đăng nhập!", "Thông báo");
                    }
                    else
                    {
                        this.Hide();
                        formMain formMain = new formMain(taiKhoan.MAVT, tenDN);
                        formMain.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo");
                txtMatKhau.Clear();
                txtMatKhau.Focus();
            }
        }

        private void formDangNhap_Load(object sender, EventArgs e)
        {
            txtTenDN.Focus();
        }


        private void txtTenDN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
