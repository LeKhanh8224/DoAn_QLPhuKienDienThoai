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
            this.panel4 = new System.Windows.Forms.Panel();
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.ptbAvt = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvt)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 64);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(489, 64);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Đăng Nhập";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.ptbAvt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 233);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 79);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(489, 154);
            this.panel4.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.linkLabel1);
            this.panel3.Controls.Add(this.btn_dangky);
            this.panel3.Controls.Add(this.chkHienThiMK);
            this.panel3.Controls.Add(this.btnDangNhap);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(105, 70);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 102);
            this.panel3.TabIndex = 10;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(52, 22);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(179, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Bạn chỉ muốn tham quan ứng dụng?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btn_dangky
            // 
            this.btn_dangky.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_dangky.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_dangky.Location = new System.Drawing.Point(161, 46);
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
            this.chkHienThiMK.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHienThiMK.Location = new System.Drawing.Point(75, 2);
            this.chkHienThiMK.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.chkHienThiMK.Name = "chkHienThiMK";
            this.chkHienThiMK.Size = new System.Drawing.Size(122, 19);
            this.chkHienThiMK.TabIndex = 2;
            this.chkHienThiMK.Text = "Hiển thị mật khẩu";
            this.chkHienThiMK.UseVisualStyleBackColor = true;
            this.chkHienThiMK.CheckedChanged += new System.EventHandler(this.chkHienThiMK_CheckedChanged);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDangNhap.Font = new System.Drawing.Font("Arial", 10F);
            this.btnDangNhap.Location = new System.Drawing.Point(13, 46);
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
            this.panel5.Controls.Add(this.txtMatKhau);
            this.panel5.Controls.Add(this.lblMatKhau);
            this.panel5.Controls.Add(this.txtTenDN);
            this.panel5.Controls.Add(this.lblTenDN);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(105, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(275, 70);
            this.panel5.TabIndex = 10;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.Location = new System.Drawing.Point(118, 33);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(151, 20);
            this.txtMatKhau.TabIndex = 1;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Arial", 10F);
            this.lblMatKhau.Location = new System.Drawing.Point(10, 34);
            this.lblMatKhau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(65, 16);
            this.lblMatKhau.TabIndex = 2;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // txtTenDN
            // 
            this.txtTenDN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenDN.Location = new System.Drawing.Point(118, 10);
            this.txtTenDN.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(151, 20);
            this.txtTenDN.TabIndex = 0;
            // 
            // lblTenDN
            // 
            this.lblTenDN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTenDN.AutoSize = true;
            this.lblTenDN.Font = new System.Drawing.Font("Arial", 10F);
            this.lblTenDN.Location = new System.Drawing.Point(10, 11);
            this.lblTenDN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenDN.Name = "lblTenDN";
            this.lblTenDN.Size = new System.Drawing.Size(104, 16);
            this.lblTenDN.TabIndex = 3;
            this.lblTenDN.Text = "Tên đăng nhập";
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(105, 154);
            this.panel6.TabIndex = 10;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(380, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(109, 154);
            this.panel7.TabIndex = 10;
            // 
            // ptbAvt
            // 
            this.ptbAvt.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptbAvt.Image = global::GUI.Properties.Resources.login_pic_64;
            this.ptbAvt.Location = new System.Drawing.Point(0, 0);
            this.ptbAvt.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ptbAvt.Name = "ptbAvt";
            this.ptbAvt.Size = new System.Drawing.Size(489, 79);
            this.ptbAvt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbAvt.TabIndex = 0;
            this.ptbAvt.TabStop = false;
            // 
            // formDangNhap
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(489, 297);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "formDangNhap";
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formDangNhap_FormClosing);
            this.Load += new System.EventHandler(this.formDangNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Panel panel2;
        private PictureBox ptbAvt;
        private Panel panel4;
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
    }
}