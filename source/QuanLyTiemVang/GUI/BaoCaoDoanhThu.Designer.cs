namespace QuanLyTiemVang.GUI
{
    partial class BaoCaoDoanhThu
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_TienThuPhieuDichVu = new System.Windows.Forms.TextBox();
            this.txt_TongTienThu = new System.Windows.Forms.TextBox();
            this.txt_TienThuPhieuBanHang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_DanhSachPhieuDichVu = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_DanhSachPhieuBanHang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_TongTienChi = new System.Windows.Forms.TextBox();
            this.txt_TienChiPhieuChi = new System.Windows.Forms.TextBox();
            this.txt_TienChiPhieuHangGiaCong = new System.Windows.Forms.TextBox();
            this.txt_TienChiPhieuMuaHang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_DanhSachPhieuChi = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_DanhSachPhieuHangGiaCong = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_DanhSachPhieuMuaHang = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_MaBaoCao = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_TonQuyBanDau = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_TonQuyConLai = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker_NgayBaoCao = new System.Windows.Forms.DateTimePicker();
            this.btn_LapBaoCao = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachPhieuDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachPhieuBanHang)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachPhieuChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachPhieuHangGiaCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachPhieuMuaHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(354, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 31);
            this.label1.TabIndex = 49;
            this.label1.Text = "BÁO CÁO DOANH THU";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_TienThuPhieuDichVu);
            this.groupBox1.Controls.Add(this.txt_TongTienThu);
            this.groupBox1.Controls.Add(this.txt_TienThuPhieuBanHang);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dgv_DanhSachPhieuDichVu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dgv_DanhSachPhieuBanHang);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 263);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khoản thu";
            // 
            // txt_TienThuPhieuDichVu
            // 
            this.txt_TienThuPhieuDichVu.Location = new System.Drawing.Point(521, 196);
            this.txt_TienThuPhieuDichVu.Multiline = true;
            this.txt_TienThuPhieuDichVu.Name = "txt_TienThuPhieuDichVu";
            this.txt_TienThuPhieuDichVu.ReadOnly = true;
            this.txt_TienThuPhieuDichVu.Size = new System.Drawing.Size(129, 26);
            this.txt_TienThuPhieuDichVu.TabIndex = 25;
            // 
            // txt_TongTienThu
            // 
            this.txt_TongTienThu.Location = new System.Drawing.Point(128, 229);
            this.txt_TongTienThu.Multiline = true;
            this.txt_TongTienThu.Name = "txt_TongTienThu";
            this.txt_TongTienThu.ReadOnly = true;
            this.txt_TongTienThu.Size = new System.Drawing.Size(195, 26);
            this.txt_TongTienThu.TabIndex = 24;
            // 
            // txt_TienThuPhieuBanHang
            // 
            this.txt_TienThuPhieuBanHang.Location = new System.Drawing.Point(206, 195);
            this.txt_TienThuPhieuBanHang.Multiline = true;
            this.txt_TienThuPhieuBanHang.Name = "txt_TienThuPhieuBanHang";
            this.txt_TienThuPhieuBanHang.ReadOnly = true;
            this.txt_TienThuPhieuBanHang.Size = new System.Drawing.Size(117, 26);
            this.txt_TienThuPhieuBanHang.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(340, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tiền thu phiếu dịch vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(13, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tiền thu phiếu bán hàng";
            // 
            // dgv_DanhSachPhieuDichVu
            // 
            this.dgv_DanhSachPhieuDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachPhieuDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgv_DanhSachPhieuDichVu.Location = new System.Drawing.Point(344, 30);
            this.dgv_DanhSachPhieuDichVu.Name = "dgv_DanhSachPhieuDichVu";
            this.dgv_DanhSachPhieuDichVu.Size = new System.Drawing.Size(306, 154);
            this.dgv_DanhSachPhieuDichVu.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaPhieuDichVu";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã phiếu dịch vụ";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 130;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TongCong";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tổng cộng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 130;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(13, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tổng tiền thu";
            // 
            // dgv_DanhSachPhieuBanHang
            // 
            this.dgv_DanhSachPhieuBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachPhieuBanHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv_DanhSachPhieuBanHang.Location = new System.Drawing.Point(17, 30);
            this.dgv_DanhSachPhieuBanHang.Name = "dgv_DanhSachPhieuBanHang";
            this.dgv_DanhSachPhieuBanHang.Size = new System.Drawing.Size(306, 154);
            this.dgv_DanhSachPhieuBanHang.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaPhieuBanHang";
            this.Column1.HeaderText = "Mã phiếu bán hàng";
            this.Column1.Name = "Column1";
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TongCong";
            this.Column2.HeaderText = "Tổng cộng";
            this.Column2.Name = "Column2";
            this.Column2.Width = 130;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_TongTienChi);
            this.groupBox2.Controls.Add(this.txt_TienChiPhieuChi);
            this.groupBox2.Controls.Add(this.txt_TienChiPhieuHangGiaCong);
            this.groupBox2.Controls.Add(this.txt_TienChiPhieuMuaHang);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dgv_DanhSachPhieuChi);
            this.groupBox2.Controls.Add(this.dgv_DanhSachPhieuHangGiaCong);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dgv_DanhSachPhieuMuaHang);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 363);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(998, 263);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khoản chi";
            // 
            // txt_TongTienChi
            // 
            this.txt_TongTienChi.Location = new System.Drawing.Point(128, 226);
            this.txt_TongTienChi.Multiline = true;
            this.txt_TongTienChi.Name = "txt_TongTienChi";
            this.txt_TongTienChi.ReadOnly = true;
            this.txt_TongTienChi.Size = new System.Drawing.Size(195, 26);
            this.txt_TongTienChi.TabIndex = 27;
            // 
            // txt_TienChiPhieuChi
            // 
            this.txt_TienChiPhieuChi.Location = new System.Drawing.Point(817, 193);
            this.txt_TienChiPhieuChi.Multiline = true;
            this.txt_TienChiPhieuChi.Name = "txt_TienChiPhieuChi";
            this.txt_TienChiPhieuChi.ReadOnly = true;
            this.txt_TienChiPhieuChi.Size = new System.Drawing.Size(162, 26);
            this.txt_TienChiPhieuChi.TabIndex = 26;
            // 
            // txt_TienChiPhieuHangGiaCong
            // 
            this.txt_TienChiPhieuHangGiaCong.Location = new System.Drawing.Point(569, 193);
            this.txt_TienChiPhieuHangGiaCong.Multiline = true;
            this.txt_TienChiPhieuHangGiaCong.Name = "txt_TienChiPhieuHangGiaCong";
            this.txt_TienChiPhieuHangGiaCong.ReadOnly = true;
            this.txt_TienChiPhieuHangGiaCong.Size = new System.Drawing.Size(81, 26);
            this.txt_TienChiPhieuHangGiaCong.TabIndex = 25;
            // 
            // txt_TienChiPhieuMuaHang
            // 
            this.txt_TienChiPhieuMuaHang.Location = new System.Drawing.Point(206, 193);
            this.txt_TienChiPhieuMuaHang.Multiline = true;
            this.txt_TienChiPhieuMuaHang.Name = "txt_TienChiPhieuMuaHang";
            this.txt_TienChiPhieuMuaHang.ReadOnly = true;
            this.txt_TienChiPhieuMuaHang.Size = new System.Drawing.Size(117, 26);
            this.txt_TienChiPhieuMuaHang.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(13, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tiền chi phiếu mua hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(669, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 21);
            this.label8.TabIndex = 20;
            this.label8.Text = "Tiền chi phiếu chi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(340, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tiền chi phiếu hàng gia công";
            // 
            // dgv_DanhSachPhieuChi
            // 
            this.dgv_DanhSachPhieuChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachPhieuChi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgv_DanhSachPhieuChi.Location = new System.Drawing.Point(673, 26);
            this.dgv_DanhSachPhieuChi.Name = "dgv_DanhSachPhieuChi";
            this.dgv_DanhSachPhieuChi.Size = new System.Drawing.Size(306, 154);
            this.dgv_DanhSachPhieuChi.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MaPhieuChi";
            this.dataGridViewTextBoxColumn7.HeaderText = "Mã phiếu chi";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 130;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TongCong";
            this.dataGridViewTextBoxColumn8.HeaderText = "Tổng cộng";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 130;
            // 
            // dgv_DanhSachPhieuHangGiaCong
            // 
            this.dgv_DanhSachPhieuHangGiaCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachPhieuHangGiaCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgv_DanhSachPhieuHangGiaCong.Location = new System.Drawing.Point(344, 26);
            this.dgv_DanhSachPhieuHangGiaCong.Name = "dgv_DanhSachPhieuHangGiaCong";
            this.dgv_DanhSachPhieuHangGiaCong.Size = new System.Drawing.Size(306, 154);
            this.dgv_DanhSachPhieuHangGiaCong.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MaPhieuHangGiaCong";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mã phiếu hàng gia công";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 130;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TongCong";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tổng cộng";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 130;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(13, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tổng tiền chi";
            // 
            // dgv_DanhSachPhieuMuaHang
            // 
            this.dgv_DanhSachPhieuMuaHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachPhieuMuaHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgv_DanhSachPhieuMuaHang.Location = new System.Drawing.Point(17, 26);
            this.dgv_DanhSachPhieuMuaHang.Name = "dgv_DanhSachPhieuMuaHang";
            this.dgv_DanhSachPhieuMuaHang.Size = new System.Drawing.Size(306, 154);
            this.dgv_DanhSachPhieuMuaHang.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MaPhieuMuaHang";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mã phiếu mua hàng";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 130;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TongCong";
            this.dataGridViewTextBoxColumn6.HeaderText = "Tổng cộng";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 130;
            // 
            // txt_MaBaoCao
            // 
            this.txt_MaBaoCao.Location = new System.Drawing.Point(124, 59);
            this.txt_MaBaoCao.Multiline = true;
            this.txt_MaBaoCao.Name = "txt_MaBaoCao";
            this.txt_MaBaoCao.ReadOnly = true;
            this.txt_MaBaoCao.Size = new System.Drawing.Size(211, 26);
            this.txt_MaBaoCao.TabIndex = 54;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(352, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 21);
            this.label15.TabIndex = 53;
            this.label15.Text = "Ngày báo cáo";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(19, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 21);
            this.label16.TabIndex = 52;
            this.label16.Text = "Mã báo cáo";
            // 
            // txt_TonQuyBanDau
            // 
            this.txt_TonQuyBanDau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TonQuyBanDau.Location = new System.Drawing.Point(163, 639);
            this.txt_TonQuyBanDau.Multiline = true;
            this.txt_TonQuyBanDau.Name = "txt_TonQuyBanDau";
            this.txt_TonQuyBanDau.ReadOnly = true;
            this.txt_TonQuyBanDau.Size = new System.Drawing.Size(166, 26);
            this.txt_TonQuyBanDau.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(19, 641);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 21);
            this.label9.TabIndex = 56;
            this.label9.Text = "Tồn quỹ ban đầu";
            // 
            // txt_TonQuyConLai
            // 
            this.txt_TonQuyConLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TonQuyConLai.Location = new System.Drawing.Point(486, 639);
            this.txt_TonQuyConLai.Multiline = true;
            this.txt_TonQuyConLai.Name = "txt_TonQuyConLai";
            this.txt_TonQuyConLai.ReadOnly = true;
            this.txt_TonQuyConLai.Size = new System.Drawing.Size(176, 26);
            this.txt_TonQuyConLai.TabIndex = 59;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(352, 641);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 21);
            this.label10.TabIndex = 58;
            this.label10.Text = "Tồn quỹ còn lại";
            // 
            // dateTimePicker_NgayBaoCao
            // 
            this.dateTimePicker_NgayBaoCao.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_NgayBaoCao.Checked = false;
            this.dateTimePicker_NgayBaoCao.CustomFormat = "";
            this.dateTimePicker_NgayBaoCao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_NgayBaoCao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_NgayBaoCao.Location = new System.Drawing.Point(472, 60);
            this.dateTimePicker_NgayBaoCao.Name = "dateTimePicker_NgayBaoCao";
            this.dateTimePicker_NgayBaoCao.Size = new System.Drawing.Size(190, 26);
            this.dateTimePicker_NgayBaoCao.TabIndex = 60;
            // 
            // btn_LapBaoCao
            // 
            this.btn_LapBaoCao.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LapBaoCao.ForeColor = System.Drawing.Color.Maroon;
            this.btn_LapBaoCao.Image = global::QuanLyTiemVang.Properties.Resources.Report;
            this.btn_LapBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LapBaoCao.Location = new System.Drawing.Point(724, 637);
            this.btn_LapBaoCao.Name = "btn_LapBaoCao";
            this.btn_LapBaoCao.Size = new System.Drawing.Size(134, 28);
            this.btn_LapBaoCao.TabIndex = 62;
            this.btn_LapBaoCao.Text = "Lập báo cáo";
            this.btn_LapBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_LapBaoCao.UseVisualStyleBackColor = true;
            this.btn_LapBaoCao.Click += new System.EventHandler(this.btn_LapBaoCao_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Thoat.Image = global::QuanLyTiemVang.Properties.Resources.Close;
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(909, 637);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(82, 28);
            this.btn_Thoat.TabIndex = 61;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // BaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1025, 682);
            this.Controls.Add(this.btn_LapBaoCao);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.dateTimePicker_NgayBaoCao);
            this.Controls.Add(this.txt_TonQuyConLai);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_TonQuyBanDau);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_MaBaoCao);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BaoCaoDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachPhieuDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachPhieuBanHang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachPhieuChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachPhieuHangGiaCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachPhieuMuaHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_DanhSachPhieuBanHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_DanhSachPhieuDichVu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_DanhSachPhieuChi;
        private System.Windows.Forms.DataGridView dgv_DanhSachPhieuHangGiaCong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_DanhSachPhieuMuaHang;
        private System.Windows.Forms.TextBox txt_TienThuPhieuDichVu;
        private System.Windows.Forms.TextBox txt_TongTienThu;
        private System.Windows.Forms.TextBox txt_TienThuPhieuBanHang;
        private System.Windows.Forms.TextBox txt_TongTienChi;
        private System.Windows.Forms.TextBox txt_TienChiPhieuChi;
        private System.Windows.Forms.TextBox txt_TienChiPhieuHangGiaCong;
        private System.Windows.Forms.TextBox txt_TienChiPhieuMuaHang;
        private System.Windows.Forms.TextBox txt_MaBaoCao;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_TonQuyBanDau;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_TonQuyConLai;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayBaoCao;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_LapBaoCao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}