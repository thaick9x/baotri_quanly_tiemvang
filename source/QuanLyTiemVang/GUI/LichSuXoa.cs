using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyTiemVang.DAO;
using QuanLyTiemVang.DTO;

namespace QuanLyTiemVang.GUI
{
    public partial class LichSuXoa : Form
    {
        private IRestorableData innerDAO;
        public LichSuXoa()
        {
            InitializeComponent();
        }

        public LichSuXoa(IRestorableData dao, string text)
        {
            InitializeComponent();
            this.Text = "Lịch sử xóa " + text;
            this.lb_LSXKhachHang.Text = "Danh sách " + text + " đã xóa: ";
            innerDAO = dao;
        }

        private void LichSuXoaKhachHang_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            // lay duoc cell dang select 
            uint makh = Convert.ToUInt32(dgv_LichSuXoaKhachHang.CurrentRow.Cells["MaKhachHang"].Value);
            //MessageBox.Show(makh.ToString());

            innerDAO.RestoreTemp(makh);
            RefreshForm();
        }

        private void RefreshForm()
        {
            dgv_LichSuXoaKhachHang.DataSource = KhachHangDAO.GetAllTempDeletedKhachHang();
        }

        private void btn_PermDel_Click(object sender, EventArgs e)
        {
            // lay duoc cell dang select 
            uint makh = Convert.ToUInt32(dgv_LichSuXoaKhachHang.CurrentRow.Cells["MaKhachHang"].Value);

            innerDAO.PermDelete(makh);
            RefreshForm();
        }
    }
}
