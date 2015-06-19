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
    public partial class PhieuDichVu : Form
    {
        private int stt = 0;
        private uint soluong;
        private uint dongia;
        private bool ktra_khachhang = false;
        private bool ktra_phieudichvu = false;
        private bool ktra_soluong = false;
        private bool ktra_madichvu = false;
        private bool ktra_trungmadichvu = false;
        private bool ktra_chitietphieudichvu = false;

        public PhieuDichVu()
        {
            InitializeComponent();
        }

        private void PhieuDichVu_Load(object sender, EventArgs e)
        {
            txt_MaKhachHang.Select();
            dgv_ChiTietPhieuDichVu.Rows[0].ReadOnly = true;
            btn_LapPhieu.Enabled = false;
            btn_XoaPhieu.Enabled = false;
        }

        private void txt_MaKhachHang_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void dgv_ChiTietPhieuDichVu_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            stt = e.RowIndex;
            dgv_ChiTietPhieuDichVu.Rows[stt].Cells[0].Value = (stt + 1).ToString();
            if (dgv_ChiTietPhieuDichVu.Rows[stt].Cells[1].Value == null)
                dgv_ChiTietPhieuDichVu.Rows[stt].Cells[3].ReadOnly = true;
            else
            {
                dgv_ChiTietPhieuDichVu.Rows[stt + 1].ReadOnly = true;
                uint madichvu;
                try
                {
                    madichvu = Convert.ToUInt32(dgv_ChiTietPhieuDichVu.Rows[stt].Cells[1].Value);
                }
                catch
                {
                    MessageBox.Show("Mã dịch vụ phải là số nguyên dương và không được để trống!!");
                    return;
                }
                if (dgv_ChiTietPhieuDichVu.Rows[stt].Cells[3].Value == null)
                    ktra_soluong = false;

                for (int i = 0; i < dgv_ChiTietPhieuDichVu.Rows.Count - 1; i++)
                    if (Convert.ToUInt32(dgv_ChiTietPhieuDichVu.Rows[stt].Cells[1].Value) == Convert.ToUInt32(dgv_ChiTietPhieuDichVu.Rows[i].Cells[1].Value) && i != stt)
                    {
                        ktra_trungmadichvu = false;
                        ktra_madichvu = false;
                        MessageBox.Show("Dịch vụ trên đã tồn tại trong danh sách!!");
                        break;
                    }
                    else
                        ktra_trungmadichvu = true;

                if (ktra_trungmadichvu)
                {
                    DichVuDTO dv = new DichVuDTO();
                    dv.MaDichVu = madichvu;
                    DataTable dt = DichVuDAO.SelectDichVuByMaDichVu(dv);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        dgv_ChiTietPhieuDichVu.Rows[stt].Cells[2].Value = Convert.ToString(dt.Rows[0]["TenDichVu"]);
                        dgv_ChiTietPhieuDichVu.Rows[stt].Cells[4].Value = Convert.ToString(dt.Rows[0]["DonGiaDichVu"]);
                        dongia = Convert.ToUInt32(dgv_ChiTietPhieuDichVu.Rows[stt].Cells[4].Value);
                        dgv_ChiTietPhieuDichVu.Rows[stt].Cells[3].ReadOnly = false;
                        ktra_madichvu = true;
                    }
                    else
                    {
                        MessageBox.Show("Mã dịch vụ trên không có trong danh sách dịch vụ!!");
                        ktra_madichvu = false;
                    }
                }

                if (dgv_ChiTietPhieuDichVu.Rows[stt].Cells[3].Value != null)
                {
                    try
                    {
                        soluong = Convert.ToUInt32(dgv_ChiTietPhieuDichVu.Rows[stt].Cells[3].Value);
                    }
                    catch
                    {
                        MessageBox.Show("Số lượng phải là số nguyên dương và không được để trống!!");
                        return;
                    }
                    if (soluong == 0)
                    {
                        MessageBox.Show("Số lượng phải là số nguyên dương và không được để trống!!");
                        ktra_soluong = false;
                    }
                    else
                        ktra_soluong = true;
                }

                if (ktra_madichvu && ktra_soluong)
                {
                    ktra_chitietphieudichvu = true;
                    long thanhtien = soluong * dongia;
                    dgv_ChiTietPhieuDichVu.Rows[stt].Cells[5].Value = Convert.ToString(thanhtien);
                    dgv_ChiTietPhieuDichVu.Rows[stt + 1].ReadOnly = false;
                    dgv_ChiTietPhieuDichVu.Rows[dgv_ChiTietPhieuDichVu.Rows.Count - 1].Cells[3].ReadOnly = true;
                }
                else
                    ktra_chitietphieudichvu = false;
                if (ktra_chitietphieudichvu && ktra_khachhang)
                    btn_LapPhieu.Enabled = true;
                else
                    btn_LapPhieu.Enabled = false;
            }

            long tongtrigia = 0;
            for (int i = 0; i < dgv_ChiTietPhieuDichVu.Rows.Count - 1; i++)
            {
                tongtrigia += Convert.ToInt64(dgv_ChiTietPhieuDichVu.Rows[i].Cells[5].Value);
            }
            txt_TongCong.Text = tongtrigia.ToString();
        }

        private void btn_LapPhieu_Click(object sender, EventArgs e)
        {
            bool ktra_lapphieudichvu = false;
            PhieuDichVuDTO pdv = new PhieuDichVuDTO();
            ChiTietPhieuDichVuDTO ctpdv = new ChiTietPhieuDichVuDTO();
            pdv.NgayDangKy = dateTimePicker_NgayDangKy.Value;
            pdv.NgayGiao = dateTimePicker_NgayGiao.Value;
            pdv.TongCong = uint.Parse(txt_TongCong.Text);
            try
            {
                pdv.MaKhachHang = uint.Parse(txt_MaKhachHang.Text);
            }
            catch
            {
                MessageBox.Show("Mã khách hàng không hợp lệ, vui lòng kiểm tra lại!!");
                return;
            }
            if (PhieuDichVuBUS.ThemPhieuDichVu(pdv) == false)
                MessageBox.Show("Thêm thất bại!!");
            else
            {
                DataTable dt = PhieuDichVuDAO.GetAllPhieuDichVu();
                pdv.MaPhieuDichVu = Convert.ToUInt32(dt.Rows[dt.Rows.Count - 1]["MaPhieuDichVu"]);
                ctpdv.MaPhieuDichVu = pdv.MaPhieuDichVu;
                for (int i = 0; i < dgv_ChiTietPhieuDichVu.Rows.Count - 1; i++)
                {
                    try
                    {
                        ctpdv.MaDichVu = Convert.ToUInt32(dgv_ChiTietPhieuDichVu.Rows[i].Cells[1].Value);
                    }
                    catch
                    {
                        MessageBox.Show("Mã dịch vụ trong danh sách không hợp lệ, vui lòng kiểm tra lại!!");
                        return;
                    }
                    try
                    {
                        ctpdv.SoLuong = Convert.ToUInt32(dgv_ChiTietPhieuDichVu.Rows[i].Cells[3].Value);
                    }
                    catch
                    {
                        MessageBox.Show("Số lượng trong danh sách không hợp lệ, vui lòng kiểm tra lại!!");
                        return;
                    }
                    ctpdv.ThanhTien = Convert.ToUInt32(dgv_ChiTietPhieuDichVu.Rows[i].Cells[5].Value);
                    if (ChiTietPhieuDichVuBUS.ThemChiTietPhieuDichVu(ctpdv) == false)
                        MessageBox.Show("Thêm thất bại!!");
                    else
                        ktra_lapphieudichvu = true;
                }
                if (ktra_lapphieudichvu)
                {
                    txt_MaPhieu.Text = pdv.MaPhieuDichVu.ToString();
                    txt_MaKhachHang.ReadOnly = true;
                    dgv_ChiTietPhieuDichVu.ReadOnly = true;
                    btn_LapPhieu.Enabled = false;
                    btn_XoaPhieu.Enabled = true;
                    MessageBox.Show("Lập phiếu dịch vụ thành công!!");
                }
            }
        }

        private void btn_XoaPhieu_Click(object sender, EventArgs e)
        {
            DataTable dt = PhieuDichVuDAO.GetAllPhieuDichVu();
            PhieuDichVuDTO pdv = new PhieuDichVuDTO();
            pdv.MaPhieuDichVu = Convert.ToUInt32(dt.Rows[dt.Rows.Count - 1]["MaPhieuDichVu"]);
            if (PhieuDichVuBUS.XoaPhieuDichVu(pdv) == false)
                MessageBox.Show("Xóa thất bại!!");
            else
            {
                ChiTietPhieuDichVuDTO ctpdv = new ChiTietPhieuDichVuDTO();
                ctpdv.MaPhieuDichVu = pdv.MaPhieuDichVu;
                if (ChiTietPhieuDichVuBUS.XoaChiTietPhieuDichVu(ctpdv) == false)
                    MessageBox.Show("Xóa thất bại!!");
                else
                {
                    btn_XoaPhieu.Enabled = false;
                    TaoPhieuDichVuMoi();
                    MessageBox.Show("Xóa phiếu dịch vụ thành công!!");
                }
            }
        }

        private void TaoPhieuDichVuMoi()
        {
            ktra_khachhang = false;
            ktra_chitietphieudichvu = false;
            ktra_madichvu = false;
            ktra_trungmadichvu = false;
            ktra_soluong = false;
            btn_LapPhieu.Enabled = false;
            btn_XoaPhieu.Enabled = false;
            txt_MaKhachHang.ReadOnly = false;
            txt_MaPhieu.Text = null;
            txt_MaKhachHang.Text = null;
            txt_TenKhachHang.Text = null;
            txt_DiaChi.Text = null;
            txt_TongCong.Text = null;
            int num = dgv_ChiTietPhieuDichVu.Rows.Count;
            for (int i = 0; i < num - 1; i++)
                dgv_ChiTietPhieuDichVu.Rows.RemoveAt(0);
            dgv_ChiTietPhieuDichVu.ReadOnly = false;
            dgv_ChiTietPhieuDichVu.Rows[0].ReadOnly = true;
        }

        private void btn_TaoPhieuMoi_Click(object sender, EventArgs e)
        {
            TaoPhieuDichVuMoi();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có thực sự muốn thoát khỏi nghiệp vụ này không?",
             "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
                this.Close();
        }

        private void btnTraCuuKhachHang_Click(object sender, EventArgs e)
        {
            TraCuuKhachHang frmTraCuuKhachHang = new TraCuuKhachHang();
            frmTraCuuKhachHang.Show();
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
                dgv_ChiTietPhieuDichVu.Rows[0].Cells[1].ReadOnly = false;
            }
            else
            {
                MessageBox.Show("Mã khách hàng này không có trong danh sách khách hàng!!");
                ktra_khachhang = false;
            }
            if (ktra_khachhang && ktra_phieudichvu)
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
