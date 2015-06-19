namespace QuanLyTiemVang.GUI
{
    partial class DangKyTaiKhoan
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
            this.btn_DangKyTaiKhoan = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.txt_TenDangNhap = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_XacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ThemMoi = new System.Windows.Forms.Button();
            this.lbl_LoiDangNhap = new System.Windows.Forms.Label();
            this.lbl_MatKhau = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_LoiEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_DangKyTaiKhoan
            // 
            this.btn_DangKyTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangKyTaiKhoan.ForeColor = System.Drawing.Color.Maroon;
            this.btn_DangKyTaiKhoan.Image = global::QuanLyTiemVang.Properties.Resources.Register;
            this.btn_DangKyTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DangKyTaiKhoan.Location = new System.Drawing.Point(29, 257);
            this.btn_DangKyTaiKhoan.Name = "btn_DangKyTaiKhoan";
            this.btn_DangKyTaiKhoan.Size = new System.Drawing.Size(103, 28);
            this.btn_DangKyTaiKhoan.TabIndex = 47;
            this.btn_DangKyTaiKhoan.Text = "Đăng ký";
            this.btn_DangKyTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DangKyTaiKhoan.UseVisualStyleBackColor = true;
            this.btn_DangKyTaiKhoan.Click += new System.EventHandler(this.btn_DangKyTaiKhoan_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Thoat.Image = global::QuanLyTiemVang.Properties.Resources.Close;
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(283, 257);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(82, 28);
            this.btn_Thoat.TabIndex = 46;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Location = new System.Drawing.Point(185, 130);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(98, 20);
            this.txt_MatKhau.TabIndex = 44;
            this.txt_MatKhau.UseSystemPasswordChar = true;
            this.txt_MatKhau.TextChanged += new System.EventHandler(this.txt_MatKhau_TextChanged);
            this.txt_MatKhau.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_MatKhau_KeyUp);
            // 
            // txt_TenDangNhap
            // 
            this.txt_TenDangNhap.Location = new System.Drawing.Point(185, 90);
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.Size = new System.Drawing.Size(98, 20);
            this.txt_TenDangNhap.TabIndex = 42;
            this.txt_TenDangNhap.TextChanged += new System.EventHandler(this.txt_TenDangNhap_TextChanged);
            this.txt_TenDangNhap.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_TenDangNhap_KeyUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(43, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(302, 31);
            this.label9.TabIndex = 43;
            this.label9.Text = "ĐĂNG KÝ TÀI KHOẢN";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(23, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 21);
            this.label14.TabIndex = 41;
            this.label14.Text = "Mật khẩu";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(23, 91);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(121, 21);
            this.label16.TabIndex = 40;
            this.label16.Text = "Tên đăng nhập";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(185, 207);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(98, 20);
            this.txt_Email.TabIndex = 51;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            this.txt_Email.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Email_KeyUp);
            // 
            // txt_XacNhanMatKhau
            // 
            this.txt_XacNhanMatKhau.Location = new System.Drawing.Point(185, 167);
            this.txt_XacNhanMatKhau.Name = "txt_XacNhanMatKhau";
            this.txt_XacNhanMatKhau.Size = new System.Drawing.Size(98, 20);
            this.txt_XacNhanMatKhau.TabIndex = 50;
            this.txt_XacNhanMatKhau.UseSystemPasswordChar = true;
            this.txt_XacNhanMatKhau.TextChanged += new System.EventHandler(this.txt_XacNhanMatKhau_TextChanged);
            this.txt_XacNhanMatKhau.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_XacNhanMatKhau_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(23, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 49;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(23, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 21);
            this.label2.TabIndex = 48;
            this.label2.Text = "Xác nhận mật khẩu";
            // 
            // btn_ThemMoi
            // 
            this.btn_ThemMoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemMoi.ForeColor = System.Drawing.Color.Maroon;
            this.btn_ThemMoi.Image = global::QuanLyTiemVang.Properties.Resources.New;
            this.btn_ThemMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThemMoi.Location = new System.Drawing.Point(148, 257);
            this.btn_ThemMoi.Name = "btn_ThemMoi";
            this.btn_ThemMoi.Size = new System.Drawing.Size(115, 28);
            this.btn_ThemMoi.TabIndex = 52;
            this.btn_ThemMoi.Text = "Thêm mới";
            this.btn_ThemMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ThemMoi.UseVisualStyleBackColor = true;
            this.btn_ThemMoi.Click += new System.EventHandler(this.btn_ThemMoi_Click);
            // 
            // lbl_LoiDangNhap
            // 
            this.lbl_LoiDangNhap.AutoSize = true;
            this.lbl_LoiDangNhap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoiDangNhap.ForeColor = System.Drawing.Color.Blue;
            this.lbl_LoiDangNhap.Location = new System.Drawing.Point(301, 90);
            this.lbl_LoiDangNhap.Name = "lbl_LoiDangNhap";
            this.lbl_LoiDangNhap.Size = new System.Drawing.Size(180, 21);
            this.lbl_LoiDangNhap.TabIndex = 53;
            this.lbl_LoiDangNhap.Text = "Nhập từ 6 ký tự trở lên";
            // 
            // lbl_MatKhau
            // 
            this.lbl_MatKhau.AutoSize = true;
            this.lbl_MatKhau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MatKhau.ForeColor = System.Drawing.Color.Blue;
            this.lbl_MatKhau.Location = new System.Drawing.Point(301, 129);
            this.lbl_MatKhau.Name = "lbl_MatKhau";
            this.lbl_MatKhau.Size = new System.Drawing.Size(180, 21);
            this.lbl_MatKhau.TabIndex = 54;
            this.lbl_MatKhau.Text = "Nhập từ 6 ký tự trở lên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(304, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 21);
            this.label5.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(304, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 21);
            this.label6.TabIndex = 56;
            // 
            // lbl_LoiEmail
            // 
            this.lbl_LoiEmail.AutoSize = true;
            this.lbl_LoiEmail.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoiEmail.ForeColor = System.Drawing.Color.Blue;
            this.lbl_LoiEmail.Location = new System.Drawing.Point(304, 207);
            this.lbl_LoiEmail.Name = "lbl_LoiEmail";
            this.lbl_LoiEmail.Size = new System.Drawing.Size(0, 21);
            this.lbl_LoiEmail.TabIndex = 57;
            // 
            // DangKyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(489, 312);
            this.Controls.Add(this.lbl_LoiEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_MatKhau);
            this.Controls.Add(this.lbl_LoiDangNhap);
            this.Controls.Add(this.btn_ThemMoi);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_XacNhanMatKhau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_DangKyTaiKhoan);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.txt_TenDangNhap);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DangKyTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_DangKyTaiKhoan;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.TextBox txt_TenDangNhap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_XacNhanMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ThemMoi;
        private System.Windows.Forms.Label lbl_LoiDangNhap;
        private System.Windows.Forms.Label lbl_MatKhau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_LoiEmail;
    }
}