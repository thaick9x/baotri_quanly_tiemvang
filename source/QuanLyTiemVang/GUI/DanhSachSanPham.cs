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
    public partial class DanhSachSanPham : Form
    {
        private uint masanpham = 0;

        public DanhSachSanPham()
        {
            InitializeComponent();
        }

        private void DanhSachSanPham_Load(object sender, EventArgs e)
        {
            txt_TenSanPham.Select();
            DataTable dt = SanPhamDAO.GetAllSanPham();
            dgv_DanhSachSanPham.DataSource = dt;
            txt_SoLuongTon.Text = "0";
        }

        private void dgv_DanhSachSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = e.RowIndex;
            int Row = dgv_DanhSachSanPham.Rows.Count;
            if (Index >= 0 && Index < Row - 1)
            {
                masanpham = Convert.ToUInt32(dgv_DanhSachSanPham.Rows[Index].Cells[0].Value);
                txt_MaSanPham.Text = masanpham.ToString();
                txt_TenSanPham.Text = Convert.ToString(dgv_DanhSachSanPham.Rows[Index].Cells[1].Value);
                ComboBox_LoaiSanPham.Text = Convert.ToString(dgv_DanhSachSanPham.Rows[Index].Cells[2].Value);
                txt_SoLuongTon.Text = Convert.ToString(dgv_DanhSachSanPham.Rows[Index].Cells[3].Value);
            }

            if (Index >= Row - 1)
            {
                masanpham = 0;
                txt_TenSanPham.Text = "";
                ComboBox_LoaiSanPham.Text = "";
                txt_SoLuongTon.Text = "";
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_TenSanPham.Text == "" || txt_TenSanPham.Text == " ")
                MessageBox.Show("Chưa nhập tên sản phẩm!!");
            else if (ComboBox_LoaiSanPham.Text == "" || ComboBox_LoaiSanPham.Text == " ")
                MessageBox.Show("Chưa nhập loại sản phẩm!!");
            else
            {
                SanPhamDTO sp = new SanPhamDTO();
                sp.TenSanPham = txt_TenSanPham.Text;
                sp.LoaiSanPham = ComboBox_LoaiSanPham.Text;
                sp.SoLuongTon = 0;
                if (SanPhamBUS.ThemSanPham(sp))
                {
                    DanhSachSanPham_Load(sender, e);
                    masanpham = Convert.ToUInt32(dgv_DanhSachSanPham.Rows[dgv_DanhSachSanPham.Rows.Count - 2].Cells[0].Value);
                    txt_MaSanPham.Text = masanpham.ToString();
                    MessageBox.Show("Thêm thành công!!");
                }
                else
                    MessageBox.Show("Thêm thất bại!!");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            SanPhamDTO sp = new SanPhamDTO();
            sp.MaSanPham = masanpham;
            if (sp.MaSanPham != 0)
            {
                DialogResult dl = MessageBox.Show("Bạn có thực sự muốn thoát không?",
                     "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                    if (SanPhamBUS.XoaSanPham(sp))
                    {
                        string tensp = txt_TenSanPham.Text;
                        DanhSachSanPham_Load(sender, e);
                        TaoMoi();
                        MessageBox.Show("Xóa sản phẩm " + tensp + " thành công!!");
                        masanpham = 0;
                    }
                    else
                        MessageBox.Show("Xóa thất bại!!");
                }
            }
            else
                MessageBox.Show("Bạn chưa chọn sản phẩm để xóa!!");
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            TaoMoi();
        }

        private void TaoMoi()
        {
            txt_MaSanPham.Text = "";
            txt_TenSanPham.Text = "";
            ComboBox_LoaiSanPham.Text = "";
            txt_SoLuongTon.Text = "0";
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            SanPhamDTO sp = new SanPhamDTO();
            sp.MaSanPham = masanpham;
            if (sp.MaSanPham != 0)
            {
                sp.TenSanPham = txt_TenSanPham.Text;
                sp.LoaiSanPham = ComboBox_LoaiSanPham.Text;
                if (SanPhamBUS.CapNhatSanPham(sp))
                {
                    DanhSachSanPham_Load(sender, e);
                    MessageBox.Show("Cập nhật thành công!!");
                }
                else
                    MessageBox.Show("Cập nhật thất bại!!");
            }
            else
                MessageBox.Show("Bạn chưa chọn sản phẩm để cập nhật!!");
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có thực sự muốn thoát khỏi nghiệp vụ này không?",
              "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
                this.Close();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            TraCuuSanPham frmTraCuuSanPham = new TraCuuSanPham();
            frmTraCuuSanPham.Show();
        }

        private void btn_lichSuXoaSP_Click(object sender, EventArgs e)
        {
            LichSuXoa frmLSXSanPham = new LichSuXoa(new SanPhamDAO(), "sản phẩm");
            frmLSXSanPham.ShowDialog();

            DanhSachSanPham_Load(sender, e);
        }
    }
}
