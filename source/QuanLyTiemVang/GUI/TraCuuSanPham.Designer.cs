namespace QuanLyTiemVang.GUI
{
    partial class TraCuuSanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_LoaiSanPham = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_LoaiSanPham = new System.Windows.Forms.RadioButton();
            this.txt_SoLuongTonDen = new System.Windows.Forms.TextBox();
            this.txt_SoLuongTonTu = new System.Windows.Forms.TextBox();
            this.txt_TenSanPham = new System.Windows.Forms.TextBox();
            this.txt_MaSanPham = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radio_SoLuongTon = new System.Windows.Forms.RadioButton();
            this.radio_TenSanPham = new System.Windows.Forms.RadioButton();
            this.radio_MaSanPham = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_DanhSachSanPham = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_TraCuu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(195, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 31);
            this.label2.TabIndex = 62;
            this.label2.Text = "TRA CỨU SẢN PHẨM";
            // 
            // txt_LoaiSanPham
            // 
            this.txt_LoaiSanPham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LoaiSanPham.Location = new System.Drawing.Point(451, 57);
            this.txt_LoaiSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.txt_LoaiSanPham.Name = "txt_LoaiSanPham";
            this.txt_LoaiSanPham.ReadOnly = true;
            this.txt_LoaiSanPham.Size = new System.Drawing.Size(133, 26);
            this.txt_LoaiSanPham.TabIndex = 60;
            this.txt_LoaiSanPham.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_LoaiSanPham);
            this.groupBox1.Controls.Add(this.radio_LoaiSanPham);
            this.groupBox1.Controls.Add(this.txt_SoLuongTonDen);
            this.groupBox1.Controls.Add(this.txt_SoLuongTonTu);
            this.groupBox1.Controls.Add(this.txt_TenSanPham);
            this.groupBox1.Controls.Add(this.txt_MaSanPham);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radio_SoLuongTon);
            this.groupBox1.Controls.Add(this.radio_TenSanPham);
            this.groupBox1.Controls.Add(this.radio_MaSanPham);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(26, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 138);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tra Cứu";
            // 
            // radio_LoaiSanPham
            // 
            this.radio_LoaiSanPham.AutoSize = true;
            this.radio_LoaiSanPham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radio_LoaiSanPham.ForeColor = System.Drawing.Color.Blue;
            this.radio_LoaiSanPham.Location = new System.Drawing.Point(327, 60);
            this.radio_LoaiSanPham.Name = "radio_LoaiSanPham";
            this.radio_LoaiSanPham.Size = new System.Drawing.Size(119, 23);
            this.radio_LoaiSanPham.TabIndex = 59;
            this.radio_LoaiSanPham.TabStop = true;
            this.radio_LoaiSanPham.Text = "Loại Sản Phẩm";
            this.radio_LoaiSanPham.UseVisualStyleBackColor = true;
            this.radio_LoaiSanPham.CheckedChanged += new System.EventHandler(this.radio_LoaiSanPham_CheckedChanged);
            // 
            // txt_SoLuongTonDen
            // 
            this.txt_SoLuongTonDen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLuongTonDen.Location = new System.Drawing.Point(404, 95);
            this.txt_SoLuongTonDen.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SoLuongTonDen.Name = "txt_SoLuongTonDen";
            this.txt_SoLuongTonDen.ReadOnly = true;
            this.txt_SoLuongTonDen.Size = new System.Drawing.Size(180, 26);
            this.txt_SoLuongTonDen.TabIndex = 56;
            this.txt_SoLuongTonDen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_SoLuongTonTu
            // 
            this.txt_SoLuongTonTu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLuongTonTu.Location = new System.Drawing.Point(170, 96);
            this.txt_SoLuongTonTu.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SoLuongTonTu.Name = "txt_SoLuongTonTu";
            this.txt_SoLuongTonTu.ReadOnly = true;
            this.txt_SoLuongTonTu.Size = new System.Drawing.Size(132, 26);
            this.txt_SoLuongTonTu.TabIndex = 55;
            this.txt_SoLuongTonTu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_TenSanPham
            // 
            this.txt_TenSanPham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenSanPham.Location = new System.Drawing.Point(140, 59);
            this.txt_TenSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TenSanPham.Name = "txt_TenSanPham";
            this.txt_TenSanPham.ReadOnly = true;
            this.txt_TenSanPham.Size = new System.Drawing.Size(162, 26);
            this.txt_TenSanPham.TabIndex = 53;
            this.txt_TenSanPham.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_MaSanPham
            // 
            this.txt_MaSanPham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaSanPham.Location = new System.Drawing.Point(140, 21);
            this.txt_MaSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MaSanPham.Name = "txt_MaSanPham";
            this.txt_MaSanPham.ReadOnly = true;
            this.txt_MaSanPham.Size = new System.Drawing.Size(162, 26);
            this.txt_MaSanPham.TabIndex = 52;
            this.txt_MaSanPham.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(136, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 19);
            this.label1.TabIndex = 47;
            this.label1.Text = "Từ";
            // 
            // radio_SoLuongTon
            // 
            this.radio_SoLuongTon.AutoSize = true;
            this.radio_SoLuongTon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radio_SoLuongTon.ForeColor = System.Drawing.Color.Blue;
            this.radio_SoLuongTon.Location = new System.Drawing.Point(12, 99);
            this.radio_SoLuongTon.Name = "radio_SoLuongTon";
            this.radio_SoLuongTon.Size = new System.Drawing.Size(116, 23);
            this.radio_SoLuongTon.TabIndex = 46;
            this.radio_SoLuongTon.TabStop = true;
            this.radio_SoLuongTon.Text = "Số Lượng Tồn";
            this.radio_SoLuongTon.UseVisualStyleBackColor = true;
            this.radio_SoLuongTon.CheckedChanged += new System.EventHandler(this.radio_SoLuongTon_CheckedChanged);
            // 
            // radio_TenSanPham
            // 
            this.radio_TenSanPham.AutoSize = true;
            this.radio_TenSanPham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radio_TenSanPham.ForeColor = System.Drawing.Color.Blue;
            this.radio_TenSanPham.Location = new System.Drawing.Point(12, 62);
            this.radio_TenSanPham.Name = "radio_TenSanPham";
            this.radio_TenSanPham.Size = new System.Drawing.Size(115, 23);
            this.radio_TenSanPham.TabIndex = 43;
            this.radio_TenSanPham.TabStop = true;
            this.radio_TenSanPham.Text = "Tên Sản Phẩm";
            this.radio_TenSanPham.UseVisualStyleBackColor = true;
            this.radio_TenSanPham.CheckedChanged += new System.EventHandler(this.radio_TenSanPham_CheckedChanged);
            // 
            // radio_MaSanPham
            // 
            this.radio_MaSanPham.AutoSize = true;
            this.radio_MaSanPham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radio_MaSanPham.ForeColor = System.Drawing.Color.Blue;
            this.radio_MaSanPham.Location = new System.Drawing.Point(12, 24);
            this.radio_MaSanPham.Name = "radio_MaSanPham";
            this.radio_MaSanPham.Size = new System.Drawing.Size(113, 23);
            this.radio_MaSanPham.TabIndex = 42;
            this.radio_MaSanPham.TabStop = true;
            this.radio_MaSanPham.Text = "Mã Sản Phẩm";
            this.radio_MaSanPham.UseVisualStyleBackColor = true;
            this.radio_MaSanPham.CheckedChanged += new System.EventHandler(this.radio_MaSanPham_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(358, 100);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 19);
            this.label6.TabIndex = 40;
            this.label6.Text = "Đến";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_DanhSachSanPham);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(29, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(596, 282);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết Quả Tra Cứu";
            // 
            // dgv_DanhSachSanPham
            // 
            this.dgv_DanhSachSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.TacGia,
            this.TheLoai});
            this.dgv_DanhSachSanPham.Location = new System.Drawing.Point(12, 28);
            this.dgv_DanhSachSanPham.Name = "dgv_DanhSachSanPham";
            this.dgv_DanhSachSanPham.ReadOnly = true;
            this.dgv_DanhSachSanPham.Size = new System.Drawing.Size(569, 248);
            this.dgv_DanhSachSanPham.TabIndex = 0;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSanPham";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Green;
            this.MaSach.DefaultCellStyle = dataGridViewCellStyle5;
            this.MaSach.HeaderText = "Mã sản phẩm";
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            this.MaSach.Width = 115;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSanPham";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Green;
            this.TenSach.DefaultCellStyle = dataGridViewCellStyle6;
            this.TenSach.HeaderText = "Tên Sản Phẩm";
            this.TenSach.Name = "TenSach";
            this.TenSach.ReadOnly = true;
            this.TenSach.Width = 153;
            // 
            // TacGia
            // 
            this.TacGia.DataPropertyName = "LoaiSanPham";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Green;
            this.TacGia.DefaultCellStyle = dataGridViewCellStyle7;
            this.TacGia.HeaderText = "Loại Sản Phẩm";
            this.TacGia.Name = "TacGia";
            this.TacGia.ReadOnly = true;
            this.TacGia.Width = 135;
            // 
            // TheLoai
            // 
            this.TheLoai.DataPropertyName = "SoLuongTon";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Green;
            this.TheLoai.DefaultCellStyle = dataGridViewCellStyle8;
            this.TheLoai.HeaderText = "Số Lượng Tồn";
            this.TheLoai.Name = "TheLoai";
            this.TheLoai.ReadOnly = true;
            this.TheLoai.Width = 120;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Thoat.Image = global::QuanLyTiemVang.Properties.Resources.Close;
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(526, 228);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(84, 28);
            this.btn_Thoat.TabIndex = 66;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_TraCuu
            // 
            this.btn_TraCuu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TraCuu.ForeColor = System.Drawing.Color.Maroon;
            this.btn_TraCuu.Image = global::QuanLyTiemVang.Properties.Resources.Search;
            this.btn_TraCuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TraCuu.Location = new System.Drawing.Point(38, 228);
            this.btn_TraCuu.Name = "btn_TraCuu";
            this.btn_TraCuu.Size = new System.Drawing.Size(97, 28);
            this.btn_TraCuu.TabIndex = 65;
            this.btn_TraCuu.Text = "Tra cứu";
            this.btn_TraCuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TraCuu.UseVisualStyleBackColor = true;
            this.btn_TraCuu.Click += new System.EventHandler(this.btn_TraCuu_Click);
            // 
            // TraCuuSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(654, 577);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_TraCuu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TraCuuSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.TraCuuSanPham_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_TraCuu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_LoaiSanPham;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio_LoaiSanPham;
        private System.Windows.Forms.TextBox txt_SoLuongTonDen;
        private System.Windows.Forms.TextBox txt_SoLuongTonTu;
        private System.Windows.Forms.TextBox txt_TenSanPham;
        private System.Windows.Forms.TextBox txt_MaSanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radio_SoLuongTon;
        private System.Windows.Forms.RadioButton radio_TenSanPham;
        private System.Windows.Forms.RadioButton radio_MaSanPham;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_DanhSachSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheLoai;
    }
}