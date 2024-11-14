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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDangKy));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_thongtin = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pic_log = new System.Windows.Forms.PictureBox();
            this.rbtn_Nu = new System.Windows.Forms.RadioButton();
            this.rbtn_Nam = new System.Windows.Forms.RadioButton();
            this.btn_dangNhap = new System.Windows.Forms.Button();
            this.btn_dangKy = new System.Windows.Forms.Button();
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnl_thongtin.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_log)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(76, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 90);
            this.panel1.TabIndex = 0;
            // 
            // pnl_thongtin
            // 
            this.pnl_thongtin.BackColor = System.Drawing.Color.White;
            this.pnl_thongtin.Controls.Add(this.panel4);
            this.pnl_thongtin.Controls.Add(this.rbtn_Nu);
            this.pnl_thongtin.Controls.Add(this.rbtn_Nam);
            this.pnl_thongtin.Controls.Add(this.btn_dangNhap);
            this.pnl_thongtin.Controls.Add(this.btn_dangKy);
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
            this.pnl_thongtin.Location = new System.Drawing.Point(76, 90);
            this.pnl_thongtin.Name = "pnl_thongtin";
            this.pnl_thongtin.Size = new System.Drawing.Size(458, 486);
            this.pnl_thongtin.TabIndex = 2;
            this.pnl_thongtin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_thongtin_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblTitle);
            this.panel4.Controls.Add(this.pic_log);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(458, 124);
            this.panel4.TabIndex = 19;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Ink Free", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(145, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(313, 124);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "ĐĂNG KÝ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_log
            // 
            this.pic_log.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic_log.Image = global::GUI.Properties.Resources.gif_login;
            this.pic_log.Location = new System.Drawing.Point(0, 0);
            this.pic_log.Name = "pic_log";
            this.pic_log.Size = new System.Drawing.Size(145, 124);
            this.pic_log.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_log.TabIndex = 0;
            this.pic_log.TabStop = false;
            // 
            // rbtn_Nu
            // 
            this.rbtn_Nu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtn_Nu.AutoSize = true;
            this.rbtn_Nu.Location = new System.Drawing.Point(301, 244);
            this.rbtn_Nu.Name = "rbtn_Nu";
            this.rbtn_Nu.Size = new System.Drawing.Size(39, 17);
            this.rbtn_Nu.TabIndex = 18;
            this.rbtn_Nu.Text = "Nữ";
            this.rbtn_Nu.UseVisualStyleBackColor = true;
            // 
            // rbtn_Nam
            // 
            this.rbtn_Nam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtn_Nam.AutoSize = true;
            this.rbtn_Nam.Location = new System.Drawing.Point(204, 244);
            this.rbtn_Nam.Name = "rbtn_Nam";
            this.rbtn_Nam.Size = new System.Drawing.Size(47, 17);
            this.rbtn_Nam.TabIndex = 17;
            this.rbtn_Nam.Text = "Nam";
            this.rbtn_Nam.UseVisualStyleBackColor = true;
            // 
            // btn_dangNhap
            // 
            this.btn_dangNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_dangNhap.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangNhap.Location = new System.Drawing.Point(248, 327);
            this.btn_dangNhap.Name = "btn_dangNhap";
            this.btn_dangNhap.Size = new System.Drawing.Size(98, 36);
            this.btn_dangNhap.TabIndex = 16;
            this.btn_dangNhap.Text = "Đăng Nhập";
            this.btn_dangNhap.UseVisualStyleBackColor = true;
            this.btn_dangNhap.Click += new System.EventHandler(this.btn_dangNhap_Click);
            // 
            // btn_dangKy
            // 
            this.btn_dangKy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_dangKy.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangKy.Location = new System.Drawing.Point(94, 327);
            this.btn_dangKy.Name = "btn_dangKy";
            this.btn_dangKy.Size = new System.Drawing.Size(98, 36);
            this.btn_dangKy.TabIndex = 15;
            this.btn_dangKy.Text = "Đăng Ký";
            this.btn_dangKy.UseVisualStyleBackColor = true;
            this.btn_dangKy.Click += new System.EventHandler(this.btn_dangKy_Click);
            // 
            // txt_ngaySinh
            // 
            this.txt_ngaySinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_ngaySinh.Location = new System.Drawing.Point(204, 267);
            this.txt_ngaySinh.Name = "txt_ngaySinh";
            this.txt_ngaySinh.Size = new System.Drawing.Size(182, 20);
            this.txt_ngaySinh.TabIndex = 12;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_SDT.Location = new System.Drawing.Point(204, 292);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(182, 20);
            this.txt_SDT.TabIndex = 11;
            // 
            // txt_xacNhanMK
            // 
            this.txt_xacNhanMK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_xacNhanMK.Location = new System.Drawing.Point(204, 217);
            this.txt_xacNhanMK.Name = "txt_xacNhanMK";
            this.txt_xacNhanMK.Size = new System.Drawing.Size(182, 20);
            this.txt_xacNhanMK.TabIndex = 10;
            // 
            // txt_matKhau
            // 
            this.txt_matKhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_matKhau.Location = new System.Drawing.Point(204, 192);
            this.txt_matKhau.Name = "txt_matKhau";
            this.txt_matKhau.Size = new System.Drawing.Size(182, 20);
            this.txt_matKhau.TabIndex = 9;
            // 
            // txt_tenDN
            // 
            this.txt_tenDN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_tenDN.Location = new System.Drawing.Point(204, 167);
            this.txt_tenDN.Name = "txt_tenDN";
            this.txt_tenDN.Size = new System.Drawing.Size(182, 20);
            this.txt_tenDN.TabIndex = 8;
            // 
            // txt_hoTen
            // 
            this.txt_hoTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_hoTen.Location = new System.Drawing.Point(204, 142);
            this.txt_hoTen.Name = "txt_hoTen";
            this.txt_hoTen.Size = new System.Drawing.Size(182, 20);
            this.txt_hoTen.TabIndex = 7;
            // 
            // lbl_gioiTinh
            // 
            this.lbl_gioiTinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_gioiTinh.AutoSize = true;
            this.lbl_gioiTinh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gioiTinh.Location = new System.Drawing.Point(70, 243);
            this.lbl_gioiTinh.Name = "lbl_gioiTinh";
            this.lbl_gioiTinh.Size = new System.Drawing.Size(60, 16);
            this.lbl_gioiTinh.TabIndex = 6;
            this.lbl_gioiTinh.Text = "Giới Tính";
            // 
            // lbl_ngaySinh
            // 
            this.lbl_ngaySinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_ngaySinh.AutoSize = true;
            this.lbl_ngaySinh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngaySinh.Location = new System.Drawing.Point(70, 268);
            this.lbl_ngaySinh.Name = "lbl_ngaySinh";
            this.lbl_ngaySinh.Size = new System.Drawing.Size(67, 16);
            this.lbl_ngaySinh.TabIndex = 5;
            this.lbl_ngaySinh.Text = "Ngày Sinh";
            // 
            // lbl_SDT
            // 
            this.lbl_SDT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_SDT.AutoSize = true;
            this.lbl_SDT.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SDT.Location = new System.Drawing.Point(70, 293);
            this.lbl_SDT.Name = "lbl_SDT";
            this.lbl_SDT.Size = new System.Drawing.Size(88, 16);
            this.lbl_SDT.TabIndex = 4;
            this.lbl_SDT.Text = "Số Điện Thoại";
            // 
            // lbl_hoTen
            // 
            this.lbl_hoTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_hoTen.AutoSize = true;
            this.lbl_hoTen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hoTen.Location = new System.Drawing.Point(70, 143);
            this.lbl_hoTen.Name = "lbl_hoTen";
            this.lbl_hoTen.Size = new System.Drawing.Size(48, 16);
            this.lbl_hoTen.TabIndex = 3;
            this.lbl_hoTen.Text = "Họ Tên";
            // 
            // lbl_xacNhanMK
            // 
            this.lbl_xacNhanMK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_xacNhanMK.AutoSize = true;
            this.lbl_xacNhanMK.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_xacNhanMK.Location = new System.Drawing.Point(70, 218);
            this.lbl_xacNhanMK.Name = "lbl_xacNhanMK";
            this.lbl_xacNhanMK.Size = new System.Drawing.Size(122, 16);
            this.lbl_xacNhanMK.TabIndex = 2;
            this.lbl_xacNhanMK.Text = "Xác Nhận Mật Khẩu";
            // 
            // lbl_matKhau
            // 
            this.lbl_matKhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_matKhau.AutoSize = true;
            this.lbl_matKhau.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matKhau.Location = new System.Drawing.Point(70, 193);
            this.lbl_matKhau.Name = "lbl_matKhau";
            this.lbl_matKhau.Size = new System.Drawing.Size(63, 16);
            this.lbl_matKhau.TabIndex = 1;
            this.lbl_matKhau.Text = "Mật Khẩu";
            // 
            // lbl_tenDN
            // 
            this.lbl_tenDN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_tenDN.AutoSize = true;
            this.lbl_tenDN.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenDN.Location = new System.Drawing.Point(70, 168);
            this.lbl_tenDN.Name = "lbl_tenDN";
            this.lbl_tenDN.Size = new System.Drawing.Size(96, 16);
            this.lbl_tenDN.TabIndex = 0;
            this.lbl_tenDN.Text = "Tên Đăng Nhập";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(534, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(76, 576);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(76, 576);
            this.panel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(76, 476);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(458, 100);
            this.panel5.TabIndex = 0;
            // 
            // formDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 576);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pnl_thongtin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formDangKy";
            this.Text = "formDangKy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formDangKy_FormClosing);
            this.pnl_thongtin.ResumeLayout(false);
            this.pnl_thongtin.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_log)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.MaskedTextBox txt_ngaySinh;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_xacNhanMK;
        private System.Windows.Forms.TextBox txt_matKhau;
        private System.Windows.Forms.TextBox txt_tenDN;
        private System.Windows.Forms.TextBox txt_hoTen;
        private System.Windows.Forms.Button btn_dangNhap;
        private System.Windows.Forms.Button btn_dangKy;
        private System.Windows.Forms.RadioButton rbtn_Nu;
        private System.Windows.Forms.RadioButton rbtn_Nam;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pic_log;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblTitle;
    }
}