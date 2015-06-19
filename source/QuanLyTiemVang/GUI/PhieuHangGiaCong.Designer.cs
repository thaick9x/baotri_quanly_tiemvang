namespace QuanLyTiemVang.GUI
{
    partial class PhieuHangGiaCong
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
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_TongCong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_NgayGiaCong = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_NgayNhanHangGiaCong = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_NgayThanhToan = new System.Windows.Forms.DateTimePicker();
            this.dgv_ChiTietPhieuHangGiaCong = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_TenTho = new System.Windows.Forms.TextBox();
            this.txt_MaTho = new System.Windows.Forms.TextBox();
            this.txt_MaPhieu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_LapPhieu = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_TaoPhieuMoi = new System.Windows.Forms.Button();
            this.btn_XoaPhieu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietPhieuHangGiaCong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(235, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 31);
            this.label1.TabIndex = 31;
            this.label1.Text = "PHIẾU HÀNG GIA CÔNG";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(84, 152);
            this.txt_DiaChi.Multiline = true;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.ReadOnly = true;
            this.txt_DiaChi.Size = new System.Drawing.Size(260, 26);
            this.txt_DiaChi.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(13, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 21);
            this.label10.TabIndex = 16;
            this.label10.Text = "Địa chỉ";
            // 
            // txt_TongCong
            // 
            this.txt_TongCong.Location = new System.Drawing.Point(111, 377);
            this.txt_TongCong.Multiline = true;
            this.txt_TongCong.Name = "txt_TongCong";
            this.txt_TongCong.ReadOnly = true;
            this.txt_TongCong.Size = new System.Drawing.Size(168, 26);
            this.txt_TongCong.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(13, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tổng cộng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker_NgayGiaCong);
            this.groupBox1.Controls.Add(this.dateTimePicker_NgayNhanHangGiaCong);
            this.groupBox1.Controls.Add(this.dateTimePicker_NgayThanhToan);
            this.groupBox1.Controls.Add(this.txt_DiaChi);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_TongCong);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dgv_ChiTietPhieuHangGiaCong);
            this.groupBox1.Controls.Add(this.txt_TenTho);
            this.groupBox1.Controls.Add(this.txt_MaTho);
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
            this.groupBox1.Size = new System.Drawing.Size(720, 415);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu hàng gia công";
            // 
            // dateTimePicker_NgayGiaCong
            // 
            this.dateTimePicker_NgayGiaCong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_NgayGiaCong.Location = new System.Drawing.Point(491, 30);
            this.dateTimePicker_NgayGiaCong.Name = "dateTimePicker_NgayGiaCong";
            this.dateTimePicker_NgayGiaCong.Size = new System.Drawing.Size(210, 26);
            this.dateTimePicker_NgayGiaCong.TabIndex = 21;
            // 
            // dateTimePicker_NgayNhanHangGiaCong
            // 
            this.dateTimePicker_NgayNhanHangGiaCong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_NgayNhanHangGiaCong.Location = new System.Drawing.Point(571, 71);
            this.dateTimePicker_NgayNhanHangGiaCong.Name = "dateTimePicker_NgayNhanHangGiaCong";
            this.dateTimePicker_NgayNhanHangGiaCong.Size = new System.Drawing.Size(130, 26);
            this.dateTimePicker_NgayNhanHangGiaCong.TabIndex = 20;
            // 
            // dateTimePicker_NgayThanhToan
            // 
            this.dateTimePicker_NgayThanhToan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_NgayThanhToan.Location = new System.Drawing.Point(505, 113);
            this.dateTimePicker_NgayThanhToan.Name = "dateTimePicker_NgayThanhToan";
            this.dateTimePicker_NgayThanhToan.Size = new System.Drawing.Size(196, 26);
            this.dateTimePicker_NgayThanhToan.TabIndex = 19;
            // 
            // dgv_ChiTietPhieuHangGiaCong
            // 
            this.dgv_ChiTietPhieuHangGiaCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChiTietPhieuHangGiaCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_ChiTietPhieuHangGiaCong.Location = new System.Drawing.Point(17, 195);
            this.dgv_ChiTietPhieuHangGiaCong.Name = "dgv_ChiTietPhieuHangGiaCong";
            this.dgv_ChiTietPhieuHangGiaCong.Size = new System.Drawing.Size(684, 165);
            this.dgv_ChiTietPhieuHangGiaCong.TabIndex = 13;
            this.dgv_ChiTietPhieuHangGiaCong.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ChiTietPhieuHangGiaCong_CellEndEdit);
            // 
            // Column6
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGreen;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column6.HeaderText = "STT";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 45;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkGreen;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Mã hàng gia công";
            this.Column1.Name = "Column1";
            this.Column1.Width = 90;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkGreen;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "Tên hàng gia công";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 210;
            // 
            // Column3
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkGreen;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "Số lượng";
            this.Column3.Name = "Column3";
            this.Column3.Width = 90;
            // 
            // Column4
            // 
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkGreen;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column4.HeaderText = "Đơn giá gia công";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 94;
            // 
            // Column5
            // 
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkGreen;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column5.HeaderText = "Thành tiền";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 110;
            // 
            // txt_TenTho
            // 
            this.txt_TenTho.Location = new System.Drawing.Point(84, 113);
            this.txt_TenTho.Multiline = true;
            this.txt_TenTho.Name = "txt_TenTho";
            this.txt_TenTho.ReadOnly = true;
            this.txt_TenTho.Size = new System.Drawing.Size(260, 26);
            this.txt_TenTho.TabIndex = 12;
            // 
            // txt_MaTho
            // 
            this.txt_MaTho.Location = new System.Drawing.Point(82, 72);
            this.txt_MaTho.Name = "txt_MaTho";
            this.txt_MaTho.Size = new System.Drawing.Size(262, 26);
            this.txt_MaTho.TabIndex = 11;
            this.txt_MaTho.TextChanged += new System.EventHandler(this.txt_MaTho_TextChanged);
            // 
            // txt_MaPhieu
            // 
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
            this.label7.Location = new System.Drawing.Point(10, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tên thợ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(13, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã thợ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(368, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày thanh toán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(368, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày nhận hàng gia công";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(368, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày gia công";
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
            // btn_LapPhieu
            // 
            this.btn_LapPhieu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LapPhieu.ForeColor = System.Drawing.Color.Maroon;
            this.btn_LapPhieu.Image = global::QuanLyTiemVang.Properties.Resources.Add;
            this.btn_LapPhieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LapPhieu.Location = new System.Drawing.Point(46, 501);
            this.btn_LapPhieu.Name = "btn_LapPhieu";
            this.btn_LapPhieu.Size = new System.Drawing.Size(120, 28);
            this.btn_LapPhieu.TabIndex = 33;
            this.btn_LapPhieu.Text = "Lập phiếu ";
            this.btn_LapPhieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_LapPhieu.UseVisualStyleBackColor = true;
            this.btn_LapPhieu.Click += new System.EventHandler(this.btn_LapPhieu_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Thoat.Image = global::QuanLyTiemVang.Properties.Resources.Close;
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(645, 501);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(85, 28);
            this.btn_Thoat.TabIndex = 37;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_TaoPhieuMoi
            // 
            this.btn_TaoPhieuMoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoPhieuMoi.ForeColor = System.Drawing.Color.Maroon;
            this.btn_TaoPhieuMoi.Image = global::QuanLyTiemVang.Properties.Resources.New;
            this.btn_TaoPhieuMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TaoPhieuMoi.Location = new System.Drawing.Point(228, 501);
            this.btn_TaoPhieuMoi.Name = "btn_TaoPhieuMoi";
            this.btn_TaoPhieuMoi.Size = new System.Drawing.Size(150, 28);
            this.btn_TaoPhieuMoi.TabIndex = 34;
            this.btn_TaoPhieuMoi.Text = "Tạo phiếu mới";
            this.btn_TaoPhieuMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TaoPhieuMoi.UseVisualStyleBackColor = true;
            this.btn_TaoPhieuMoi.Click += new System.EventHandler(this.btn_TaoPhieuMoi_Click);
            // 
            // btn_XoaPhieu
            // 
            this.btn_XoaPhieu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaPhieu.ForeColor = System.Drawing.Color.Maroon;
            this.btn_XoaPhieu.Image = global::QuanLyTiemVang.Properties.Resources.Delete;
            this.btn_XoaPhieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaPhieu.Location = new System.Drawing.Point(450, 501);
            this.btn_XoaPhieu.Name = "btn_XoaPhieu";
            this.btn_XoaPhieu.Size = new System.Drawing.Size(116, 28);
            this.btn_XoaPhieu.TabIndex = 35;
            this.btn_XoaPhieu.Text = "Xóa phiếu";
            this.btn_XoaPhieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_XoaPhieu.UseVisualStyleBackColor = true;
            this.btn_XoaPhieu.Click += new System.EventHandler(this.btn_XoaPhieu_Click);
            // 
            // PhieuHangGiaCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_LapPhieu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_TaoPhieuMoi);
            this.Controls.Add(this.btn_XoaPhieu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PhieuHangGiaCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PhieuHangGiaCong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietPhieuHangGiaCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_TongCong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_LapPhieu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_ChiTietPhieuHangGiaCong;
        private System.Windows.Forms.TextBox txt_TenTho;
        private System.Windows.Forms.TextBox txt_MaTho;
        private System.Windows.Forms.TextBox txt_MaPhieu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_TaoPhieuMoi;
        private System.Windows.Forms.Button btn_XoaPhieu;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayGiaCong;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayNhanHangGiaCong;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}