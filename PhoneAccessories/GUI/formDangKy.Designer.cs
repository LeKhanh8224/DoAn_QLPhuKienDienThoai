namespace GUI
{
    partial class formDangKy
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_thongtin = new System.Windows.Forms.Panel();
            this.btn_dangNhap = new System.Windows.Forms.Button();
            this.btn_dangKy = new System.Windows.Forms.Button();
            this.chk_nu = new System.Windows.Forms.CheckBox();
            this.chk_nam = new System.Windows.Forms.CheckBox();
            this.txt_ngaySinh = new System.Windows.Forms.MaskedTextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_xacNhanMK = new System.Windows.Forms.TextBox();
            this.txt_matKhau = new System.Windows.Forms.TextBox();
            this.txt_tenDN = new System.Windows.Forms.TextBox();
            this.txt_hoTen = new System.Windows.Forms.TextBox();
            this.lbl_gioiTinh = new System.Windows.Forms.Label();
            this.lbl_ngaySinh = new System.Windows.Forms.Label();
            this.lbl_SDT = new System.Windows.Forms.Label();
            this.lbl_hoTen = new System.Windows.Forms.Label();
            this.lbl_xacNhanMK = new System.Windows.Forms.Label();
            this.lbl_matKhau = new System.Windows.Forms.Label();
            this.lbl_tenDN = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnl_thongtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(509, 64);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Đăng Ký";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnl_thongtin);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 260);
            this.panel1.TabIndex = 12;
            // 
            // pnl_thongtin
            // 
            this.pnl_thongtin.Controls.Add(this.btn_dangNhap);
            this.pnl_thongtin.Controls.Add(this.btn_dangKy);
            this.pnl_thongtin.Controls.Add(this.chk_nu);
            this.pnl_thongtin.Controls.Add(this.chk_nam);
            this.pnl_thongtin.Controls.Add(this.txt_ngaySinh);
            this.pnl_thongtin.Controls.Add(this.txt_SDT);
            this.pnl_thongtin.Controls.Add(this.txt_xacNhanMK);
            this.pnl_thongtin.Controls.Add(this.txt_matKhau);
            this.pnl_thongtin.Controls.Add(this.txt_tenDN);
            this.pnl_thongtin.Controls.Add(this.txt_hoTen);
            this.pnl_thongtin.Controls.Add(this.lbl_gioiTinh);
            this.pnl_thongtin.Controls.Add(this.lbl_ngaySinh);
            this.pnl_thongtin.Controls.Add(this.lbl_SDT);
            this.pnl_thongtin.Controls.Add(this.lbl_hoTen);
            this.pnl_thongtin.Controls.Add(this.lbl_xacNhanMK);
            this.pnl_thongtin.Controls.Add(this.lbl_matKhau);
            this.pnl_thongtin.Controls.Add(this.lbl_tenDN);
            this.pnl_thongtin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_thongtin.Location = new System.Drawing.Point(76, 0);
            this.pnl_thongtin.Name = "pnl_thongtin";
            this.pnl_thongtin.Size = new System.Drawing.Size(357, 260);
            this.pnl_thongtin.TabIndex = 2;
            // 
            // btn_dangNhap
            // 
            this.btn_dangNhap.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangNhap.Location = new System.Drawing.Point(198, 204);
            this.btn_dangNhap.Name = "btn_dangNhap";
            this.btn_dangNhap.Size = new System.Drawing.Size(98, 36);
            this.btn_dangNhap.TabIndex = 16;
            this.btn_dangNhap.Text = "Đăng Nhập";
            this.btn_dangNhap.UseVisualStyleBackColor = true;
            this.btn_dangNhap.Click += new System.EventHandler(this.btn_dangNhap_Click);
            // 
            // btn_dangKy
            // 
            this.btn_dangKy.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangKy.Location = new System.Drawing.Point(44, 204);
            this.btn_dangKy.Name = "btn_dangKy";
            this.btn_dangKy.Size = new System.Drawing.Size(98, 36);
            this.btn_dangKy.TabIndex = 15;
            this.btn_dangKy.Text = "Đăng Ký";
            this.btn_dangKy.UseVisualStyleBackColor = true;
            this.btn_dangKy.Click += new System.EventHandler(this.btn_dangKy_Click);
            // 
            // chk_nu
            // 
            this.chk_nu.AutoSize = true;
            this.chk_nu.Location = new System.Drawing.Point(256, 121);
            this.chk_nu.Name = "chk_nu";
            this.chk_nu.Size = new System.Drawing.Size(40, 17);
            this.chk_nu.TabIndex = 14;
            this.chk_nu.Text = "Nữ";
            this.chk_nu.UseVisualStyleBackColor = true;
            // 
            // chk_nam
            // 
            this.chk_nam.AutoSize = true;
            this.chk_nam.Location = new System.Drawing.Point(154, 121);
            this.chk_nam.Name = "chk_nam";
            this.chk_nam.Size = new System.Drawing.Size(48, 17);
            this.chk_nam.TabIndex = 13;
            this.chk_nam.Text = "Nam";
            this.chk_nam.UseVisualStyleBackColor = true;
            // 
            // txt_ngaySinh
            // 
            this.txt_ngaySinh.Location = new System.Drawing.Point(154, 144);
            this.txt_ngaySinh.Name = "txt_ngaySinh";
            this.txt_ngaySinh.Size = new System.Drawing.Size(182, 20);
            this.txt_ngaySinh.TabIndex = 12;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(154, 169);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(182, 20);
            this.txt_SDT.TabIndex = 11;
            // 
            // txt_xacNhanMK
            // 
            this.txt_xacNhanMK.Location = new System.Drawing.Point(154, 94);
            this.txt_xacNhanMK.Name = "txt_xacNhanMK";
            this.txt_xacNhanMK.Size = new System.Drawing.Size(182, 20);
            this.txt_xacNhanMK.TabIndex = 10;
            // 
            // txt_matKhau
            // 
            this.txt_matKhau.Location = new System.Drawing.Point(154, 69);
            this.txt_matKhau.Name = "txt_matKhau";
            this.txt_matKhau.Size = new System.Drawing.Size(182, 20);
            this.txt_matKhau.TabIndex = 9;
            // 
            // txt_tenDN
            // 
            this.txt_tenDN.Location = new System.Drawing.Point(154, 44);
            this.txt_tenDN.Name = "txt_tenDN";
            this.txt_tenDN.Size = new System.Drawing.Size(182, 20);
            this.txt_tenDN.TabIndex = 8;
            // 
            // txt_hoTen
            // 
            this.txt_hoTen.Location = new System.Drawing.Point(154, 19);
            this.txt_hoTen.Name = "txt_hoTen";
            this.txt_hoTen.Size = new System.Drawing.Size(182, 20);
            this.txt_hoTen.TabIndex = 7;
            // 
            // lbl_gioiTinh
            // 
            this.lbl_gioiTinh.AutoSize = true;
            this.lbl_gioiTinh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gioiTinh.Location = new System.Drawing.Point(20, 120);
            this.lbl_gioiTinh.Name = "lbl_gioiTinh";
            this.lbl_gioiTinh.Size = new System.Drawing.Size(60, 16);
            this.lbl_gioiTinh.TabIndex = 6;
            this.lbl_gioiTinh.Text = "Giới Tính";
            // 
            // lbl_ngaySinh
            // 
            this.lbl_ngaySinh.AutoSize = true;
            this.lbl_ngaySinh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngaySinh.Location = new System.Drawing.Point(20, 145);
            this.lbl_ngaySinh.Name = "lbl_ngaySinh";
            this.lbl_ngaySinh.Size = new System.Drawing.Size(67, 16);
            this.lbl_ngaySinh.TabIndex = 5;
            this.lbl_ngaySinh.Text = "Ngày Sinh";
            // 
            // lbl_SDT
            // 
            this.lbl_SDT.AutoSize = true;
            this.lbl_SDT.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SDT.Location = new System.Drawing.Point(20, 170);
            this.lbl_SDT.Name = "lbl_SDT";
            this.lbl_SDT.Size = new System.Drawing.Size(88, 16);
            this.lbl_SDT.TabIndex = 4;
            this.lbl_SDT.Text = "Số Điện Thoại";
            // 
            // lbl_hoTen
            // 
            this.lbl_hoTen.AutoSize = true;
            this.lbl_hoTen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hoTen.Location = new System.Drawing.Point(20, 20);
            this.lbl_hoTen.Name = "lbl_hoTen";
            this.lbl_hoTen.Size = new System.Drawing.Size(48, 16);
            this.lbl_hoTen.TabIndex = 3;
            this.lbl_hoTen.Text = "Họ Tên";
            // 
            // lbl_xacNhanMK
            // 
            this.lbl_xacNhanMK.AutoSize = true;
            this.lbl_xacNhanMK.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_xacNhanMK.Location = new System.Drawing.Point(20, 95);
            this.lbl_xacNhanMK.Name = "lbl_xacNhanMK";
            this.lbl_xacNhanMK.Size = new System.Drawing.Size(122, 16);
            this.lbl_xacNhanMK.TabIndex = 2;
            this.lbl_xacNhanMK.Text = "Xác Nhận Mật Khẩu";
            // 
            // lbl_matKhau
            // 
            this.lbl_matKhau.AutoSize = true;
            this.lbl_matKhau.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matKhau.Location = new System.Drawing.Point(20, 70);
            this.lbl_matKhau.Name = "lbl_matKhau";
            this.lbl_matKhau.Size = new System.Drawing.Size(63, 16);
            this.lbl_matKhau.TabIndex = 1;
            this.lbl_matKhau.Text = "Mật Khẩu";
            // 
            // lbl_tenDN
            // 
            this.lbl_tenDN.AutoSize = true;
            this.lbl_tenDN.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenDN.Location = new System.Drawing.Point(20, 45);
            this.lbl_tenDN.Name = "lbl_tenDN";
            this.lbl_tenDN.Size = new System.Drawing.Size(96, 16);
            this.lbl_tenDN.TabIndex = 0;
            this.lbl_tenDN.Text = "Tên Đăng Nhập";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(433, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(76, 260);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(76, 260);
            this.panel2.TabIndex = 0;
            // 
            // formDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 324);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Name = "formDangKy";
            this.Text = "formDangKy";
            this.panel1.ResumeLayout(false);
            this.pnl_thongtin.ResumeLayout(false);
            this.pnl_thongtin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_thongtin;
        private System.Windows.Forms.Label lbl_SDT;
        private System.Windows.Forms.Label lbl_hoTen;
        private System.Windows.Forms.Label lbl_xacNhanMK;
        private System.Windows.Forms.Label lbl_matKhau;
        private System.Windows.Forms.Label lbl_tenDN;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_gioiTinh;
        private System.Windows.Forms.Label lbl_ngaySinh;
        private System.Windows.Forms.CheckBox chk_nu;
        private System.Windows.Forms.CheckBox chk_nam;
        private System.Windows.Forms.MaskedTextBox txt_ngaySinh;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_xacNhanMK;
        private System.Windows.Forms.TextBox txt_matKhau;
        private System.Windows.Forms.TextBox txt_tenDN;
        private System.Windows.Forms.TextBox txt_hoTen;
        private System.Windows.Forms.Button btn_dangNhap;
        private System.Windows.Forms.Button btn_dangKy;
    }
}