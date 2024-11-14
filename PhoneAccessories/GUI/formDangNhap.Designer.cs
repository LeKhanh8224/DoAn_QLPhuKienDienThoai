using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class formDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDangNhap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ptbAvt = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_dangky = new System.Windows.Forms.Button();
            this.chkHienThiMK = new System.Windows.Forms.CheckBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.lblTenDN = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvt)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 95);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Ink Free", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(142, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(484, 142);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "ĐĂNG NHẬP";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 95);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 452);
            this.panel2.TabIndex = 0;
            // 
            // ptbAvt
            // 
            this.ptbAvt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ptbAvt.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptbAvt.Image = global::GUI.Properties.Resources.gif_login;
            this.ptbAvt.Location = new System.Drawing.Point(0, 0);
            this.ptbAvt.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ptbAvt.Name = "ptbAvt";
            this.ptbAvt.Size = new System.Drawing.Size(142, 142);
            this.ptbAvt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAvt.TabIndex = 0;
            this.ptbAvt.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.lblTitle);
            this.panel3.Controls.Add(this.ptbAvt);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(105, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(626, 142);
            this.panel3.TabIndex = 10;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(193, 138);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(217, 16);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Bạn chỉ muốn tham quan ứng dụng?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btn_dangky
            // 
            this.btn_dangky.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_dangky.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_dangky.Location = new System.Drawing.Point(364, 171);
            this.btn_dangky.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_dangky.Name = "btn_dangky";
            this.btn_dangky.Size = new System.Drawing.Size(99, 28);
            this.btn_dangky.TabIndex = 4;
            this.btn_dangky.Text = "Đăng Ký";
            this.btn_dangky.UseVisualStyleBackColor = true;
            this.btn_dangky.Click += new System.EventHandler(this.btn_dangky_Click);
            // 
            // chkHienThiMK
            // 
            this.chkHienThiMK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkHienThiMK.AutoSize = true;
            this.chkHienThiMK.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHienThiMK.Location = new System.Drawing.Point(228, 106);
            this.chkHienThiMK.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.chkHienThiMK.Name = "chkHienThiMK";
            this.chkHienThiMK.Size = new System.Drawing.Size(128, 20);
            this.chkHienThiMK.TabIndex = 2;
            this.chkHienThiMK.Text = "Hiển thị mật khẩu";
            this.chkHienThiMK.UseVisualStyleBackColor = true;
            this.chkHienThiMK.CheckedChanged += new System.EventHandler(this.chkHienThiMK_CheckedChanged);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDangNhap.Font = new System.Drawing.Font("Arial", 10F);
            this.btnDangNhap.Location = new System.Drawing.Point(140, 171);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(99, 28);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(105, 359);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(626, 93);
            this.panel5.TabIndex = 10;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.Location = new System.Drawing.Point(270, 73);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(193, 20);
            this.txtMatKhau.TabIndex = 1;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.Location = new System.Drawing.Point(137, 74);
            this.lblMatKhau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(65, 16);
            this.lblMatKhau.TabIndex = 2;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // txtTenDN
            // 
            this.txtTenDN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenDN.Location = new System.Drawing.Point(270, 34);
            this.txtTenDN.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(193, 20);
            this.txtTenDN.TabIndex = 0;
            this.txtTenDN.TextChanged += new System.EventHandler(this.txtTenDN_TextChanged);
            // 
            // lblTenDN
            // 
            this.lblTenDN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTenDN.AutoSize = true;
            this.lblTenDN.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDN.Location = new System.Drawing.Point(137, 35);
            this.lblTenDN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenDN.Name = "lblTenDN";
            this.lblTenDN.Size = new System.Drawing.Size(103, 16);
            this.lblTenDN.TabIndex = 3;
            this.lblTenDN.Text = "Tên đăng nhập";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(731, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(109, 452);
            this.panel7.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(105, 452);
            this.panel6.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.lblTenDN);
            this.panel4.Controls.Add(this.txtTenDN);
            this.panel4.Controls.Add(this.lblMatKhau);
            this.panel4.Controls.Add(this.txtMatKhau);
            this.panel4.Controls.Add(this.chkHienThiMK);
            this.panel4.Controls.Add(this.btnDangNhap);
            this.panel4.Controls.Add(this.linkLabel1);
            this.panel4.Controls.Add(this.btn_dangky);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(105, 142);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(626, 217);
            this.panel4.TabIndex = 11;
            // 
            // formDangNhap
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 547);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "formDangNhap";
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formDangNhap_FormClosing);
            this.Load += new System.EventHandler(this.formDangNhap_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvt)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Panel panel2;
        private PictureBox ptbAvt;
        private Panel panel6;
        private Panel panel7;
        private Panel panel3;
        private Button btnDangNhap;
        private Panel panel5;
        private TextBox txtMatKhau;
        private Label lblMatKhau;
        private TextBox txtTenDN;
        private Label lblTenDN;
        private CheckBox chkHienThiMK;
        private Button btn_dangky;
        private LinkLabel linkLabel1;
        private Panel panel4;
    }
}