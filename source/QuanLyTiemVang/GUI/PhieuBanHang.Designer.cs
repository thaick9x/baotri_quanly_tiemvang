namespace QuanLyTiemVang.GUI
{
    partial class PhieuBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuBanHang));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_TienNoSauKhiThanhToan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SoTienThanhToan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_ChiTietPhieuBanHang = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker_NgayThanhToan = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_NgayBan = new System.Windows.Forms.DateTimePicker();
            this.txt_TongCong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_TenKhachHang = new System.Windows.Forms.TextBox();
            this.txt_MaKhachHang = new System.Windows.Forms.TextBox();
            this.txt_MaPhieu = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_TraCuuKhachHang = new System.Windows.Forms.Button();
            this.btn_XoaPhieu = new System.Windows.Forms.Button();
            this.btn_TaoPhieuMoi = new System.Windows.Forms.Button();
            this.btn_LapPhieu = new System.Windows.Forms.Button();
            this.btn_TraCuuSanPham = new System.Windows.Forms.Button();
            this.btn_LapPhieuNo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietPhieuBanHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_TienNoSauKhiThanhToan);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_SoTienThanhToan);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dgv_ChiTietPhieuBanHang);
            this.groupBox2.Controls.Add(this.dateTimePicker_NgayThanhToan);
            this.groupBox2.Controls.Add(this.dateTimePicker_NgayBan);
            this.groupBox2.Controls.Add(this.txt_TongCong);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_DiaChi);
            this.groupBox2.Controls.Add(this.txt_TenKhachHang);
            this.groupBox2.Controls.Add(this.txt_MaKhachHang);
            this.groupBox2.Controls.Add(this.txt_MaPhieu);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // txt_TienNoSauKhiThanhToan
            // 
            this.txt_TienNoSauKhiThanhToan.ForeColor = System.Drawing.Color.Green;
            resources.ApplyResources(this.txt_TienNoSauKhiThanhToan, "txt_TienNoSauKhiThanhToan");
            this.txt_TienNoSauKhiThanhToan.Name = "txt_TienNoSauKhiThanhToan";
            this.txt_TienNoSauKhiThanhToan.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Name = "label2";
            // 
            // txt_SoTienThanhToan
            // 
            this.txt_SoTienThanhToan.ForeColor = System.Drawing.Color.Green;
            resources.ApplyResources(this.txt_SoTienThanhToan, "txt_SoTienThanhToan");
            this.txt_SoTienThanhToan.Name = "txt_SoTienThanhToan";
            this.txt_SoTienThanhToan.TextChanged += new System.EventHandler(this.txt_SoTienThanhToan_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Name = "label1";
            // 
            // dgv_ChiTietPhieuBanHang
            // 
            this.dgv_ChiTietPhieuBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChiTietPhieuBanHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaSanPham,
            this.TenSanPham,
            this.LoaiSanPham,
            this.SoLuongTon,
            this.SoLuongBan,
            this.DonGiaBan,
            this.ThanhTien});
            resources.ApplyResources(this.dgv_ChiTietPhieuBanHang, "dgv_ChiTietPhieuBanHang");
            this.dgv_ChiTietPhieuBanHang.MultiSelect = false;
            this.dgv_ChiTietPhieuBanHang.Name = "dgv_ChiTietPhieuBanHang";
            this.dgv_ChiTietPhieuBanHang.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ChiTietPhieuBanHang_CellEndEdit);
            // 
            // STT
            // 
            resources.ApplyResources(this.STT, "STT");
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // MaSanPham
            // 
            resources.ApplyResources(this.MaSanPham, "MaSanPham");
            this.MaSanPham.Name = "MaSanPham";
            // 
            // TenSanPham
            // 
            resources.ApplyResources(this.TenSanPham, "TenSanPham");
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.ReadOnly = true;
            // 
            // LoaiSanPham
            // 
            resources.ApplyResources(this.LoaiSanPham, "LoaiSanPham");
            this.LoaiSanPham.Name = "LoaiSanPham";
            this.LoaiSanPham.ReadOnly = true;
            // 
            // SoLuongTon
            // 
            resources.ApplyResources(this.SoLuongTon, "SoLuongTon");
            this.SoLuongTon.Name = "SoLuongTon";
            this.SoLuongTon.ReadOnly = true;
            // 
            // SoLuongBan
            // 
            resources.ApplyResources(this.SoLuongBan, "SoLuongBan");
            this.SoLuongBan.Name = "SoLuongBan";
            // 
            // DonGiaBan
            // 
            resources.ApplyResources(this.DonGiaBan, "DonGiaBan");
            this.DonGiaBan.Name = "DonGiaBan";
            // 
            // ThanhTien
            // 
            resources.ApplyResources(this.ThanhTien, "ThanhTien");
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // dateTimePicker_NgayThanhToan
            // 
            this.dateTimePicker_NgayThanhToan.CalendarForeColor = System.Drawing.Color.DarkGreen;
            this.dateTimePicker_NgayThanhToan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dateTimePicker_NgayThanhToan, "dateTimePicker_NgayThanhToan");
            this.dateTimePicker_NgayThanhToan.Name = "dateTimePicker_NgayThanhToan";
            // 
            // dateTimePicker_NgayBan
            // 
            this.dateTimePicker_NgayBan.CalendarForeColor = System.Drawing.Color.DarkGreen;
            this.dateTimePicker_NgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dateTimePicker_NgayBan, "dateTimePicker_NgayBan");
            this.dateTimePicker_NgayBan.Name = "dateTimePicker_NgayBan";
            // 
            // txt_TongCong
            // 
            this.txt_TongCong.ForeColor = System.Drawing.Color.Green;
            resources.ApplyResources(this.txt_TongCong, "txt_TongCong");
            this.txt_TongCong.Name = "txt_TongCong";
            this.txt_TongCong.ReadOnly = true;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Name = "label10";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.ForeColor = System.Drawing.Color.Green;
            resources.ApplyResources(this.txt_DiaChi, "txt_DiaChi");
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.ReadOnly = true;
            // 
            // txt_TenKhachHang
            // 
            this.txt_TenKhachHang.ForeColor = System.Drawing.Color.DarkGreen;
            resources.ApplyResources(this.txt_TenKhachHang, "txt_TenKhachHang");
            this.txt_TenKhachHang.Name = "txt_TenKhachHang";
            this.txt_TenKhachHang.ReadOnly = true;
            // 
            // txt_MaKhachHang
            // 
            resources.ApplyResources(this.txt_MaKhachHang, "txt_MaKhachHang");
            this.txt_MaKhachHang.ForeColor = System.Drawing.Color.Green;
            this.txt_MaKhachHang.Name = "txt_MaKhachHang";
            this.txt_MaKhachHang.TextChanged += new System.EventHandler(this.txt_MaKhachHang_TextChanged);
            // 
            // txt_MaPhieu
            // 
            this.txt_MaPhieu.ForeColor = System.Drawing.Color.Green;
            resources.ApplyResources(this.txt_MaPhieu, "txt_MaPhieu");
            this.txt_MaPhieu.Name = "txt_MaPhieu";
            this.txt_MaPhieu.ReadOnly = true;
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Name = "label11";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Name = "label12";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Name = "label13";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Name = "label14";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Name = "label15";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Name = "label16";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Name = "label9";
            // 
            // btn_Thoat
            // 
            resources.ApplyResources(this.btn_Thoat, "btn_Thoat");
            this.btn_Thoat.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Thoat.Image = global::QuanLyTiemVang.Properties.Resources.Close;
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_TraCuuKhachHang
            // 
            resources.ApplyResources(this.btn_TraCuuKhachHang, "btn_TraCuuKhachHang");
            this.btn_TraCuuKhachHang.ForeColor = System.Drawing.Color.Maroon;
            this.btn_TraCuuKhachHang.Image = global::QuanLyTiemVang.Properties.Resources.Search;
            this.btn_TraCuuKhachHang.Name = "btn_TraCuuKhachHang";
            this.btn_TraCuuKhachHang.UseVisualStyleBackColor = true;
            this.btn_TraCuuKhachHang.Click += new System.EventHandler(this.btn_TraCuuKhachHang_Click);
            // 
            // btn_XoaPhieu
            // 
            resources.ApplyResources(this.btn_XoaPhieu, "btn_XoaPhieu");
            this.btn_XoaPhieu.ForeColor = System.Drawing.Color.Maroon;
            this.btn_XoaPhieu.Image = global::QuanLyTiemVang.Properties.Resources.Delete;
            this.btn_XoaPhieu.Name = "btn_XoaPhieu";
            this.btn_XoaPhieu.UseVisualStyleBackColor = true;
            this.btn_XoaPhieu.Click += new System.EventHandler(this.btn_XoaPhieu_Click);
            // 
            // btn_TaoPhieuMoi
            // 
            resources.ApplyResources(this.btn_TaoPhieuMoi, "btn_TaoPhieuMoi");
            this.btn_TaoPhieuMoi.ForeColor = System.Drawing.Color.Maroon;
            this.btn_TaoPhieuMoi.Image = global::QuanLyTiemVang.Properties.Resources.New;
            this.btn_TaoPhieuMoi.Name = "btn_TaoPhieuMoi";
            this.btn_TaoPhieuMoi.UseVisualStyleBackColor = true;
            this.btn_TaoPhieuMoi.Click += new System.EventHandler(this.btn_TaoPhieuMoi_Click);
            // 
            // btn_LapPhieu
            // 
            resources.ApplyResources(this.btn_LapPhieu, "btn_LapPhieu");
            this.btn_LapPhieu.ForeColor = System.Drawing.Color.Maroon;
            this.btn_LapPhieu.Image = global::QuanLyTiemVang.Properties.Resources.Add;
            this.btn_LapPhieu.Name = "btn_LapPhieu";
            this.btn_LapPhieu.UseVisualStyleBackColor = true;
            this.btn_LapPhieu.Click += new System.EventHandler(this.btn_LapPhieu_Click);
            // 
            // btn_TraCuuSanPham
            // 
            resources.ApplyResources(this.btn_TraCuuSanPham, "btn_TraCuuSanPham");
            this.btn_TraCuuSanPham.ForeColor = System.Drawing.Color.Maroon;
            this.btn_TraCuuSanPham.Image = global::QuanLyTiemVang.Properties.Resources.Search;
            this.btn_TraCuuSanPham.Name = "btn_TraCuuSanPham";
            this.btn_TraCuuSanPham.UseVisualStyleBackColor = true;
            this.btn_TraCuuSanPham.Click += new System.EventHandler(this.btn_TraCuuSanPham_Click);
            // 
            // btn_LapPhieuNo
            // 
            resources.ApplyResources(this.btn_LapPhieuNo, "btn_LapPhieuNo");
            this.btn_LapPhieuNo.ForeColor = System.Drawing.Color.Maroon;
            this.btn_LapPhieuNo.Image = global::QuanLyTiemVang.Properties.Resources.Danhsach;
            this.btn_LapPhieuNo.Name = "btn_LapPhieuNo";
            this.btn_LapPhieuNo.UseVisualStyleBackColor = true;
            this.btn_LapPhieuNo.Click += new System.EventHandler(this.btn_LapPhieuNo_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Image = global::QuanLyTiemVang.Properties.Resources.Danhsach;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PhieuBanHang
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.CancelButton = this.btn_Thoat;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_LapPhieuNo);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_TraCuuKhachHang);
            this.Controls.Add(this.btn_XoaPhieu);
            this.Controls.Add(this.btn_TaoPhieuMoi);
            this.Controls.Add(this.btn_LapPhieu);
            this.Controls.Add(this.btn_TraCuuSanPham);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PhieuBanHang";
            this.Load += new System.EventHandler(this.PhieuBanHang_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietPhieuBanHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_ChiTietPhieuBanHang;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayThanhToan;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayBan;
        private System.Windows.Forms.TextBox txt_TongCong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_TenKhachHang;
        private System.Windows.Forms.TextBox txt_MaKhachHang;
        private System.Windows.Forms.TextBox txt_MaPhieu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_TraCuuKhachHang;
        private System.Windows.Forms.Button btn_XoaPhieu;
        private System.Windows.Forms.Button btn_TaoPhieuMoi;
        private System.Windows.Forms.Button btn_LapPhieu;
        private System.Windows.Forms.Button btn_TraCuuSanPham;
        private System.Windows.Forms.TextBox txt_TienNoSauKhiThanhToan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_SoTienThanhToan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_LapPhieuNo;
        private System.Windows.Forms.Button button1;
    }
}