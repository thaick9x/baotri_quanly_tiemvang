namespace QuanLyTiemVang.GUI
{
    partial class DangNhap
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
            this.txt_TenDangNhap = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.btn_DangKyTaiKhoan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_TenDangNhap
            // 
            this.txt_TenDangNhap.Location = new System.Drawing.Point(210, 78);
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.Size = new System.Drawing.Size(180, 20);
            this.txt_TenDangNhap.TabIndex = 1;
            
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(153, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 31);
            this.label9.TabIndex = 31;
            this.label9.Text = "ĐĂNG NHẬP";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(83, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 21);
            this.label14.TabIndex = 28;
            this.label14.Text = "Mật khẩu";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(83, 79);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(121, 21);
            this.label16.TabIndex = 27;
            this.label16.Text = "Tên đăng nhập";
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Location = new System.Drawing.Point(210, 118);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(180, 20);
            this.txt_MatKhau.TabIndex = 2;
            this.txt_MatKhau.UseSystemPasswordChar = true;
            
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Thoat.Image = global::QuanLyTiemVang.Properties.Resources.Close;
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(371, 169);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(83, 28);
            this.btn_Thoat.TabIndex = 5;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_DangNhap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.ForeColor = System.Drawing.Color.Maroon;
            this.btn_DangNhap.Image = global::QuanLyTiemVang.Properties.Resources.Login;
            this.btn_DangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DangNhap.Location = new System.Drawing.Point(22, 169);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(120, 28);
            this.btn_DangNhap.TabIndex = 3;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // btn_DangKyTaiKhoan
            // 
            this.btn_DangKyTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangKyTaiKhoan.ForeColor = System.Drawing.Color.Maroon;
            this.btn_DangKyTaiKhoan.Image = global::QuanLyTiemVang.Properties.Resources.Register;
            this.btn_DangKyTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DangKyTaiKhoan.Location = new System.Drawing.Point(166, 169);
            this.btn_DangKyTaiKhoan.Name = "btn_DangKyTaiKhoan";
            this.btn_DangKyTaiKhoan.Size = new System.Drawing.Size(176, 28);
            this.btn_DangKyTaiKhoan.TabIndex = 4;
            this.btn_DangKyTaiKhoan.Text = "Đăng ký tài khoản";
            this.btn_DangKyTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DangKyTaiKhoan.UseVisualStyleBackColor = true;
            this.btn_DangKyTaiKhoan.Click += new System.EventHandler(this.btn_DangKyTaiKhoan_Click);
            // 
            // DangNhap
            // 
            this.AcceptButton = this.btn_DangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.CancelButton = this.btn_Thoat;
            this.ClientSize = new System.Drawing.Size(481, 237);
            this.Controls.Add(this.btn_DangKyTaiKhoan);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.txt_TenDangNhap);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_TenDangNhap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Button btn_DangKyTaiKhoan;
    }
}