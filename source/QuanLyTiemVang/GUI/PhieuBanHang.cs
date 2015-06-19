using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using QuanLyTiemVang.DAO;
using QuanLyTiemVang.DTO;
using QuanLyTiemVang.BUS;

namespace QuanLyTiemVang.GUI
{
    public partial class PhieuBanHang : Form
    {
        private int stt = 0;
        private uint soluongban;
        private uint dongiaban;
        private bool ktra_khachhang = false;
        private bool ktra_chitietphieubanhang = false;
        private bool ktra_sotienthanhtoan = false;
        private bool ktra_masanpham = false;
        private bool ktra_trungmasanpham = false;
        private bool ktra_soluongban = false;
        private bool ktra_dongiaban = false;

        public PhieuBanHang()
        {
            InitializeComponent();
        }

        private void PhieuBanHang_Load(object sender, EventArgs e)
        {
            txt_MaKhachHang.Select();
            dgv_ChiTietPhieuBanHang.Rows[0].ReadOnly = true;
            txt_SoTienThanhToan.ReadOnly = true;
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
                dgv_ChiTietPhieuBanHang.Rows[0].Cells[1].ReadOnly = false;
            }
            else
            {
                MessageBox.Show("Mã khách hàng này không có trong danh sách khách hàng!!");
                ktra_khachhang = false;
            }
            if (ktra_khachhang && ktra_chitietphieubanhang && ktra_sotienthanhtoan)
                btn_LapPhieu.Enabled = true;
            else
                btn_LapPhieu.Enabled = false;
        }

        private void dgv_ChiTietPhieuBanHang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            stt = e.RowIndex;
            dgv_ChiTietPhieuBanHang.Rows[stt].Cells[0].Value = (stt + 1).ToString();
            if (dgv_ChiTietPhieuBanHang.Rows[stt].Cells[1].Value == null)
            {
                dgv_ChiTietPhieuBanHang.Rows[stt].Cells[5].ReadOnly = true;
                dgv_ChiTietPhieuBanHang.Rows[stt].Cells[6].ReadOnly = true;
            }
            else
            {
                dgv_ChiTietPhieuBanHang.Rows[stt + 1].ReadOnly = true;
                uint masanpham;
                try
                {
                    masanpham = Convert.ToUInt32(dgv_ChiTietPhieuBanHang.Rows[stt].Cells[1].Value);
                }
                catch
                {
                    MessageBox.Show("Mã sản phẩm phải là số nguyên dương và không được để trống!!");
                    return;
                }
                if (dgv_ChiTietPhieuBanHang.Rows[stt].Cells[5].Value == null)
                    ktra_soluongban = false;
                if (dgv_ChiTietPhieuBanHang.Rows[stt].Cells[6].Value == null)
                    ktra_dongiaban = false;

                for (int i = 0; i < dgv_ChiTietPhieuBanHang.Rows.Count - 1; i++)
                    if (Convert.ToUInt32(dgv_ChiTietPhieuBanHang.Rows[stt].Cells[1].Value) == Convert.ToUInt32(dgv_ChiTietPhieuBanHang.Rows[i].Cells[1].Value) && i != stt)
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

                        dgv_ChiTietPhieuBanHang.Rows[stt].Cells[2].Value = Convert.ToString(dt.Rows[0]["TenSanPham"]);
                        dgv_ChiTietPhieuBanHang.Rows[stt].Cells[3].Value = Convert.ToString(dt.Rows[0]["LoaiSanPham"]);
                        dgv_ChiTietPhieuBanHang.Rows[stt].Cells[4].Value = Convert.ToString(dt.Rows[0]["SoLuongTon"]);
                        uint soluongton = Convert.ToUInt32(dgv_ChiTietPhieuBanHang.Rows[stt].Cells[4].Value);
                        dgv_ChiTietPhieuBanHang.Rows[stt].Cells[5].ReadOnly = false;
                        dgv_ChiTietPhieuBanHang.Rows[stt].Cells[6].ReadOnly = false;
                        ktra_masanpham = true;
                    }
                    else
                    {
                        MessageBox.Show("Mã sản phẩm trên không có trong danh sách sản phẩm!!");
                        ktra_masanpham = false;
                    }
                }

                int soluongtontruockhiban = Convert.ToInt32(dgv_ChiTietPhieuBanHang.Rows[stt].Cells[4].Value);

                if (dgv_ChiTietPhieuBanHang.Rows[stt].Cells[5].Value != null)
                {
                    try
                    {
                        soluongban = Convert.ToUInt32(dgv_ChiTietPhieuBanHang.Rows[stt].Cells[5].Value);
                    }
                    catch
                    {
                        MessageBox.Show("Số lượng bán phải là số nguyên dương và không được để trống!!");
                        return;
                    }
                    if (soluongban == 0)
                    {
                        MessageBox.Show("Số lượng bán phải là số nguyên dương và không được để trống!!");
                        ktra_soluongban = false;
                    }
                    else
                        if (soluongban > soluongtontruockhiban)
                        {
                            MessageBox.Show("Số lượng bán không được vượt quá số lượng tồn của sản phẩm!!");
                            ktra_soluongban = false;
                        }
                        else
                            ktra_soluongban = true;
                }

                if (dgv_ChiTietPhieuBanHang.Rows[stt].Cells[6].Value != null)
                {
                    try
                    {
                        dongiaban = Convert.ToUInt32(dgv_ChiTietPhieuBanHang.Rows[stt].Cells[6].Value);
                    }
                    catch
                    {
                        MessageBox.Show("Đơn giá bán phải là số nguyên dương và không được để trống!!");
                        return;
                    }
                    if (dongiaban == 0)
                    {
                        MessageBox.Show("Đơn giá bán phải là số nguyên dương và không được để trống!!");
                        ktra_dongiaban = false;
                    }
                    else
                        ktra_dongiaban = true;
                }

                if (ktra_masanpham && ktra_soluongban && ktra_dongiaban)
                {
                    ktra_chitietphieubanhang = true;
                    long thanhtien = soluongban * dongiaban;
                    dgv_ChiTietPhieuBanHang.Rows[stt].Cells[7].Value = Convert.ToString(thanhtien);
                    dgv_ChiTietPhieuBanHang.Rows[stt + 1].ReadOnly = false;
                    dgv_ChiTietPhieuBanHang.Rows[dgv_ChiTietPhieuBanHang.Rows.Count - 1].Cells[5].ReadOnly = true;
                    dgv_ChiTietPhieuBanHang.Rows[dgv_ChiTietPhieuBanHang.Rows.Count - 1].Cells[6].ReadOnly = true;
                    txt_SoTienThanhToan.ReadOnly = false;
                }
                else
                    ktra_chitietphieubanhang = false;
                if (ktra_chitietphieubanhang && ktra_khachhang && ktra_sotienthanhtoan)
                    btn_LapPhieu.Enabled = true;
                else
                    btn_LapPhieu.Enabled = false;
            }

            long tongcong = 0;
            for (int i = 0; i < dgv_ChiTietPhieuBanHang.Rows.Count - 1; i++)
            {
                tongcong += Convert.ToInt64(dgv_ChiTietPhieuBanHang.Rows[i].Cells[7].Value);
            }
            txt_TongCong.Text = tongcong.ToString();
            txt_SoTienThanhToan.Text = tongcong.ToString();
        }


        private void txt_SoTienThanhToan_TextChanged(object sender, EventArgs e)
        {
            uint sotienthanhtoan;
            try
            {
                sotienthanhtoan = uint.Parse(txt_SoTienThanhToan.Text);
            }
            catch
            {
                MessageBox.Show("Số tiền thanh toán phải là số nguyên dương và không được để trống!!");
                return;
            }
            if (sotienthanhtoan > uint.Parse(txt_TongCong.Text))
            {
                MessageBox.Show("Số tiền thanh toán không được lớn hơn số tiền Tổng cộng!!");
                ktra_sotienthanhtoan = false;
            }
            else
            {
                uint tiennosaukhithanhtoan = uint.Parse(txt_TongCong.Text) - sotienthanhtoan;
                txt_TienNoSauKhiThanhToan.Text = tiennosaukhithanhtoan.ToString();
                ktra_sotienthanhtoan = true;
            }
            if (ktra_khachhang && ktra_chitietphieubanhang && ktra_sotienthanhtoan)
                btn_LapPhieu.Enabled = true;
            else
                btn_LapPhieu.Enabled = false;
        }

        private void btn_LapPhieu_Click(object sender, EventArgs e)
        {
            bool ktra_lapphieubanhang = false;
            PhieuBanHangDTO pbh = new PhieuBanHangDTO();
            ChiTietPhieuBanHangDTO ctpbh = new ChiTietPhieuBanHangDTO();
            pbh.NgayBan = dateTimePicker_NgayBan.Value;
            pbh.NgayThanhToan = dateTimePicker_NgayThanhToan.Value.Date;
            pbh.TongCong = uint.Parse(txt_TongCong.Text);
            pbh.SoTienNo = uint.Parse(txt_TienNoSauKhiThanhToan.Text);
            try
            {
                pbh.MaKhachHang = uint.Parse(txt_MaKhachHang.Text);
            }
            catch
            {
                MessageBox.Show("Mã khách hàng không hợp lệ, vui lòng kiểm tra lại!!");
                return;
            }
            try
            {
                pbh.SoTienThanhToan = uint.Parse(txt_SoTienThanhToan.Text);
            }
            catch
            {
                MessageBox.Show("Số tiền thanh toán không hợp lệ, vui lòng kiểm tra lại!!");
                return;
            }
            if (PhieuBanHangBUS.ThemPhieuBanHang(pbh) == false)
                MessageBox.Show("Thêm thất bại!!");
            else
            {
                DataTable dt = PhieuBanHangDAO.GetAllPhieuBanHang();
                pbh.MaPhieuBanHang = Convert.ToUInt32(dt.Rows[dt.Rows.Count - 1]["MaPhieuBanHang"]);
                ctpbh.MaPhieuBanHang = pbh.MaPhieuBanHang;
                for (int i = 0; i < dgv_ChiTietPhieuBanHang.Rows.Count - 1; i++)
                {
                    try
                    {
                        ctpbh.MaSanPham = Convert.ToUInt32(dgv_ChiTietPhieuBanHang.Rows[i].Cells[1].Value);
                    }
                    catch
                    {
                        MessageBox.Show("Mã sách trong danh sách không hợp lệ, vui lòng kiểm tra lại!");
                        return;
                    }
                    try
                    {
                        ctpbh.SoLuongBan = Convert.ToUInt32(dgv_ChiTietPhieuBanHang.Rows[i].Cells[5].Value);
                    }
                    catch
                    {
                        MessageBox.Show("Số lượng bán trong danh sách không hợp lệ, vui lòng kiểm tra lại!");
                        return;
                    }
                    try
                    {
                        ctpbh.DonGiaBan = Convert.ToUInt32(dgv_ChiTietPhieuBanHang.Rows[i].Cells[6].Value);
                    }
                    catch
                    {
                        MessageBox.Show("Đơn giá trong danh sách không hợp lệ, vui lòng kiểm tra lại!");
                        return;
                    }
                    ctpbh.ThanhTien = Convert.ToUInt32(dgv_ChiTietPhieuBanHang.Rows[i].Cells[7].Value);
                    if (ChiTietPhieuBanHangBUS.ThemChiTietPhieuBanHang(ctpbh) == false)
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                    else
                    {
                        // Cập nhật số lượng tồn trong bảng SANPHAM 
                        ktra_lapphieubanhang = true;
                        uint soluongtontruockhiban = Convert.ToUInt32(dgv_ChiTietPhieuBanHang.Rows[i].Cells[4].Value);
                        uint soluongban = Convert.ToUInt32(dgv_ChiTietPhieuBanHang.Rows[i].Cells[5].Value);
                        SanPhamDTO sp = new SanPhamDTO();
                        sp.MaSanPham = Convert.ToUInt32(dgv_ChiTietPhieuBanHang.Rows[i].Cells[1].Value);
                        sp.SoLuongTon = soluongtontruockhiban - soluongban;
                        SanPhamDAO.UpdateSoLuongTon(sp);
                    }
                }
            }
            if (ktra_lapphieubanhang)
            {
                txt_MaPhieu.Text = pbh.MaPhieuBanHang.ToString();
                txt_MaKhachHang.ReadOnly = true;
                dgv_ChiTietPhieuBanHang.ReadOnly = true;
                btn_LapPhieu.Enabled = false;
                btn_XoaPhieu.Enabled = true;
                MessageBox.Show("Lập phiếu bán hàng thành công!!");
            }
        }

        private void btn_TaoPhieuMoi_Click(object sender, EventArgs e)
        {
            TaoPhieuBanHangMoi();
        }
        private void TaoPhieuBanHangMoi()
        {
            ktra_khachhang = false;
            ktra_chitietphieubanhang = false;
            ktra_masanpham = false;
            ktra_trungmasanpham = false;
            ktra_soluongban = false;
            ktra_dongiaban = false;
            btn_LapPhieu.Enabled = false;
            btn_XoaPhieu.Enabled = false;
            txt_MaKhachHang.ReadOnly = false;
            txt_MaPhieu.Text = null;
            txt_MaKhachHang.Text = null;
            txt_TenKhachHang.Text = null;
            txt_DiaChi.Text = null;
            txt_TongCong.Text = null;
            int num = dgv_ChiTietPhieuBanHang.Rows.Count;
            for (int i = 0; i < num - 1; i++)
                dgv_ChiTietPhieuBanHang.Rows.RemoveAt(0);
            dgv_ChiTietPhieuBanHang.ReadOnly = false;
            dgv_ChiTietPhieuBanHang.Rows[0].ReadOnly = true;
        }

        private void btn_XoaPhieu_Click(object sender, EventArgs e)
        {
            DataTable dt = PhieuBanHangDAO.GetAllPhieuBanHang();
            PhieuBanHangDTO pbh = new PhieuBanHangDTO();
            pbh.MaPhieuBanHang = Convert.ToUInt32(dt.Rows[dt.Rows.Count - 1]["MaPhieuBanHang"]);
            if (PhieuBanHangBUS.XoaPhieuBanHang(pbh) == false)
                MessageBox.Show("Xóa thất bại!!");
            else
            {
                ChiTietPhieuBanHangDTO ctpbh = new ChiTietPhieuBanHangDTO();
                ctpbh.MaPhieuBanHang = pbh.MaPhieuBanHang;
                if (ChiTietPhieuBanHangBUS.XoaChiTietPhieuBanHang(ctpbh) == false)
                    MessageBox.Show("Xóa thất bại!!");
                else
                {
                    btn_XoaPhieu.Enabled = false;
                    SanPhamDTO sp = new SanPhamDTO();
                    for (int i = 0; i < dgv_ChiTietPhieuBanHang.Rows.Count - 1; i++)
                    {
                        // Cập nhật số lượng tồn trong bảng SANPHAM
                        sp.MaSanPham = Convert.ToUInt32(dgv_ChiTietPhieuBanHang.Rows[i].Cells[1].Value);
                        sp.SoLuongTon = Convert.ToUInt32(dgv_ChiTietPhieuBanHang.Rows[i].Cells[4].Value);
                        SanPhamDAO.UpdateSoLuongTon(sp);
                        btn_XoaPhieu.Enabled = false;
                    }
                    TaoPhieuBanHangMoi();
                    MessageBox.Show("Xóa phiếu bán hàng thành công!!");
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
            frmTraCuuKhachHang.Show();
        }

        private void btn_TraCuuSanPham_Click(object sender, EventArgs e)
        {
            TraCuuSanPham frmTraCuuSanPham = new TraCuuSanPham();
            frmTraCuuSanPham.Show();
        }

        private void btn_LapPhieuNo_Click(object sender, EventArgs e)
        {
            PhieuNo frmPhieuNo = new PhieuNo();
            frmPhieuNo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DanhSachKhachHang f = new DanhSachKhachHang();
            f.Show();
        }
    }
}



