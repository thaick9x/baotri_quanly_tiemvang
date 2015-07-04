namespace QuanLyTiemVang.GUI
{
    partial class LichSuXoa
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
            this.dgv_LichSuXoaKhachHang = new System.Windows.Forms.DataGridView();
            this.lb_LSXKhachHang = new System.Windows.Forms.Label();
            this.btn_Restore = new System.Windows.Forms.Button();
            this.btn_PermDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LichSuXoaKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_LichSuXoaKhachHang
            // 
            this.dgv_LichSuXoaKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LichSuXoaKhachHang.Location = new System.Drawing.Point(23, 78);
            this.dgv_LichSuXoaKhachHang.Name = "dgv_LichSuXoaKhachHang";
            this.dgv_LichSuXoaKhachHang.Size = new System.Drawing.Size(587, 306);
            this.dgv_LichSuXoaKhachHang.TabIndex = 0;
            // 
            // lb_LSXKhachHang
            // 
            this.lb_LSXKhachHang.AutoSize = true;
            this.lb_LSXKhachHang.Location = new System.Drawing.Point(23, 59);
            this.lb_LSXKhachHang.Name = "lb_LSXKhachHang";
            this.lb_LSXKhachHang.Size = new System.Drawing.Size(158, 13);
            this.lb_LSXKhachHang.TabIndex = 1;
            this.lb_LSXKhachHang.Text = "Danh sách khách hàng đã xóa:";
            // 
            // btn_Restore
            // 
            this.btn_Restore.Location = new System.Drawing.Point(629, 116);
            this.btn_Restore.Name = "btn_Restore";
            this.btn_Restore.Size = new System.Drawing.Size(75, 35);
            this.btn_Restore.TabIndex = 2;
            this.btn_Restore.Text = "Khôi phục";
            this.btn_Restore.UseVisualStyleBackColor = true;
            this.btn_Restore.Click += new System.EventHandler(this.btn_Restore_Click);
            // 
            // btn_PermDel
            // 
            this.btn_PermDel.Location = new System.Drawing.Point(629, 157);
            this.btn_PermDel.Name = "btn_PermDel";
            this.btn_PermDel.Size = new System.Drawing.Size(75, 39);
            this.btn_PermDel.TabIndex = 2;
            this.btn_PermDel.Text = "Xóa vĩnh viễn";
            this.btn_PermDel.UseVisualStyleBackColor = true;
            this.btn_PermDel.Click += new System.EventHandler(this.btn_PermDel_Click);
            // 
            // LichSuXoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 448);
            this.Controls.Add(this.btn_PermDel);
            this.Controls.Add(this.btn_Restore);
            this.Controls.Add(this.lb_LSXKhachHang);
            this.Controls.Add(this.dgv_LichSuXoaKhachHang);
            this.Name = "LichSuXoa";
            this.Text = "LichSuXoa";
            this.Load += new System.EventHandler(this.LichSuXoaKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LichSuXoaKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_LichSuXoaKhachHang;
        private System.Windows.Forms.Label lb_LSXKhachHang;
        private System.Windows.Forms.Button btn_Restore;
        private System.Windows.Forms.Button btn_PermDel;
    }
}