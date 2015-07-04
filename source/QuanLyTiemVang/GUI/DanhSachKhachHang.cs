using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyTiemVang.DTO;
using QuanLyTiemVang.DAO;
using QuanLyTiemVang.BUS;

namespace QuanLyTiemVang.GUI
{
    public partial class DanhSachKhachHang : Form
    {
        private uint makhachhang = 0;

        public DanhSachKhachHang()
        {
            InitializeComponent();
        }

        private void DanhSachKhachHang_Load(object sender, EventArgs e)
        {
            txt_TenKhachHang.Select();
            txt_TienNoHienTai.Text = "0";
            DataTable dt = new DataTable();
            dt = KhachHangDAO.GetAllKhachHang();
            dgv_DanhSachKhachHang.DataSource = dt;
        }

        private void dgv_DanhSachKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = e.RowIndex;
            int Row = dgv_DanhSachKhachHang.Rows.Count;
            if (Index >= 0 && Index < Row - 1)
            {
                makhachhang = Convert.ToUInt32(dgv_DanhSachKhachHang.Rows[Index].Cells[0].Value);
                txt_MaKhachHang.Text = Convert.ToString(makhachhang);
                txt_TenKhachHang.Text = Convert.ToString(dgv_DanhSachKhachHang.Rows[Index].Cells[1].Value);
                comboBox_LoaiKhachHang.Text = Convert.ToString(dgv_DanhSachKhachHang.Rows[Index].Cells[2].Value);
                txt_DiaChi.Text = Convert.ToString(dgv_DanhSachKhachHang.Rows[Index].Cells[3].Value);
                txt_TienNoHienTai.Text = Convert.ToString(dgv_DanhSachKhachHang.Rows[Index].Cells[4].Value);
            }

            if (Index >= Row - 1)
            {
                txt_MaKhachHang.Text = "";
                txt_TenKhachHang.Text = "";
                comboBox_LoaiKhachHang.Text = "";
                txt_DiaChi.Text = "";
                txt_TienNoHienTai.Text = "0";
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            KhachHangDTO kh = new KhachHangDTO();
            if (txt_TenKhachHang.Text == "")
                MessageBox.Show("Chưa nhập Tên khách hàng");
            else if (txt_DiaChi.Text == "")
                MessageBox.Show("Chưa nhập địa chỉ khách hàng");
            else
            {
                kh.TenKhachHang = txt_TenKhachHang.Text;
                kh.LoaiKhachHang = comboBox_LoaiKhachHang.Text;
                kh.DiaChi = txt_DiaChi.Text;
                kh.TienNoHienTai = 0;
                if (KhachHangBUS.ThemKhachHang(kh))
                {
                    DanhSachKhachHang_Load(sender, e);
                    int num = dgv_DanhSachKhachHang.Rows.Count;
                    makhachhang = Convert.ToUInt32(dgv_DanhSachKhachHang.Rows[num - 2].Cells[0].Value);
                    txt_MaKhachHang.Text = Convert.ToString(makhachhang);
                    MessageBox.Show("Thêm thành công");
                }
                else
                    MessageBox.Show("Thêm thất bại");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            KhachHangDTO kh = new KhachHangDTO();
            kh.MaKhachHang = makhachhang;

            if (kh.MaKhachHang != 0)
            {
                DialogResult dl = MessageBox.Show("Bạn có thực sự muốn thoát không?",
                            "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                    if (KhachHangBUS.XoaKhachHang(kh))
                    {
                        string ten_kh = txt_TenKhachHang.Text;
                        //KhachHangDAO.Delete(kh);
                        DanhSachKhachHang_Load(sender, e);
                        TaoMoi();
                        MessageBox.Show("Xóa khách hàng " + ten_kh + " thành công");
                    }
                    else
                        MessageBox.Show("Xoá thất bại");

                    makhachhang = 0;
                }           
            }
            else
                MessageBox.Show("Bạn chưa chọn khách hàng để xóa");
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            KhachHangDTO kh = new KhachHangDTO();
            kh.MaKhachHang = makhachhang;

            if (kh.MaKhachHang != 0)
                if (txt_TenKhachHang.Text == "")
                    MessageBox.Show("Chưa nhập Tên khách hàng");
                else if (txt_DiaChi.Text == "")
                    MessageBox.Show("Chưa nhập địa chỉ khách hàng");
                else
                {
                    kh.TenKhachHang = txt_TenKhachHang.Text;
                    kh.LoaiKhachHang = comboBox_LoaiKhachHang.Text;
                    kh.DiaChi = txt_DiaChi.Text;
                    if (KhachHangBUS.CapNhatKhachHang(kh))
                    {
                        DanhSachKhachHang_Load(sender, e);
                        MessageBox.Show("Cập nhật thành công");
                    }
                    else
                        MessageBox.Show("Cập nhật thất bại");
                }
            else
                MessageBox.Show("Bạn chưa chọn khách hàng để cập nhật lại thông tin");
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            TaoMoi();
        }

        private void TaoMoi()
        {
            txt_MaKhachHang.Text = null;
            txt_TenKhachHang.Text = null;
            comboBox_LoaiKhachHang.Text = "Khách vãng lai";
            txt_DiaChi.Text = null;
            txt_TienNoHienTai.Text = "0";
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
            TraCuuKhachHang frmTraCuuKhachHang = new TraCuuKhachHang();
            frmTraCuuKhachHang.Show();
        }
    }
}
