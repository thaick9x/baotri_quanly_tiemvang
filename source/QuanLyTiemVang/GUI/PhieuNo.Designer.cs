namespace QuanLyTiemVang.GUI
{
    partial class PhieuNo
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
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SoTienConLai = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_SoTienTra = new System.Windows.Forms.TextBox();
            this.txt_SoTienNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_TenKhachHang = new System.Windows.Forms.TextBox();
            this.txt_MaKhachHang = new System.Windows.Forms.TextBox();
            this.txt_MaPhieuBanHang = new System.Windows.Forms.TextBox();
            this.txt_MaPhieuNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_LoaiKhachHang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker_NgayTra = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_NgayNo = new System.Windows.Forms.DateTimePicker();
            this.btn_TraCuuKhachHang = new System.Windows.Forms.Button();
            this.btn_XoaPhieu = new System.Windows.Forms.Button();
            this.btn_TaoPhieuMoi = new System.Windows.Forms.Button();
            this.btn_LapPhieu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Thoat.Image = global::QuanLyTiemVang.Properties.Resources.Close;
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(644, 392);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(83, 28);
            this.btn_Thoat.TabIndex = 31;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(314, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 31);
            this.label1.TabIndex = 26;
            this.label1.Text = "PHIẾU NỢ";
            // 
            // txt_SoTienConLai
            // 
            this.txt_SoTienConLai.Location = new System.Drawing.Point(491, 196);
            this.txt_SoTienConLai.Multiline = true;
            this.txt_SoTienConLai.Name = "txt_SoTienConLai";
            this.txt_SoTienConLai.ReadOnly = true;
            this.txt_SoTienConLai.Size = new System.Drawing.Size(211, 26);
            this.txt_SoTienConLai.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(369, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 21);
            this.label11.TabIndex = 20;
            this.label11.Text = "Số tiền còn lại";
            // 
            // txt_SoTienTra
            // 
            this.txt_SoTienTra.Location = new System.Drawing.Point(105, 196);
            this.txt_SoTienTra.Name = "txt_SoTienTra";
            this.txt_SoTienTra.Size = new System.Drawing.Size(242, 26);
            this.txt_SoTienTra.TabIndex = 19;
            this.txt_SoTienTra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_SoTienTra_KeyUp);
            // 
            // txt_SoTienNo
            // 
            this.txt_SoTienNo.Location = new System.Drawing.Point(105, 153);
            this.txt_SoTienNo.Multiline = true;
            this.txt_SoTienNo.Name = "txt_SoTienNo";
            this.txt_SoTienNo.ReadOnly = true;
            this.txt_SoTienNo.Size = new System.Drawing.Size(241, 26);
            this.txt_SoTienNo.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(13, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "Số tiền trả";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(13, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 21);
            this.label10.TabIndex = 16;
            this.label10.Text = "Số tiền nợ";
            // 
            // txt_TenKhachHang
            // 
            this.txt_TenKhachHang.Location = new System.Drawing.Point(505, 74);
            this.txt_TenKhachHang.Multiline = true;
            this.txt_TenKhachHang.Name = "txt_TenKhachHang";
            this.txt_TenKhachHang.ReadOnly = true;
            this.txt_TenKhachHang.Size = new System.Drawing.Size(197, 26);
            this.txt_TenKhachHang.TabIndex = 10;
            // 
            // txt_MaKhachHang
            // 
            this.txt_MaKhachHang.Location = new System.Drawing.Point(142, 75);
            this.txt_MaKhachHang.Multiline = true;
            this.txt_MaKhachHang.Name = "txt_MaKhachHang";
            this.txt_MaKhachHang.ReadOnly = true;
            this.txt_MaKhachHang.Size = new System.Drawing.Size(204, 26);
            this.txt_MaKhachHang.TabIndex = 9;
            // 
            // txt_MaPhieuBanHang
            // 
            this.txt_MaPhieuBanHang.Location = new System.Drawing.Point(525, 35);
            this.txt_MaPhieuBanHang.Name = "txt_MaPhieuBanHang";
            this.txt_MaPhieuBanHang.Size = new System.Drawing.Size(177, 26);
            this.txt_MaPhieuBanHang.TabIndex = 8;
            this.txt_MaPhieuBanHang.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_MaPhieuBanHang_KeyUp);
            // 
            // txt_MaPhieuNo
            // 
            this.txt_MaPhieuNo.Location = new System.Drawing.Point(122, 36);
            this.txt_MaPhieuNo.Multiline = true;
            this.txt_MaPhieuNo.Name = "txt_MaPhieuNo";
            this.txt_MaPhieuNo.ReadOnly = true;
            this.txt_MaPhieuNo.Size = new System.Drawing.Size(224, 26);
            this.txt_MaPhieuNo.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(369, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày trả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(369, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày nợ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(368, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(13, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(368, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã phiếu bán hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phiếu nợ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_LoaiKhachHang);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dateTimePicker_NgayTra);
            this.groupBox1.Controls.Add(this.dateTimePicker_NgayNo);
            this.groupBox1.Controls.Add(this.txt_SoTienConLai);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_SoTienTra);
            this.groupBox1.Controls.Add(this.txt_SoTienNo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_TenKhachHang);
            this.groupBox1.Controls.Add(this.txt_MaKhachHang);
            this.groupBox1.Controls.Add(this.txt_MaPhieuBanHang);
            this.groupBox1.Controls.Add(this.txt_MaPhieuNo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 237);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu nợ";
            // 
            // txt_LoaiKhachHang
            // 
            this.txt_LoaiKhachHang.Location = new System.Drawing.Point(149, 113);
            this.txt_LoaiKhachHang.Multiline = true;
            this.txt_LoaiKhachHang.Name = "txt_LoaiKhachHang";
            this.txt_LoaiKhachHang.ReadOnly = true;
            this.txt_LoaiKhachHang.Size = new System.Drawing.Size(197, 26);
            this.txt_LoaiKhachHang.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(13, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 21);
            this.label8.TabIndex = 24;
            this.label8.Text = "Loại khách hàng";
            // 
            // dateTimePicker_NgayTra
            // 
            this.dateTimePicker_NgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_NgayTra.Location = new System.Drawing.Point(448, 151);
            this.dateTimePicker_NgayTra.Name = "dateTimePicker_NgayTra";
            this.dateTimePicker_NgayTra.Size = new System.Drawing.Size(255, 26);
            this.dateTimePicker_NgayTra.TabIndex = 23;
            // 
            // dateTimePicker_NgayNo
            // 
            this.dateTimePicker_NgayNo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_NgayNo.Location = new System.Drawing.Point(448, 113);
            this.dateTimePicker_NgayNo.Name = "dateTimePicker_NgayNo";
            this.dateTimePicker_NgayNo.Size = new System.Drawing.Size(254, 26);
            this.dateTimePicker_NgayNo.TabIndex = 22;
            // 
            // btn_TraCuuKhachHang
            // 
            this.btn_TraCuuKhachHang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TraCuuKhachHang.ForeColor = System.Drawing.Color.Maroon;
            this.btn_TraCuuKhachHang.Image = global::QuanLyTiemVang.Properties.Resources.Search;
            this.btn_TraCuuKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TraCuuKhachHang.Location = new System.Drawing.Point(43, 392);
            this.btn_TraCuuKhachHang.Name = "btn_TraCuuKhachHang";
            this.btn_TraCuuKhachHang.Size = new System.Drawing.Size(184, 28);
            this.btn_TraCuuKhachHang.TabIndex = 30;
            this.btn_TraCuuKhachHang.Text = "Tra cứu khách hàng";
            this.btn_TraCuuKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TraCuuKhachHang.UseVisualStyleBackColor = true;
            this.btn_TraCuuKhachHang.Click += new System.EventHandler(this.btn_TraCuuKhachHang_Click);
            // 
            // btn_XoaPhieu
            // 
            this.btn_XoaPhieu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaPhieu.ForeColor = System.Drawing.Color.Maroon;
            this.btn_XoaPhieu.Image = global::QuanLyTiemVang.Properties.Resources.Delete;
            this.btn_XoaPhieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaPhieu.Location = new System.Drawing.Point(611, 347);
            this.btn_XoaPhieu.Name = "btn_XoaPhieu";
            this.btn_XoaPhieu.Size = new System.Drawing.Size(116, 28);
            this.btn_XoaPhieu.TabIndex = 29;
            this.btn_XoaPhieu.Text = "Xóa phiếu";
            this.btn_XoaPhieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_XoaPhieu.UseVisualStyleBackColor = true;
            this.btn_XoaPhieu.Click += new System.EventHandler(this.btn_XoaPhieu_Click);
            // 
            // btn_TaoPhieuMoi
            // 
            this.btn_TaoPhieuMoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoPhieuMoi.ForeColor = System.Drawing.Color.Maroon;
            this.btn_TaoPhieuMoi.Image = global::QuanLyTiemVang.Properties.Resources.New;
            this.btn_TaoPhieuMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TaoPhieuMoi.Location = new System.Drawing.Point(330, 347);
            this.btn_TaoPhieuMoi.Name = "btn_TaoPhieuMoi";
            this.btn_TaoPhieuMoi.Size = new System.Drawing.Size(144, 28);
            this.btn_TaoPhieuMoi.TabIndex = 28;
            this.btn_TaoPhieuMoi.Text = "Tạo phiếu mới";
            this.btn_TaoPhieuMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TaoPhieuMoi.UseVisualStyleBackColor = true;
            this.btn_TaoPhieuMoi.Click += new System.EventHandler(this.btn_TaoPhieuMoi_Click);
            // 
            // btn_LapPhieu
            // 
            this.btn_LapPhieu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LapPhieu.ForeColor = System.Drawing.Color.Maroon;
            this.btn_LapPhieu.Image = global::QuanLyTiemVang.Properties.Resources.Add;
            this.btn_LapPhieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LapPhieu.Location = new System.Drawing.Point(43, 347);
            this.btn_LapPhieu.Name = "btn_LapPhieu";
            this.btn_LapPhieu.Size = new System.Drawing.Size(122, 28);
            this.btn_LapPhieu.TabIndex = 27;
            this.btn_LapPhieu.Text = "Lập phiếu ";
            this.btn_LapPhieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_LapPhieu.UseVisualStyleBackColor = true;
            this.btn_LapPhieu.Click += new System.EventHandler(this.btn_LapPhieu_Click);
            // 
            // PhieuNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(778, 454);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_TraCuuKhachHang);
            this.Controls.Add(this.btn_XoaPhieu);
            this.Controls.Add(this.btn_TaoPhieuMoi);
            this.Controls.Add(this.btn_LapPhieu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PhieuNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PhieuNo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_TraCuuKhachHang;
        private System.Windows.Forms.Button btn_XoaPhieu;
        private System.Windows.Forms.Button btn_TaoPhieuMoi;
        private System.Windows.Forms.Button btn_LapPhieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SoTienConLai;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_SoTienTra;
        private System.Windows.Forms.TextBox txt_SoTienNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_TenKhachHang;
        private System.Windows.Forms.TextBox txt_MaKhachHang;
        private System.Windows.Forms.TextBox txt_MaPhieuBanHang;
        private System.Windows.Forms.TextBox txt_MaPhieuNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayTra;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayNo;
        private System.Windows.Forms.TextBox txt_LoaiKhachHang;
        private System.Windows.Forms.Label label8;
    }
}