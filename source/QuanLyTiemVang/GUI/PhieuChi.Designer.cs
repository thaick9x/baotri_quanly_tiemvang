namespace QuanLyTiemVang.GUI
{
    partial class PhieuChi
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
            this.txt_TongCong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_ChiTietPhieuChi = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_MaPhieu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_NgayChi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_XoaPhieu = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_TaoPhieuMoi = new System.Windows.Forms.Button();
            this.btn_LapPhieu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietPhieuChi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_TongCong
            // 
            this.txt_TongCong.Location = new System.Drawing.Point(111, 294);
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
            this.label8.Location = new System.Drawing.Point(13, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tổng cộng";
            // 
            // dgv_ChiTietPhieuChi
            // 
            this.dgv_ChiTietPhieuChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChiTietPhieuChi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2,
            this.Column5});
            this.dgv_ChiTietPhieuChi.Location = new System.Drawing.Point(17, 89);
            this.dgv_ChiTietPhieuChi.Name = "dgv_ChiTietPhieuChi";
            this.dgv_ChiTietPhieuChi.Size = new System.Drawing.Size(515, 189);
            this.dgv_ChiTietPhieuChi.TabIndex = 13;
            this.dgv_ChiTietPhieuChi.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ChiTietPhieuChi_CellEndEdit);
            // 
            // Column3
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Green;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column3.HeaderText = "STT";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 45;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Green;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Mã khoản phí";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Green;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "Tên khoản phí";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 195;
            // 
            // Column5
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Green;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column5.HeaderText = "Thành tiền";
            this.Column5.Name = "Column5";
            this.Column5.Width = 110;
            // 
            // txt_MaPhieu
            // 
            this.txt_MaPhieu.Location = new System.Drawing.Point(98, 44);
            this.txt_MaPhieu.Multiline = true;
            this.txt_MaPhieu.Name = "txt_MaPhieu";
            this.txt_MaPhieu.ReadOnly = true;
            this.txt_MaPhieu.Size = new System.Drawing.Size(141, 26);
            this.txt_MaPhieu.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(257, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày chi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phiếu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker_NgayChi);
            this.groupBox1.Controls.Add(this.txt_TongCong);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dgv_ChiTietPhieuChi);
            this.groupBox1.Controls.Add(this.txt_MaPhieu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 334);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu chi";
            // 
            // dateTimePicker_NgayChi
            // 
            this.dateTimePicker_NgayChi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_NgayChi.Location = new System.Drawing.Point(339, 44);
            this.dateTimePicker_NgayChi.Name = "dateTimePicker_NgayChi";
            this.dateTimePicker_NgayChi.Size = new System.Drawing.Size(193, 26);
            this.dateTimePicker_NgayChi.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(239, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 31);
            this.label1.TabIndex = 38;
            this.label1.Text = "PHIẾU CHI";
            // 
            // btn_XoaPhieu
            // 
            this.btn_XoaPhieu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaPhieu.ForeColor = System.Drawing.Color.Maroon;
            this.btn_XoaPhieu.Image = global::QuanLyTiemVang.Properties.Resources.Delete;
            this.btn_XoaPhieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaPhieu.Location = new System.Drawing.Point(452, 410);
            this.btn_XoaPhieu.Name = "btn_XoaPhieu";
            this.btn_XoaPhieu.Size = new System.Drawing.Size(119, 28);
            this.btn_XoaPhieu.TabIndex = 42;
            this.btn_XoaPhieu.Text = "Xóa phiếu";
            this.btn_XoaPhieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_XoaPhieu.UseVisualStyleBackColor = true;
            this.btn_XoaPhieu.Click += new System.EventHandler(this.btn_XoaPhieu_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Thoat.Image = global::QuanLyTiemVang.Properties.Resources.Close;
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(487, 457);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(84, 28);
            this.btn_Thoat.TabIndex = 43;
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
            this.btn_TaoPhieuMoi.Location = new System.Drawing.Point(56, 457);
            this.btn_TaoPhieuMoi.Name = "btn_TaoPhieuMoi";
            this.btn_TaoPhieuMoi.Size = new System.Drawing.Size(148, 28);
            this.btn_TaoPhieuMoi.TabIndex = 41;
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
            this.btn_LapPhieu.Location = new System.Drawing.Point(56, 410);
            this.btn_LapPhieu.Name = "btn_LapPhieu";
            this.btn_LapPhieu.Size = new System.Drawing.Size(121, 28);
            this.btn_LapPhieu.TabIndex = 40;
            this.btn_LapPhieu.Text = "Lập phiếu ";
            this.btn_LapPhieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_LapPhieu.UseVisualStyleBackColor = true;
            this.btn_LapPhieu.Click += new System.EventHandler(this.btn_LapPhieu_Click);
            // 
            // PhieuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(629, 505);
            this.Controls.Add(this.btn_XoaPhieu);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_TaoPhieuMoi);
            this.Controls.Add(this.btn_LapPhieu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PhieuChi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PhieuChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietPhieuChi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_XoaPhieu;
        private System.Windows.Forms.TextBox txt_TongCong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_ChiTietPhieuChi;
        private System.Windows.Forms.TextBox txt_MaPhieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_TaoPhieuMoi;
        private System.Windows.Forms.Button btn_LapPhieu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}