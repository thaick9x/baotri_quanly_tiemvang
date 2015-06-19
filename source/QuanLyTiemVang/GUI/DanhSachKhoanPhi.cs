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
using QuanLyTiemVang.BUS;

namespace QuanLyTiemVang.GUI
{
    public partial class DanhSachKhoanPhi : Form
    {
        private uint makhoanphi = 0;

        public DanhSachKhoanPhi()
        {
            InitializeComponent();
        }

        private void DanhSachKhoanPhi_Load(object sender, EventArgs e)
        {
            txt_TenKhoanPhi.Select();
            DataTable dt = KhoanPhiDAO.GetAllKhoanPhi();
            dgv_DanhSachKhoanPhi.DataSource = dt;
        }

        private void dgv_DanhSachKhoanPhi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = e.RowIndex;
            int Row = dgv_DanhSachKhoanPhi.Rows.Count;
            if (Index >= 0 && Index < Row - 1)
            {
                makhoanphi = Convert.ToUInt32(dgv_DanhSachKhoanPhi.Rows[Index].Cells[0].Value);
                txt_MaKhoanPhi.Text = Convert.ToString(makhoanphi);
                txt_TenKhoanPhi.Text = Convert.ToString(dgv_DanhSachKhoanPhi.Rows[Index].Cells[1].Value);
            }

            if (Index >= Row - 1)
            {
                txt_MaKhoanPhi.Text = "";
                txt_TenKhoanPhi.Text = "";
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            KhoanPhiDTO kp = new KhoanPhiDTO();
            if (txt_TenKhoanPhi.Text == "")
                MessageBox.Show("Chưa nhập Tên khoản phí");
            else
            {
                kp.TenKhoanPhi = txt_TenKhoanPhi.Text;
                if (KhoanPhiBUS.ThemKhoanPhi(kp))
                {
                    DanhSachKhoanPhi_Load(sender, e);
                    int num = dgv_DanhSachKhoanPhi.Rows.Count;
                    makhoanphi = Convert.ToUInt32(dgv_DanhSachKhoanPhi.Rows[num - 2].Cells[0].Value);
                    txt_MaKhoanPhi.Text = Convert.ToString(makhoanphi);
                    MessageBox.Show("Thêm thành công");
                }
                else
                    MessageBox.Show("Thêm thất bại");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            KhoanPhiDTO kp = new KhoanPhiDTO();
            kp.MaKhoanPhi = uint.Parse(txt_MaKhoanPhi.Text);
            if (kp.MaKhoanPhi != 0)
            {
                if (KhoanPhiBUS.XoaKhoanPhi(kp))
                {
                    DanhSachKhoanPhi_Load(sender, e);
                    TaoMoi();
                    MessageBox.Show("Xóa thành công");
                }
                else
                    MessageBox.Show("Xoá thất bại");
            }
            else
                MessageBox.Show("Bạn chưa chọn khoản phí để xóa");
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            KhoanPhiDTO kp = new KhoanPhiDTO();
            kp.MaKhoanPhi = uint.Parse(txt_MaKhoanPhi.Text);
            if (kp.MaKhoanPhi != 0)
                if (txt_TenKhoanPhi.Text == "")
                    MessageBox.Show("Chưa nhập Tên khoản phí");
                else
                {
                    kp.TenKhoanPhi = txt_TenKhoanPhi.Text;
                    if (KhoanPhiBUS.CapNhatKhoanPhi(kp))
                    {
                        DanhSachKhoanPhi_Load(sender, e);
                        MessageBox.Show("Cập nhật thành công");
                    }
                    else
                        MessageBox.Show("Cập nhật thất bại");
                }
            else
                MessageBox.Show("Bạn chưa chọn khoản phí để cập nhật lại thông tin");
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            TaoMoi();
        }

        private void TaoMoi()
        {
            txt_MaKhoanPhi.Text = "";
            txt_TenKhoanPhi.Text = "";
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có thực sự muốn thoát khỏi nghiệp vụ này không?",
              "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
                this.Close();
        }
    }
}
