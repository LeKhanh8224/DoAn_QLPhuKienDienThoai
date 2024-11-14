namespace GUI
{
    partial class formMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_dangxuat = new System.Windows.Forms.Panel();
            this.btn_dangxuat = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_button = new System.Windows.Forms.Panel();
            this.pnl_khachHang = new System.Windows.Forms.Panel();
            this.lbl_actnumKH = new System.Windows.Forms.Label();
            this.lbl_activeKH = new System.Windows.Forms.Label();
            this.pnl_nhanVien = new System.Windows.Forms.Panel();
            this.lbl_actnumNV = new System.Windows.Forms.Label();
            this.lbl_activeNV = new System.Windows.Forms.Label();
            this.lbl_nguoidung = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.btn_phieuNhap = new System.Windows.Forms.Button();
            this.btn_hoaDon = new System.Windows.Forms.Button();
            this.btn_nhanSu = new System.Windows.Forms.Button();
            this.btn_khoHang = new System.Windows.Forms.Button();
            this.btn_profile = new System.Windows.Forms.Button();
            this.btn_trangChu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnl_dangxuat.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_button.SuspendLayout();
            this.pnl_khachHang.SuspendLayout();
            this.pnl_nhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.pnl_dangxuat);
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 63);
            this.panel1.TabIndex = 0;
            // 
            // pnl_dangxuat
            // 
            this.pnl_dangxuat.Controls.Add(this.btn_dangxuat);
            this.pnl_dangxuat.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_dangxuat.Location = new System.Drawing.Point(906, 0);
            this.pnl_dangxuat.Name = "pnl_dangxuat";
            this.pnl_dangxuat.Size = new System.Drawing.Size(200, 63);
            this.pnl_dangxuat.TabIndex = 1;
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_dangxuat.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangxuat.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_dangxuat.Location = new System.Drawing.Point(46, 12);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.Size = new System.Drawing.Size(118, 37);
            this.btn_dangxuat.TabIndex = 0;
            this.btn_dangxuat.Text = "Đăng Xuất";
            this.btn_dangxuat.UseVisualStyleBackColor = true;
            this.btn_dangxuat.Click += new System.EventHandler(this.btn_dangxuat_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_title.Location = new System.Drawing.Point(59, 12);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(110, 37);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.pnl_button);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1106, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 706);
            this.panel2.TabIndex = 1;
            // 
            // pnl_button
            // 
            this.pnl_button.Controls.Add(this.pnl_khachHang);
            this.pnl_button.Controls.Add(this.pnl_nhanVien);
            this.pnl_button.Controls.Add(this.lbl_nguoidung);
            this.pnl_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_button.Location = new System.Drawing.Point(0, 184);
            this.pnl_button.Name = "pnl_button";
            this.pnl_button.Size = new System.Drawing.Size(201, 522);
            this.pnl_button.TabIndex = 3;
            // 
            // pnl_khachHang
            // 
            this.pnl_khachHang.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnl_khachHang.Controls.Add(this.lbl_actnumKH);
            this.pnl_khachHang.Controls.Add(this.lbl_activeKH);
            this.pnl_khachHang.Location = new System.Drawing.Point(0, 120);
            this.pnl_khachHang.Name = "pnl_khachHang";
            this.pnl_khachHang.Size = new System.Drawing.Size(201, 196);
            this.pnl_khachHang.TabIndex = 4;
            // 
            // lbl_actnumKH
            // 
            this.lbl_actnumKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_actnumKH.Font = new System.Drawing.Font("Arial Black", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_actnumKH.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_actnumKH.Location = new System.Drawing.Point(0, 55);
            this.lbl_actnumKH.Name = "lbl_actnumKH";
            this.lbl_actnumKH.Size = new System.Drawing.Size(201, 141);
            this.lbl_actnumKH.TabIndex = 1;
            this.lbl_actnumKH.Text = "0";
            this.lbl_actnumKH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_activeKH
            // 
            this.lbl_activeKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_activeKH.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_activeKH.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_activeKH.Location = new System.Drawing.Point(0, 0);
            this.lbl_activeKH.Name = "lbl_activeKH";
            this.lbl_activeKH.Size = new System.Drawing.Size(201, 55);
            this.lbl_activeKH.TabIndex = 0;
            this.lbl_activeKH.Text = "Khách Hàng";
            this.lbl_activeKH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_nhanVien
            // 
            this.pnl_nhanVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnl_nhanVien.BackColor = System.Drawing.Color.Teal;
            this.pnl_nhanVien.Controls.Add(this.lbl_actnumNV);
            this.pnl_nhanVien.Controls.Add(this.lbl_activeNV);
            this.pnl_nhanVien.Location = new System.Drawing.Point(0, 316);
            this.pnl_nhanVien.Name = "pnl_nhanVien";
            this.pnl_nhanVien.Size = new System.Drawing.Size(201, 195);
            this.pnl_nhanVien.TabIndex = 2;
            // 
            // lbl_actnumNV
            // 
            this.lbl_actnumNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_actnumNV.Font = new System.Drawing.Font("Arial Black", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_actnumNV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_actnumNV.Location = new System.Drawing.Point(0, 55);
            this.lbl_actnumNV.Name = "lbl_actnumNV";
            this.lbl_actnumNV.Size = new System.Drawing.Size(201, 140);
            this.lbl_actnumNV.TabIndex = 2;
            this.lbl_actnumNV.Text = "0";
            this.lbl_actnumNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_activeNV
            // 
            this.lbl_activeNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_activeNV.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_activeNV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_activeNV.Location = new System.Drawing.Point(0, 0);
            this.lbl_activeNV.Name = "lbl_activeNV";
            this.lbl_activeNV.Size = new System.Drawing.Size(201, 55);
            this.lbl_activeNV.TabIndex = 1;
            this.lbl_activeNV.Text = "Nhân Viên Hoạt Động";
            this.lbl_activeNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_nguoidung
            // 
            this.lbl_nguoidung.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_nguoidung.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_nguoidung.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_nguoidung.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nguoidung.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_nguoidung.Location = new System.Drawing.Point(0, 0);
            this.lbl_nguoidung.Name = "lbl_nguoidung";
            this.lbl_nguoidung.Size = new System.Drawing.Size(201, 120);
            this.lbl_nguoidung.TabIndex = 1;
            this.lbl_nguoidung.Text = "label1";
            this.lbl_nguoidung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::GUI.Properties.Resources.gif_dashboard;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Location = new System.Drawing.Point(0, 0);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(1106, 706);
            this.pnl_main.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Controls.Add(this.btn_ThongKe);
            this.panel3.Controls.Add(this.btn_phieuNhap);
            this.panel3.Controls.Add(this.btn_hoaDon);
            this.panel3.Controls.Add(this.btn_nhanSu);
            this.panel3.Controls.Add(this.btn_khoHang);
            this.panel3.Controls.Add(this.btn_profile);
            this.panel3.Controls.Add(this.btn_trangChu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1106, 64);
            this.panel3.TabIndex = 3;
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.AutoSize = true;
            this.btn_ThongKe.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_ThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ThongKe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongKe.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_ThongKe.Image = global::GUI.Properties.Resources.statistical_icon;
            this.btn_ThongKe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ThongKe.Location = new System.Drawing.Point(636, 0);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(103, 64);
            this.btn_ThongKe.TabIndex = 2;
            this.btn_ThongKe.Text = "Thống Kê";
            this.btn_ThongKe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ThongKe.UseVisualStyleBackColor = false;
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
            // 
            // btn_phieuNhap
            // 
            this.btn_phieuNhap.AutoSize = true;
            this.btn_phieuNhap.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_phieuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_phieuNhap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_phieuNhap.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_phieuNhap.Image = global::GUI.Properties.Resources.entryForm_icon;
            this.btn_phieuNhap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_phieuNhap.Location = new System.Drawing.Point(528, 0);
            this.btn_phieuNhap.Name = "btn_phieuNhap";
            this.btn_phieuNhap.Size = new System.Drawing.Size(108, 64);
            this.btn_phieuNhap.TabIndex = 6;
            this.btn_phieuNhap.Text = "Phiếu Nhập";
            this.btn_phieuNhap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_phieuNhap.UseVisualStyleBackColor = false;
            this.btn_phieuNhap.Click += new System.EventHandler(this.btn_phieuNhap_Click);
            // 
            // btn_hoaDon
            // 
            this.btn_hoaDon.AutoSize = true;
            this.btn_hoaDon.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_hoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_hoaDon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hoaDon.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_hoaDon.Image = global::GUI.Properties.Resources.bill_icon;
            this.btn_hoaDon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_hoaDon.Location = new System.Drawing.Point(420, 0);
            this.btn_hoaDon.Name = "btn_hoaDon";
            this.btn_hoaDon.Size = new System.Drawing.Size(108, 64);
            this.btn_hoaDon.TabIndex = 5;
            this.btn_hoaDon.Text = "Hóa Đơn";
            this.btn_hoaDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_hoaDon.UseVisualStyleBackColor = false;
            this.btn_hoaDon.Click += new System.EventHandler(this.btn_hoaDon_Click);
            // 
            // btn_nhanSu
            // 
            this.btn_nhanSu.AutoSize = true;
            this.btn_nhanSu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_nhanSu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_nhanSu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_nhanSu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhanSu.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_nhanSu.Image = ((System.Drawing.Image)(resources.GetObject("btn_nhanSu.Image")));
            this.btn_nhanSu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_nhanSu.Location = new System.Drawing.Point(317, 0);
            this.btn_nhanSu.Name = "btn_nhanSu";
            this.btn_nhanSu.Size = new System.Drawing.Size(103, 64);
            this.btn_nhanSu.TabIndex = 1;
            this.btn_nhanSu.Text = "Nhân Sự";
            this.btn_nhanSu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_nhanSu.UseVisualStyleBackColor = false;
            this.btn_nhanSu.Click += new System.EventHandler(this.btn_nhanSu_Click);
            // 
            // btn_khoHang
            // 
            this.btn_khoHang.AutoSize = true;
            this.btn_khoHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_khoHang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_khoHang.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_khoHang.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_khoHang.Image = global::GUI.Properties.Resources.pic_kho;
            this.btn_khoHang.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_khoHang.Location = new System.Drawing.Point(208, 0);
            this.btn_khoHang.Name = "btn_khoHang";
            this.btn_khoHang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_khoHang.Size = new System.Drawing.Size(109, 64);
            this.btn_khoHang.TabIndex = 4;
            this.btn_khoHang.Text = "Kho Hàng";
            this.btn_khoHang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_khoHang.UseVisualStyleBackColor = false;
            this.btn_khoHang.Click += new System.EventHandler(this.btn_khoHang_Click);
            // 
            // btn_profile
            // 
            this.btn_profile.AutoSize = true;
            this.btn_profile.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_profile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_profile.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_profile.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_profile.Image = global::GUI.Properties.Resources.profile_icon_32;
            this.btn_profile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_profile.Location = new System.Drawing.Point(103, 0);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(105, 64);
            this.btn_profile.TabIndex = 3;
            this.btn_profile.Text = "Profile";
            this.btn_profile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_profile.UseVisualStyleBackColor = false;
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
            // 
            // btn_trangChu
            // 
            this.btn_trangChu.AutoSize = true;
            this.btn_trangChu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_trangChu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_trangChu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trangChu.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_trangChu.Image = global::GUI.Properties.Resources.dashboard_pic_32;
            this.btn_trangChu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_trangChu.Location = new System.Drawing.Point(0, 0);
            this.btn_trangChu.Name = "btn_trangChu";
            this.btn_trangChu.Size = new System.Drawing.Size(103, 64);
            this.btn_trangChu.TabIndex = 0;
            this.btn_trangChu.Text = "Trang Chủ";
            this.btn_trangChu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_trangChu.UseVisualStyleBackColor = false;
            this.btn_trangChu.Click += new System.EventHandler(this.btn_trangChu_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1307, 706);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formMain";
            this.Text = "Phụ Kiện Điện Thoại";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formMain_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_dangxuat.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnl_button.ResumeLayout(false);
            this.pnl_khachHang.ResumeLayout(false);
            this.pnl_nhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_dangxuat;
        private System.Windows.Forms.Label lbl_nguoidung;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_button;
        private System.Windows.Forms.Panel pnl_dangxuat;
        private System.Windows.Forms.Panel pnl_khachHang;
        private System.Windows.Forms.Panel pnl_nhanVien;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_activeKH;
        private System.Windows.Forms.Label lbl_activeNV;
        private System.Windows.Forms.Label lbl_actnumKH;
        private System.Windows.Forms.Label lbl_actnumNV;
        private System.Windows.Forms.Button btn_trangChu;
        private System.Windows.Forms.Button btn_nhanSu;
        private System.Windows.Forms.Button btn_phieuNhap;
        private System.Windows.Forms.Button btn_hoaDon;
        private System.Windows.Forms.Button btn_khoHang;
        private System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.Button btn_ThongKe;
    }
}