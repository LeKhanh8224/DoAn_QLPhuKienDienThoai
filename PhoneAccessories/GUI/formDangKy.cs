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
    public partial class formDangKy : Form
    {
        public formDangKy()
        {
            InitializeComponent();
        }

        private void btn_dangKy_Click(object sender, EventArgs e)
        {

        }

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            formDangNhap frmdn = new formDangNhap();
            frmdn.ShowDialog();
            this.Show();
        }

        private void pnl_thongtin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formDangKy_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
            else
                Application.ExitThread();
        }
    }
}
