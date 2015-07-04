namespace QuanLyTiemVang.GUI
{
    partial class PhieuMuaHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_TenKhachHang = new System.Windows.Forms.TextBox();
            this.txt_MaKhachHang = new System.Windows.Forms.TextBox();
            this.txt_MaPhieu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TongCong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_ChiTietPhieuMuaHang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker_NgayThanhToan = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_NgayMua = new System.Windows.Forms.DateTimePicker();
            this.btn_TraCuuKhachHang = new System.Windows.Forms.Button();
            this.btn_XoaPhieu = new System.Windows.Forms.Button();
            this.btn_TaoPhieuMoi = new System.Windows.Forms.Button();
            this.btn_LapPhieu = new System.Windows.Forms.Button();
            this.btn_TraCuuSanPham = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietPhieuMuaHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(312, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 31);
            this.label1.TabIndex = 31;
            this.label1.Text = "PHIẾU MUA HÀNG";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Enabled = false;
            this.txt_DiaChi.Location = new System.Drawing.Point(492, 112);
            this.txt_DiaChi.Multiline = true;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.ReadOnly = true;
            this.txt_DiaChi.Size = new System.Drawing.Size(313, 26);
            this.txt_DiaChi.TabIndex = 12;
            // 
            // txt_TenKhachHang
            // 
            this.txt_TenKhachHang.Enabled = false;
            this.txt_TenKhachHang.Location = new System.Drawing.Point(147, 110);
            this.txt_TenKhachHang.Multiline = true;
            this.txt_TenKhachHang.Name = "txt_TenKhachHang";
            this.txt_TenKhachHang.ReadOnly = true;
            this.txt_TenKhachHang.Size = new System.Drawing.Size(257, 26);
            this.txt_TenKhachHang.TabIndex = 11;
            // 
            // txt_MaKhachHang
            // 
            this.txt_MaKhachHang.Location = new System.Drawing.Point(142, 72);
            this.txt_MaKhachHang.Name = "txt_MaKhachHang";
            this.txt_MaKhachHang.Size = new System.Drawing.Size(262, 26);
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
            this.txt_MaPhieu.Size = new System.Drawing.Size(306, 26);
            this.txt_MaPhieu.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(421, 117);
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
            this.label5.Location = new System.Drawing.Point(421, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày thanh toán";
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
            this.label3.Location = new System.Drawing.Point(421, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày mua";
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
            // txt_TongCong
            // 
            this.txt_TongCong.Enabled = false;
            this.txt_TongCong.Location = new System.Drawing.Point(111, 360);
            this.txt_TongCong.Multiline = true;
            this.txt_TongCong.Name = "txt_TongCong";
            this.txt_TongCong.ReadOnly = true;
            this.txt_TongCong.Size = new System.Drawing.Size(169, 26);
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
            // btn_Thoat
            // 
            this.btn_Thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Thoat.Image = global::QuanLyTiemVang.Properties.Resources.Close;
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(748, 528);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(85, 28);
            this.btn_Thoat.TabIndex = 38;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_ChiTietPhieuMuaHang);
            this.groupBox1.Controls.Add(this.dateTimePicker_NgayThanhToan);
            this.groupBox1.Controls.Add(this.dateTimePicker_NgayMua);
            this.groupBox1.Controls.Add(this.txt_TongCong);
            this.groupBox1.Controls.Add(this.label8);
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
            this.groupBox1.Size = new System.Drawing.Size(820, 402);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu mua hàng";
            // 
            // dgv_ChiTietPhieuMuaHang
            // 
            this.dgv_ChiTietPhieuMuaHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChiTietPhieuMuaHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.MaSanPham,
            this.TenSanPham,
            this.LoaiSanPham,
            this.SoLuongTon,
            this.SoLuongBan,
            this.DonGiaBan,
            this.ThanhTien});
            this.dgv_ChiTietPhieuMuaHang.Location = new System.Drawing.Point(17, 155);
            this.dgv_ChiTietPhieuMuaHang.Name = "dgv_ChiTietPhieuMuaHang";
            this.dgv_ChiTietPhieuMuaHang.Size = new System.Drawing.Size(788, 185);
            this.dgv_ChiTietPhieuMuaHang.TabIndex = 19;
            this.dgv_ChiTietPhieuMuaHang.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ChiTietPhieuMuaHang_CellEndEdit);
            // 
            // Column1
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Green;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // MaSanPham
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Green;
            this.MaSanPham.DefaultCellStyle = dataGridViewCellStyle2;
            this.MaSanPham.HeaderText = "Mã sản phẩm";
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.Width = 78;
            // 
            // TenSanPham
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Green;
            this.TenSanPham.DefaultCellStyle = dataGridViewCellStyle3;
            this.TenSanPham.HeaderText = "Tên sản phẩm";
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.ReadOnly = true;
            this.TenSanPham.Width = 168;
            // 
            // LoaiSanPham
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Green;
            this.LoaiSanPham.DefaultCellStyle = dataGridViewCellStyle4;
            this.LoaiSanPham.HeaderText = "Loại sản phẩm";
            this.LoaiSanPham.Name = "LoaiSanPham";
            this.LoaiSanPham.ReadOnly = true;
            // 
            // SoLuongTon
            // 
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Green;
            this.SoLuongTon.DefaultCellStyle = dataGridViewCellStyle5;
            this.SoLuongTon.HeaderText = "Số lượng tồn";
            this.SoLuongTon.Name = "SoLuongTon";
            this.SoLuongTon.ReadOnly = true;
            this.SoLuongTon.Width = 87;
            // 
            // SoLuongBan
            // 
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Green;
            this.SoLuongBan.DefaultCellStyle = dataGridViewCellStyle6;
            this.SoLuongBan.HeaderText = "Số lượng mua";
            this.SoLuongBan.Name = "SoLuongBan";
            this.SoLuongBan.Width = 90;
            // 
            // DonGiaBan
            // 
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Green;
            this.DonGiaBan.DefaultCellStyle = dataGridViewCellStyle7;
            this.DonGiaBan.HeaderText = "Đơn giá mua";
            this.DonGiaBan.Name = "DonGiaBan";
            this.DonGiaBan.Width = 85;
            // 
            // ThanhTien
            // 
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Green;
            this.ThanhTien.DefaultCellStyle = dataGridViewCellStyle8;
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            this.ThanhTien.Width = 85;
            // 
            // dateTimePicker_NgayThanhToan
            // 
            this.dateTimePicker_NgayThanhToan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_NgayThanhToan.Location = new System.Drawing.Point(558, 72);
            this.dateTimePicker_NgayThanhToan.Name = "dateTimePicker_NgayThanhToan";
            this.dateTimePicker_NgayThanhToan.Size = new System.Drawing.Size(246, 26);
            this.dateTimePicker_NgayThanhToan.TabIndex = 18;
            // 
            // dateTimePicker_NgayMua
            // 
            this.dateTimePicker_NgayMua.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_NgayMua.Location = new System.Drawing.Point(512, 32);
            this.dateTimePicker_NgayMua.Name = "dateTimePicker_NgayMua";
            this.dateTimePicker_NgayMua.Size = new System.Drawing.Size(292, 26);
            this.dateTimePicker_NgayMua.TabIndex = 17;
            // 
            // btn_TraCuuKhachHang
            // 
            this.btn_TraCuuKhachHang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TraCuuKhachHang.ForeColor = System.Drawing.Color.Maroon;
            this.btn_TraCuuKhachHang.Image = global::QuanLyTiemVang.Properties.Resources.Search;
            this.btn_TraCuuKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TraCuuKhachHang.Location = new System.Drawing.Point(46, 528);
            this.btn_TraCuuKhachHang.Name = "btn_TraCuuKhachHang";
            this.btn_TraCuuKhachHang.Size = new System.Drawing.Size(182, 28);
            this.btn_TraCuuKhachHang.TabIndex = 36;
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
            this.btn_XoaPhieu.Location = new System.Drawing.Point(717, 484);
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
            this.btn_TaoPhieuMoi.Location = new System.Drawing.Point(380, 484);
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
            // btn_TraCuuSanPham
            // 
            this.btn_TraCuuSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TraCuuSanPham.ForeColor = System.Drawing.Color.Maroon;
            this.btn_TraCuuSanPham.Image = global::QuanLyTiemVang.Properties.Resources.Search;
            this.btn_TraCuuSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TraCuuSanPham.Location = new System.Drawing.Point(290, 528);
            this.btn_TraCuuSanPham.Name = "btn_TraCuuSanPham";
            this.btn_TraCuuSanPham.Size = new System.Drawing.Size(170, 28);
            this.btn_TraCuuSanPham.TabIndex = 37;
            this.btn_TraCuuSanPham.Text = "Tra cứu sản phẩm";
            this.btn_TraCuuSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TraCuuSanPham.UseVisualStyleBackColor = true;
            this.btn_TraCuuSanPham.Click += new System.EventHandler(this.btn_TraCuuSanPham_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Image = global::QuanLyTiemVang.Properties.Resources.Danhsach;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(518, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 28);
            this.button1.TabIndex = 39;
            this.button1.Text = "Thêm khách hàng";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PhieuMuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.CancelButton = this.btn_Thoat;
            this.ClientSize = new System.Drawing.Size(877, 576);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_TraCuuKhachHang);
            this.Controls.Add(this.btn_XoaPhieu);
            this.Controls.Add(this.btn_TaoPhieuMoi);
            this.Controls.Add(this.btn_LapPhieu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_TraCuuSanPham);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PhieuMuaHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PhieuMuaHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietPhieuMuaHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_TenKhachHang;
        private System.Windows.Forms.TextBox txt_MaKhachHang;
        private System.Windows.Forms.TextBox txt_MaPhieu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TongCong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_TraCuuKhachHang;
        private System.Windows.Forms.Button btn_XoaPhieu;
        private System.Windows.Forms.Button btn_TaoPhieuMoi;
        private System.Windows.Forms.Button btn_LapPhieu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_TraCuuSanPham;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayThanhToan;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayMua;
        private System.Windows.Forms.DataGridView dgv_ChiTietPhieuMuaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Button button1;
    }
}