namespace QuanLyTiemVang.GUI
{
    partial class PhieuDichVu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TongCong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_ChiTietPhieuDichVu = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.txt_TenKhachHang = new System.Windows.Forms.TextBox();
            this.txt_MaKhachHang = new System.Windows.Forms.TextBox();
            this.txt_MaPhieu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_NgayGiao = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_NgayDangKy = new System.Windows.Forms.DateTimePicker();
            this.btn_XoaPhieu = new System.Windows.Forms.Button();
            this.btn_TaoPhieuMoi = new System.Windows.Forms.Button();
            this.btn_LapPhieu = new System.Windows.Forms.Button();
            this.btnTraCuuKhachHang = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietPhieuDichVu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(272, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 31);
            this.label1.TabIndex = 31;
            this.label1.Text = "PHIẾU DỊCH VỤ";
            // 
            // txt_TongCong
            // 
            this.txt_TongCong.Enabled = false;
            this.txt_TongCong.Location = new System.Drawing.Point(111, 360);
            this.txt_TongCong.Multiline = true;
            this.txt_TongCong.Name = "txt_TongCong";
            this.txt_TongCong.ReadOnly = true;
            this.txt_TongCong.Size = new System.Drawing.Size(151, 26);
            this.txt_TongCong.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(13, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tổng cộng";
            // 
            // dgv_ChiTietPhieuDichVu
            // 
            this.dgv_ChiTietPhieuDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChiTietPhieuDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_ChiTietPhieuDichVu.Location = new System.Drawing.Point(17, 155);
            this.dgv_ChiTietPhieuDichVu.Name = "dgv_ChiTietPhieuDichVu";
            this.dgv_ChiTietPhieuDichVu.Size = new System.Drawing.Size(684, 189);
            this.dgv_ChiTietPhieuDichVu.TabIndex = 13;
            this.dgv_ChiTietPhieuDichVu.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ChiTietPhieuDichVu_CellEndEdit);
            // 
            // Column6
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Green;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column6.HeaderText = "STT";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 40;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Green;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Mã dịch vụ";
            this.Column1.Name = "Column1";
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Green;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "Tên dịch vụ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 203;
            // 
            // Column3
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Green;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "Số lượng";
            this.Column3.Name = "Column3";
            this.Column3.Width = 90;
            // 
            // Column4
            // 
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Green;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column4.HeaderText = "Đơn giá dịch vụ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 110;
            // 
            // Column5
            // 
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Green;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column5.HeaderText = "Thành tiền";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 120;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Enabled = false;
            this.txt_DiaChi.Location = new System.Drawing.Point(439, 112);
            this.txt_DiaChi.Multiline = true;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.ReadOnly = true;
            this.txt_DiaChi.Size = new System.Drawing.Size(263, 26);
            this.txt_DiaChi.TabIndex = 12;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Thoat.Image = global::QuanLyTiemVang.Properties.Resources.Close;
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(645, 528);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(85, 28);
            this.btn_Thoat.TabIndex = 37;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // txt_TenKhachHang
            // 
            this.txt_TenKhachHang.Enabled = false;
            this.txt_TenKhachHang.Location = new System.Drawing.Point(147, 110);
            this.txt_TenKhachHang.Multiline = true;
            this.txt_TenKhachHang.Name = "txt_TenKhachHang";
            this.txt_TenKhachHang.ReadOnly = true;
            this.txt_TenKhachHang.Size = new System.Drawing.Size(197, 26);
            this.txt_TenKhachHang.TabIndex = 11;
            // 
            // txt_MaKhachHang
            // 
            this.txt_MaKhachHang.Location = new System.Drawing.Point(142, 72);
            this.txt_MaKhachHang.Name = "txt_MaKhachHang";
            this.txt_MaKhachHang.Size = new System.Drawing.Size(202, 26);
            this.txt_MaKhachHang.TabIndex = 9;
            this.txt_MaKhachHang.TextChanged += new System.EventHandler(this.txt_MaKhachHang_TextChanged);
            // 
            // txt_MaPhieu
            // 
            this.txt_MaPhieu.Enabled = false;
            this.txt_MaPhieu.Location = new System.Drawing.Point(98, 33);
            this.txt_MaPhieu.Multiline = true;
            this.txt_MaPhieu.Name = "txt_MaPhieu";
            this.txt_MaPhieu.ReadOnly = true;
            this.txt_MaPhieu.Size = new System.Drawing.Size(246, 26);
            this.txt_MaPhieu.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(368, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(13, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(368, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày giao";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(13, 77);
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
            this.label3.Location = new System.Drawing.Point(368, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày đăng ký";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phiếu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker_NgayGiao);
            this.groupBox1.Controls.Add(this.dateTimePicker_NgayDangKy);
            this.groupBox1.Controls.Add(this.txt_TongCong);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dgv_ChiTietPhieuDichVu);
            this.groupBox1.Controls.Add(this.txt_DiaChi);
            this.groupBox1.Controls.Add(this.txt_TenKhachHang);
            this.groupBox1.Controls.Add(this.txt_MaKhachHang);
            this.groupBox1.Controls.Add(this.txt_MaPhieu);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 402);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu dịch vụ";
            // 
            // dateTimePicker_NgayGiao
            // 
            this.dateTimePicker_NgayGiao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_NgayGiao.Location = new System.Drawing.Point(459, 72);
            this.dateTimePicker_NgayGiao.Name = "dateTimePicker_NgayGiao";
            this.dateTimePicker_NgayGiao.Size = new System.Drawing.Size(242, 26);
            this.dateTimePicker_NgayGiao.TabIndex = 19;
            // 
            // dateTimePicker_NgayDangKy
            // 
            this.dateTimePicker_NgayDangKy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_NgayDangKy.Location = new System.Drawing.Point(487, 32);
            this.dateTimePicker_NgayDangKy.Name = "dateTimePicker_NgayDangKy";
            this.dateTimePicker_NgayDangKy.Size = new System.Drawing.Size(214, 26);
            this.dateTimePicker_NgayDangKy.TabIndex = 18;
            // 
            // btn_XoaPhieu
            // 
            this.btn_XoaPhieu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaPhieu.ForeColor = System.Drawing.Color.Maroon;
            this.btn_XoaPhieu.Image = global::QuanLyTiemVang.Properties.Resources.Delete;
            this.btn_XoaPhieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaPhieu.Location = new System.Drawing.Point(614, 484);
            this.btn_XoaPhieu.Name = "btn_XoaPhieu";
            this.btn_XoaPhieu.Size = new System.Drawing.Size(116, 28);
            this.btn_XoaPhieu.TabIndex = 35;
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
            this.btn_TaoPhieuMoi.Location = new System.Drawing.Point(323, 484);
            this.btn_TaoPhieuMoi.Name = "btn_TaoPhieuMoi";
            this.btn_TaoPhieuMoi.Size = new System.Drawing.Size(146, 28);
            this.btn_TaoPhieuMoi.TabIndex = 34;
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
            this.btn_LapPhieu.Location = new System.Drawing.Point(46, 484);
            this.btn_LapPhieu.Name = "btn_LapPhieu";
            this.btn_LapPhieu.Size = new System.Drawing.Size(119, 28);
            this.btn_LapPhieu.TabIndex = 33;
            this.btn_LapPhieu.Text = "Lập phiếu ";
            this.btn_LapPhieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_LapPhieu.UseVisualStyleBackColor = true;
            this.btn_LapPhieu.Click += new System.EventHandler(this.btn_LapPhieu_Click);
            // 
            // btnTraCuuKhachHang
            // 
            this.btnTraCuuKhachHang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuKhachHang.ForeColor = System.Drawing.Color.Maroon;
            this.btnTraCuuKhachHang.Image = global::QuanLyTiemVang.Properties.Resources.Search;
            this.btnTraCuuKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraCuuKhachHang.Location = new System.Drawing.Point(46, 528);
            this.btnTraCuuKhachHang.Name = "btnTraCuuKhachHang";
            this.btnTraCuuKhachHang.Size = new System.Drawing.Size(182, 28);
            this.btnTraCuuKhachHang.TabIndex = 36;
            this.btnTraCuuKhachHang.Text = "Tra cứu khách hàng";
            this.btnTraCuuKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTraCuuKhachHang.UseVisualStyleBackColor = true;
            this.btnTraCuuKhachHang.Click += new System.EventHandler(this.btnTraCuuKhachHang_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Image = global::QuanLyTiemVang.Properties.Resources.Danhsach;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(364, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 28);
            this.button1.TabIndex = 40;
            this.button1.Text = "Thêm khách hàng";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PhieuDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(778, 576);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_XoaPhieu);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_TaoPhieuMoi);
            this.Controls.Add(this.btn_LapPhieu);
            this.Controls.Add(this.btnTraCuuKhachHang);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PhieuDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PhieuDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietPhieuDichVu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_XoaPhieu;
        private System.Windows.Forms.TextBox txt_TongCong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_ChiTietPhieuDichVu;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.TextBox txt_TenKhachHang;
        private System.Windows.Forms.TextBox txt_MaKhachHang;
        private System.Windows.Forms.TextBox txt_MaPhieu;
        private System.Windows.Forms.Button btn_TaoPhieuMoi;
        private System.Windows.Forms.Button btn_LapPhieu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTraCuuKhachHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayGiao;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button button1;
    }
}