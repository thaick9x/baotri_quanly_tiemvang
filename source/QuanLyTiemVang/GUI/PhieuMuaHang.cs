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
    public partial class PhieuMuaHang : Form
    {
        private int stt = 0;
        private uint soluongmua;
        private uint dongiamua;
        private bool ktra_khachhang = false;
        private bool ktra_chitietphieumuahang = false;
        private bool ktra_masanpham = false;
        private bool ktra_trungmasanpham = false;
        private bool ktra_soluongmua = false;
        private bool ktra_dongiamua = false;

        public PhieuMuaHang()
        {
            InitializeComponent();
        }

        private void PhieuMuaHang_Load(object sender, EventArgs e)
        {
            txt_MaKhachHang.Select();
            dgv_ChiTietPhieuMuaHang.Rows[0].Cells[1].ReadOnly = true;
        }

        private void txt_MaKhachHang_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void dgv_ChiTietPhieuMuaHang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            stt = e.RowIndex;
            dgv_ChiTietPhieuMuaHang.Rows[stt].Cells[0].Value = (stt + 1).ToString();
            if (dgv_ChiTietPhieuMuaHang.Rows[stt].Cells[1].Value == null)
            {
                dgv_ChiTietPhieuMuaHang.Rows[stt].Cells[5].ReadOnly = true;
                dgv_ChiTietPhieuMuaHang.Rows[stt].Cells[6].ReadOnly = true;
            }
            else
            {
                ////dgv_ChiTietPhieuMuaHang.Rows[stt + 1].ReadOnly = true;
                uint masanpham;
                try
                {
                    masanpham = Convert.ToUInt32(dgv_ChiTietPhieuMuaHang.Rows[stt].Cells[1].Value);
                }
                catch
                {
                    MessageBox.Show("Mã sản phẩm phải là số nguyên dương và không được để trống!!");
                    return;
                }
                if (dgv_ChiTietPhieuMuaHang.Rows[stt].Cells[5].Value == null)
                    ktra_soluongmua = false;
                if (dgv_ChiTietPhieuMuaHang.Rows[stt].Cells[6].Value == null)
                    ktra_dongiamua = false;

                for (int i = 0; i < dgv_ChiTietPhieuMuaHang.Rows.Count - 1; i++)
                    if (Convert.ToUInt32(dgv_ChiTietPhieuMuaHang.Rows[stt].Cells[1].Value) == Convert.ToUInt32(dgv_ChiTietPhieuMuaHang.Rows[i].Cells[1].Value) && i != stt)
                    {
                        ktra_trungmasanpham = false;
                        ktra_masanpham = false;
                        MessageBox.Show("Sản phẩm trên đã tồn tại trong danh sách phiếu nhập!!");
                        break;
                    }
                    else
                        ktra_trungmasanpham = true;

                if (ktra_trungmasanpham)
                {
                    SanPhamDTO sp = new SanPhamDTO();
                    sp.MaSanPham = masanpham;
                    DataTable dt = SanPhamDAO.SelectSanPhamByMaSanPham(sp);

                    if (dt != null && dt.Rows.Count > 0)
                    {
                        dgv_ChiTietPhieuMuaHang.Rows[stt].Cells[2].Value = Convert.ToString(dt.Rows[0]["TenSanPham"]);
                        dgv_ChiTietPhieuMuaHang.Rows[stt].Cells[3].Value = Convert.ToString(dt.Rows[0]["LoaiSanPham"]);
                        dgv_ChiTietPhieuMuaHang.Rows[stt].Cells[4].Value = Convert.ToString(dt.Rows[0]["SoLuongTon"]);
                        dgv_ChiTietPhieuMuaHang.Rows[stt].Cells[5].ReadOnly = false;
                        dgv_ChiTietPhieuMuaHang.Rows[stt].Cells[6].ReadOnly = false;
                        ktra_masanpham = true;
                    }
                    else
                    {
                        MessageBox.Show("Mã sản phẩm trên không có trong danh sách sản phẩm!!");
                        ktra_masanpham = false;
                    }
                }

                int soluongtontruockhimua = Convert.ToInt32(dgv_ChiTietPhieuMuaHang.Rows[stt].Cells[4].Value);

                if (dgv_ChiTietPhieuMuaHang.Rows[stt].Cells[5].Value != null)
                {
                    try
                    {
                        soluongmua = Convert.ToUInt32(dgv_ChiTietPhieuMuaHang.Rows[stt].Cells[5].Value);
                    }
                    catch
                    {
                        MessageBox.Show("Số lượng mua phải là số nguyên dương và không được để trống!!");
                        return;
                    }
                    if (soluongmua == 0)
                    {
                        MessageBox.Show("Số lượng mua phải là số nguyên dương và không được để trống!!");
                        ktra_soluongmua = false;
                    }
                    else
                        ktra_soluongmua = true;
                }

                if (dgv_ChiTietPhieuMuaHang.Rows[stt].Cells[6].Value != null)
                {
                    try
                    {
                        dongiamua = Convert.ToUInt32(dgv_ChiTietPhieuMuaHang.Rows[stt].Cells[6].Value);
                    }
                    catch
                    {
                        MessageBox.Show("Đơn giá mua phải là số nguyên dương và không được để trống!!");
                        return;
                    }
                    if (dongiamua == 0)
                    {
                        MessageBox.Show("Đơn giá mua phải là số nguyên dương và không được để trống!!");
                        ktra_dongiamua = false;
                    }
                    else
                        ktra_dongiamua = true;
                }

                if (ktra_masanpham && ktra_soluongmua && ktra_dongiamua)
                {
                    ktra_chitietphieumuahang = true;
                    long thanhtien = soluongmua * dongiamua;
                    dgv_ChiTietPhieuMuaHang.Rows[stt].Cells[7].Value = Convert.ToString(thanhtien);
                    dgv_ChiTietPhieuMuaHang.Rows[stt + 1].ReadOnly = false;
                    dgv_ChiTietPhieuMuaHang.Rows[dgv_ChiTietPhieuMuaHang.Rows.Count - 1].Cells[5].ReadOnly = true;
                    dgv_ChiTietPhieuMuaHang.Rows[dgv_ChiTietPhieuMuaHang.Rows.Count - 1].Cells[6].ReadOnly = true;
                }
                else
                    ktra_chitietphieumuahang = false;
                if (ktra_chitietphieumuahang && ktra_khachhang)
                    btn_LapPhieu.Enabled = true;
                else
                    btn_LapPhieu.Enabled = false;
            }

            long tongtrigia = 0;
            for (int i = 0; i < dgv_ChiTietPhieuMuaHang.Rows.Count - 1; i++)
            {
                tongtrigia += Convert.ToInt64(dgv_ChiTietPhieuMuaHang.Rows[i].Cells[7].Value);
            }
            txt_TongCong.Text = tongtrigia.ToString();
        }

        private void btn_LapPhieu_Click(object sender, EventArgs e)
        {
            bool ktra_lapphieumuahang = false;
            PhieuMuaHangDTO pmh = new PhieuMuaHangDTO();
            ChiTietPhieuMuaHangDTO ctpmh = new ChiTietPhieuMuaHangDTO();
            pmh.NgayMua = dateTimePicker_NgayMua.Value;
            pmh.NgayThanhToan = dateTimePicker_NgayThanhToan.Value;
            pmh.TongCong = uint.Parse(txt_TongCong.Text);
            try
            {
                pmh.MaKhachHang = uint.Parse(txt_MaKhachHang.Text);
            }
            catch
            {
                MessageBox.Show("Mã khách hàng không hợp lệ, vui lòng kiểm tra lại!!");
                return;
            }
            if (PhieuMuaHangBUS.ThemPhieuMuaHang(pmh) == false)
                MessageBox.Show("Thêm thất bại!!");
            else
            {
                DataTable dt = PhieuMuaHangDAO.GetAllPhieuMuaHang();
                pmh.MaPhieuMuaHang = Convert.ToUInt32(dt.Rows[dt.Rows.Count - 1]["MaPhieuMuaHang"]);
                ctpmh.MaPhieuMuaHang = pmh.MaPhieuMuaHang;
                for (int i = 0; i < dgv_ChiTietPhieuMuaHang.Rows.Count - 1; i++)
                {
                    try
                    {
                        ctpmh.MaSanPham = Convert.ToUInt32(dgv_ChiTietPhieuMuaHang.Rows[i].Cells[1].Value);
                    }
                    catch
                    {
                        MessageBox.Show("Mã sản phẩm trong danh sách không hợp lệ, vui lòng kiểm tra lại!");
                        return;
                    }
                    try
                    {
                        ctpmh.SoLuongMua = Convert.ToUInt32(dgv_ChiTietPhieuMuaHang.Rows[i].Cells[5].Value);
                    }
                    catch
                    {
                        MessageBox.Show("Số lượng bán trong danh sách không hợp lệ, vui lòng kiểm tra lại!");
                        return;
                    }
                    try
                    {
                        ctpmh.DonGiaMua = Convert.ToUInt32(dgv_ChiTietPhieuMuaHang.Rows[i].Cells[6].Value);
                    }
                    catch
                    {
                        MessageBox.Show("Đơn giá trong danh sách không hợp lệ, vui lòng kiểm tra lại!");
                        return;
                    }
                    ctpmh.ThanhTien = Convert.ToUInt32(dgv_ChiTietPhieuMuaHang.Rows[i].Cells[7].Value);
                    if (ChiTietPhieuMuaHangBUS.ThemChiTietPhieuMuaHang(ctpmh) == false)
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                    else
                    {
                        // Cập nhật số lượng tồn trong bảng SANPHAM
                        ktra_lapphieumuahang = true;
                        uint soluongtontruockhimua = Convert.ToUInt32(dgv_ChiTietPhieuMuaHang.Rows[i].Cells[4].Value);
                        uint soluongmua = Convert.ToUInt32(dgv_ChiTietPhieuMuaHang.Rows[i].Cells[5].Value);
                        SanPhamDTO sp = new SanPhamDTO();
                        sp.MaSanPham = Convert.ToUInt32(dgv_ChiTietPhieuMuaHang.Rows[i].Cells[1].Value);
                        sp.SoLuongTon = soluongtontruockhimua + soluongmua;
                        SanPhamDAO.UpdateSoLuongTon(sp);
                    }
                }
            }
            if (ktra_lapphieumuahang)
            {
                txt_MaPhieu.Text = pmh.MaPhieuMuaHang.ToString();
                txt_MaKhachHang.ReadOnly = true;
                dgv_ChiTietPhieuMuaHang.ReadOnly = true;
                btn_LapPhieu.Enabled = false;
                btn_XoaPhieu.Enabled = true;
                MessageBox.Show("Lập phiếu mua hàng thành công!!");
            }
        }

        private void btn_TaoPhieuMoi_Click(object sender, EventArgs e)
        {
            TaoPhieuMuaHangMoi();
        }

        private void TaoPhieuMuaHangMoi()
        {
            ktra_khachhang = false;
            ktra_chitietphieumuahang = false;
            ktra_masanpham = false;
            ktra_trungmasanpham = false;
            ktra_soluongmua = false;
            ktra_dongiamua = false;
            btn_LapPhieu.Enabled = false;
            btn_XoaPhieu.Enabled = false;
            txt_MaKhachHang.ReadOnly = false;
            txt_MaPhieu.Text = null;
            // ignore textChange event when reset form
            txt_MaKhachHang.TextChanged -= txt_MaKhachHang_TextChanged;
            txt_MaKhachHang.Text = null;
            txt_MaKhachHang.TextChanged += txt_MaKhachHang_TextChanged;
            // end ignore
            txt_TenKhachHang.Text = null;
            txt_DiaChi.Text = null;
            txt_TongCong.Text = null;
            int num = dgv_ChiTietPhieuMuaHang.Rows.Count;
            for (int i = 0; i < num - 1; i++)
                dgv_ChiTietPhieuMuaHang.Rows.RemoveAt(0);
            dgv_ChiTietPhieuMuaHang.ReadOnly = false;
            dgv_ChiTietPhieuMuaHang.Rows[0].ReadOnly = true;
        }

        private void btn_XoaPhieu_Click(object sender, EventArgs e)
        {
            DataTable dt = PhieuMuaHangDAO.GetAllPhieuMuaHang();
            PhieuMuaHangDTO pmh = new PhieuMuaHangDTO();
            pmh.MaPhieuMuaHang = Convert.ToUInt32(dt.Rows[dt.Rows.Count - 1]["MaPhieuMuaHang"]);
            if (PhieuMuaHangBUS.XoaPhieuMuaHang(pmh) == false)
                MessageBox.Show("Xóa thất bại!!");
            else
            {
                ChiTietPhieuMuaHangDTO ctpmh = new ChiTietPhieuMuaHangDTO();
                ctpmh.MaPhieuMuaHang = pmh.MaPhieuMuaHang;
                if (ChiTietPhieuMuaHangBUS.XoaChiTietPhieuMuaHang(ctpmh) == false)
                    MessageBox.Show("Xóa thất bại!!");
                else
                {
                    btn_XoaPhieu.Enabled = false;
                    SanPhamDTO sp = new SanPhamDTO();
                    for (int i = 0; i < dgv_ChiTietPhieuMuaHang.Rows.Count - 1; i++)
                    {
                        // Cập nhật số lượng tồn trong bảng SANPHAM
                        sp.MaSanPham = Convert.ToUInt32(dgv_ChiTietPhieuMuaHang.Rows[i].Cells[1].Value);
                        sp.SoLuongTon = Convert.ToUInt32(dgv_ChiTietPhieuMuaHang.Rows[i].Cells[4].Value);
                        SanPhamDAO.UpdateSoLuongTon(sp);
                        btn_XoaPhieu.Enabled = false;
                    }
                    TaoPhieuMuaHangMoi();
                    MessageBox.Show("Xóa phiếu mua hàng thành công!!");
                }
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có thực sự muốn thoát khỏi nghiệp vụ này không?",
              "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
                this.Close();
        }

        private void btn_TraCuuKhachHang_Click(object sender, EventArgs e)
        {
            TraCuuKhachHang frmTraCuuKhachHang = new TraCuuKhachHang();
            frmTraCuuKhachHang.ShowDialog();
            txt_MaKhachHang.Text = frmTraCuuKhachHang.MaKhachHang_Return.ToString();
        }

        private void btn_TraCuuSanPham_Click(object sender, EventArgs e)
        {
            TraCuuSanPham frmTraCuuSanPham = new TraCuuSanPham();
            frmTraCuuSanPham.ShowDialog();

            // DataGridView Editing
            int last_row = dgv_ChiTietPhieuMuaHang.RowCount - 1;
            dgv_ChiTietPhieuMuaHang.CurrentCell = dgv_ChiTietPhieuMuaHang[1, last_row];
            dgv_ChiTietPhieuMuaHang.BeginEdit(false);
            dgv_ChiTietPhieuMuaHang.NotifyCurrentCellDirty(true);
            dgv_ChiTietPhieuMuaHang.Rows[last_row].Cells[1].Value = frmTraCuuSanPham.MaSanPham_Return;
            dgv_ChiTietPhieuMuaHang.NotifyCurrentCellDirty(false);
            dgv_ChiTietPhieuMuaHang.EndEdit();
        }

        private void txt_MaKhachHang_TextChanged(object sender, EventArgs e)
        {
            if (txt_MaKhachHang.Text == "")
            {
                txt_TenKhachHang.Text = "";
                txt_DiaChi.Text = "";
            }
            uint makh;
            try
            {
                makh = uint.Parse(txt_MaKhachHang.Text);
            }
            catch
            {
                MessageBox.Show("Mã khách hàng phải là số nguyên dương và không được để trống!!");
                return;
            }
            DataTable dt = KhachHangDAO.SelectKhachHangByMaKhachHang(makh);
            if (dt != null && dt.Rows.Count > 0)
            {
                ktra_khachhang = true;
                txt_TenKhachHang.Text = Convert.ToString(dt.Rows[0]["TenKhachHang"]);
                txt_DiaChi.Text = Convert.ToString(dt.Rows[0]["DiaChi"]);
                dgv_ChiTietPhieuMuaHang.Rows[0].Cells[1].ReadOnly = false;
            }
            else
            {
                MessageBox.Show("Mã khách hàng này không có trong danh sách khách hàng!!");
                ktra_khachhang = false;
            }
            if (ktra_khachhang && ktra_chitietphieumuahang)
                btn_LapPhieu.Enabled = true;
            else
                btn_LapPhieu.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DanhSachKhachHang f = new DanhSachKhachHang();
            f.Show();
        }
    }
}
