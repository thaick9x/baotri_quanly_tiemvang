namespace QuanLyTiemVang.GUI
{
    partial class BaoCaoTon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaoCaoTon));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_ChiTietBaoCaoTon = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_NgayBaoCao = new System.Windows.Forms.DateTimePicker();
            this.txt_MaBaoCao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_LapBaoCao = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietBaoCaoTon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Name = "label1";
            // 
            // dgv_ChiTietBaoCaoTon
            // 
            this.dgv_ChiTietBaoCaoTon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChiTietBaoCaoTon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            resources.ApplyResources(this.dgv_ChiTietBaoCaoTon, "dgv_ChiTietBaoCaoTon");
            this.dgv_ChiTietBaoCaoTon.Name = "dgv_ChiTietBaoCaoTon";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker_NgayBaoCao);
            this.groupBox1.Controls.Add(this.dgv_ChiTietBaoCaoTon);
            this.groupBox1.Controls.Add(this.txt_MaBaoCao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // dateTimePicker_NgayBaoCao
            // 
            resources.ApplyResources(this.dateTimePicker_NgayBaoCao, "dateTimePicker_NgayBaoCao");
            this.dateTimePicker_NgayBaoCao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_NgayBaoCao.Name = "dateTimePicker_NgayBaoCao";
            // 
            // txt_MaBaoCao
            // 
            resources.ApplyResources(this.txt_MaBaoCao, "txt_MaBaoCao");
            this.txt_MaBaoCao.Name = "txt_MaBaoCao";
            this.txt_MaBaoCao.ReadOnly = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Name = "label2";
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
            // btn_LapBaoCao
            // 
            resources.ApplyResources(this.btn_LapBaoCao, "btn_LapBaoCao");
            this.btn_LapBaoCao.ForeColor = System.Drawing.Color.Maroon;
            this.btn_LapBaoCao.Image = global::QuanLyTiemVang.Properties.Resources.Danhsach;
            this.btn_LapBaoCao.Name = "btn_LapBaoCao";
            this.btn_LapBaoCao.UseVisualStyleBackColor = true;
            this.btn_LapBaoCao.Click += new System.EventHandler(this.btn_LapBaoCao_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaSanPham";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TonDauKy";
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SoLuongBan";
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SoLuongMua";
            resources.ApplyResources(this.Column5, "Column5");
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TonCuoiKy";
            resources.ApplyResources(this.Column6, "Column6");
            this.Column6.Name = "Column6";
            // 
            // BaoCaoTon
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_LapBaoCao);
            this.MaximizeBox = false;
            this.Name = "BaoCaoTon";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietBaoCaoTon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_ChiTietBaoCaoTon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_MaBaoCao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_LapBaoCao;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayBaoCao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}