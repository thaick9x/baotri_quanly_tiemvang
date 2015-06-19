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

namespace QuanLyTiemVang.GUI
{
    public partial class TraCuuKhachHang : Form
    {
        public TraCuuKhachHang()
        {
            InitializeComponent();
        }

        private void TraCuuKhachHang_Load(object sender, EventArgs e)
        {
            radio_MaKhachHang.Checked = true;
            txt_MaKhachHang.ReadOnly = false;
            txt_MaKhachHang.Select();
            dgv_DanhSachKhachHang.DataSource = KhachHangDAO.GetAllKhachHang();
        }

        private void radio_MaKhachHang_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_MaKhachHang.Checked)
            {
                txt_MaKhachHang.ReadOnly = false;
                txt_TenKhachHang.ReadOnly = true;
                txt_LoaiKhachHang.ReadOnly = true;
                txt_DiaChi.ReadOnly = true;
                txt_TienNoTu.ReadOnly = true;
                txt_TienNoDen.ReadOnly = true;
                txt_MaKhachHang.Select();
            }
            else
                txt_MaKhachHang.Text = "";
        }

        private void radio_TenKhachHang_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_TenKhachHang.Checked)
            {
                txt_MaKhachHang.ReadOnly = true;
                txt_TenKhachHang.ReadOnly = false;
                txt_LoaiKhachHang.ReadOnly = true;
                txt_DiaChi.ReadOnly = true;
                txt_TienNoTu.ReadOnly = true;
                txt_TienNoDen.ReadOnly = true;
                txt_TenKhachHang.Select();
            }
            else
                txt_TenKhachHang.Text = "";
        }

        private void radio_LoaiKhachHang_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_LoaiKhachHang.Checked)
            {
                txt_MaKhachHang.ReadOnly = true;
                txt_TenKhachHang.ReadOnly = true;
                txt_LoaiKhachHang.ReadOnly = false;
                txt_DiaChi.ReadOnly = true;
                txt_TienNoTu.ReadOnly = true;
                txt_TienNoDen.ReadOnly = true;
                txt_LoaiKhachHang.Select();
            }
            else
                txt_LoaiKhachHang.Text = "";
        }

        private void radio_DiaChi_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_DiaChi.Checked)
            {
                txt_MaKhachHang.ReadOnly = true;
                txt_TenKhachHang.ReadOnly = true;
                txt_LoaiKhachHang.ReadOnly = true;
                txt_DiaChi.ReadOnly = false;
                txt_TienNoTu.ReadOnly = true;
                txt_TienNoDen.ReadOnly = true;
                txt_DiaChi.Select();
            }
            else
                txt_DiaChi.Text = "";
        }

        private void radio_TienNo_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_TienNo.Checked)
            {
                txt_MaKhachHang.ReadOnly = true;
                txt_TenKhachHang.ReadOnly = true;
                txt_LoaiKhachHang.ReadOnly = true;
                txt_DiaChi.ReadOnly = true;
                txt_TienNoTu.ReadOnly = false;
                txt_TienNoDen.ReadOnly = false;
                txt_TienNoTu.Select();
            }
            else
            {
                txt_TienNoTu.Text = "";
                txt_TienNoDen.Text = "";
            }
        }

        KhachHangDTO kh = new KhachHangDTO();

        private void btn_TraCuu_Click(object sender, EventArgs e)
        {
            if (radio_MaKhachHang.Checked)
            {
                try
                {
                    kh.MaKhachHang = Convert.ToUInt32(txt_MaKhachHang.Text);
                }
                catch
                {
                    MessageBox.Show("Mã Khách hàng phải là số nguyên dương và không được để trống");
                    return;
                }
                dgv_DanhSachKhachHang.DataSource = KhachHangDAO.SelectKhachHangLikeMaKhachHang(kh);
            }
            if (radio_TenKhachHang.Checked)
            {
                kh.TenKhachHang = txt_TenKhachHang.Text;
                dgv_DanhSachKhachHang.DataSource = KhachHangDAO.SelectKhachHangLikeTenKhachHang(kh);
                if (txt_TenKhachHang.Text == "" || txt_TenKhachHang.Text == " ")
                    MessageBox.Show("Tên khách hàng không được để trống");
            }
            if (radio_LoaiKhachHang.Checked)
            {
                kh.LoaiKhachHang = txt_LoaiKhachHang.Text;
                dgv_DanhSachKhachHang.DataSource = KhachHangDAO.SelectKhachHangLikeLoaiKhachHang(kh);
                if (txt_LoaiKhachHang.Text == "" || txt_LoaiKhachHang.Text == " ")
                    MessageBox.Show("Loại khách hàng không được để trống");
            }
            if (radio_DiaChi.Checked)
            {
                kh.DiaChi = txt_DiaChi.Text;
                dgv_DanhSachKhachHang.DataSource = KhachHangDAO.SelectKhachHangLikeDiaChi(kh);
                if (txt_DiaChi.Text == "" || txt_DiaChi.Text == " ")
                    MessageBox.Show("Địa chỉ không được để trống");
            }
            
            if (radio_TienNo.Checked)
            {
                int tiennomin, tiennomax;
                try
                {
                    tiennomin = int.Parse(txt_TienNoTu.Text);
                }
                catch
                {
                    MessageBox.Show("Tiền nợ từ không được để trống");
                    return;
                }
                try
                {
                    tiennomax = int.Parse(txt_TienNoDen.Text);
                }
                catch
                {
                    MessageBox.Show("Tiền nợ đến không được để trống");
                    return;
                }
                if (tiennomin > tiennomax)
                {
                    MessageBox.Show("Tiền nợ từ không được lớn hơn tiền nợ đến");
                    return;
                }
                else
                    dgv_DanhSachKhachHang.DataSource = KhachHangDAO.SelectKhachHangByTienNoHienTai(tiennomin, tiennomax);
            }
            if (dgv_DanhSachKhachHang.Rows.Count == 1)
                MessageBox.Show("Không tìm thấy");
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
