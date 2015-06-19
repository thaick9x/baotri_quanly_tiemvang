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
    public partial class TraCuuSanPham : Form
    {
        public TraCuuSanPham()
        {
            InitializeComponent();
        }

        private void TraCuuSanPham_Load(object sender, EventArgs e)
        {
            radio_MaSanPham.Checked = true;
            txt_MaSanPham.Select();
            dgv_DanhSachSanPham.DataSource = SanPhamDAO.GetAllSanPham();
        }

        private void radio_MaSanPham_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_MaSanPham.Checked)
            {
                txt_MaSanPham.ReadOnly = false;
                txt_TenSanPham.ReadOnly = true;
                txt_LoaiSanPham.ReadOnly = true;
                txt_SoLuongTonTu.ReadOnly = true;
                txt_SoLuongTonDen.ReadOnly = true;
                txt_MaSanPham.Select();
            }
            else
                txt_MaSanPham.Text = "";
        }

        private void radio_TenSanPham_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_TenSanPham.Checked)
            {
                txt_MaSanPham.ReadOnly = true;
                txt_TenSanPham.ReadOnly = false;
                txt_LoaiSanPham.ReadOnly = true;
                txt_SoLuongTonTu.ReadOnly = true;
                txt_SoLuongTonDen.ReadOnly = true;
                txt_TenSanPham.Select();
            }
            else
                txt_TenSanPham.Text = "";
        }
        private void radio_LoaiSanPham_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_LoaiSanPham.Checked)
            {
                txt_MaSanPham.ReadOnly = true;
                txt_TenSanPham.ReadOnly = true;
                txt_LoaiSanPham.ReadOnly = false;
                txt_SoLuongTonTu.ReadOnly = true;
                txt_SoLuongTonDen.ReadOnly = true;
                txt_LoaiSanPham.Select();
            }
            else
                txt_LoaiSanPham.Text = "";
        }

        private void radio_SoLuongTon_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_SoLuongTon.Checked)
            {
                txt_MaSanPham.ReadOnly = true;
                txt_TenSanPham.ReadOnly = true;
                txt_LoaiSanPham.ReadOnly = true;
                txt_SoLuongTonTu.ReadOnly = false;
                txt_SoLuongTonDen.ReadOnly = false;
                txt_SoLuongTonTu.Select();
            }
            else
            {
                txt_SoLuongTonTu.Text = "";
                txt_SoLuongTonDen.Text = "";
            }
        }

        SanPhamDTO sp = new SanPhamDTO();
        private void btn_TraCuu_Click(object sender, EventArgs e)
        {
            if (radio_MaSanPham.Checked)
            {
                try
                {
                    sp.MaSanPham = Convert.ToUInt32(txt_MaSanPham.Text);
                }
                catch
                {
                    MessageBox.Show("Mã sản phẩm phải là số nguyên dương và không được để trống");
                    return;
                }
                dgv_DanhSachSanPham.DataSource = SanPhamDAO.SelectSanPhamLikeMaSanPham(sp);
            }
            if (radio_TenSanPham.Checked)
            {
                sp.TenSanPham = txt_TenSanPham.Text;
                dgv_DanhSachSanPham.DataSource = SanPhamDAO.SelectSanPhamLikeTenSanPham(sp);
                if (txt_TenSanPham.Text == "" || txt_TenSanPham.Text == " ")
                    MessageBox.Show("Tên sản phẩm không được để trống");
            }
            if (radio_LoaiSanPham.Checked)
            {
                sp.LoaiSanPham = txt_LoaiSanPham.Text;
                dgv_DanhSachSanPham.DataSource = SanPhamDAO.SelectSanPhamLikeLoaiSanPham(sp);
                if (txt_LoaiSanPham.Text == "" || txt_LoaiSanPham.Text == " ")
                    MessageBox.Show("Loại sản phẩm không được để trống");
            }

            if (radio_SoLuongTon.Checked)
            {
                int soluongtonmin, soluongtonmax;
                try
                {
                    soluongtonmin = int.Parse(txt_SoLuongTonTu.Text);
                }
                catch
                {
                    MessageBox.Show("Số lượng tồn từ không được để trống");
                    return;
                }
                try
                {
                    soluongtonmax = int.Parse(txt_SoLuongTonDen.Text);
                }
                catch
                {
                    MessageBox.Show("Số lượng tồn đến không được để trống");
                    return;
                }
                if (soluongtonmin > soluongtonmax)
                {
                    MessageBox.Show("Số lượng tồn từ không được lớn hơn số lượng tồn đến");
                    return;
                }
                else
                    dgv_DanhSachSanPham.DataSource = SanPhamDAO.SelectSanPhamBySoLuongTon(soluongtonmin, soluongtonmax);
            }
            if (dgv_DanhSachSanPham.Rows.Count == 1)
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
