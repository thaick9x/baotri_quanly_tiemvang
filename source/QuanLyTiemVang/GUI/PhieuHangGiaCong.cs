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
    public partial class PhieuHangGiaCong : Form
    {
        private int stt = 0;
        private uint soluong;
        private uint dongia;
        private bool ktra_thogiacong = false;
        private bool ktra_phieuhanggiacong = false;
        private bool ktra_soluong = false;
        private bool ktra_mahanggiacong = false;
        private bool ktra_trungmahanggiacong = false;
        private bool ktra_chitietphieuhanggiacong = false;

        public PhieuHangGiaCong()
        {
            InitializeComponent();
        }

        private void PhieuHangGiaCong_Load(object sender, EventArgs e)
        {
            txt_MaTho.Select();
            dgv_ChiTietPhieuHangGiaCong.Rows[0].ReadOnly = true;
            btn_LapPhieu.Enabled = false;
            btn_XoaPhieu.Enabled = false;
        }

        private void txt_MaTho_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void dgv_ChiTietPhieuHangGiaCong_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            stt = e.RowIndex;
            dgv_ChiTietPhieuHangGiaCong.Rows[stt].Cells[0].Value = (stt + 1).ToString();
            if (dgv_ChiTietPhieuHangGiaCong.Rows[stt].Cells[1].Value == null)
                dgv_ChiTietPhieuHangGiaCong.Rows[stt].Cells[3].ReadOnly = true;
            else
            {
                dgv_ChiTietPhieuHangGiaCong.Rows[stt + 1].ReadOnly = true;
                uint mahanggiacong;
                try
                {
                    mahanggiacong = Convert.ToUInt32(dgv_ChiTietPhieuHangGiaCong.Rows[stt].Cells[1].Value);
                }
                catch
                {
                    MessageBox.Show("Mã hàng gia công phải là số nguyên dương và không được để trống!!");
                    return;
                }
                if (dgv_ChiTietPhieuHangGiaCong.Rows[stt].Cells[3].Value == null)
                    ktra_soluong = false;

                for (int i = 0; i < dgv_ChiTietPhieuHangGiaCong.Rows.Count - 1; i++)
                    if (Convert.ToUInt32(dgv_ChiTietPhieuHangGiaCong.Rows[stt].Cells[1].Value) == Convert.ToUInt32(dgv_ChiTietPhieuHangGiaCong.Rows[i].Cells[1].Value) && i != stt)
                    {
                        ktra_trungmahanggiacong = false;
                        ktra_mahanggiacong = false;
                        MessageBox.Show("Hàng gia công trên đã tồn tại trong danh sách!!");
                        break;
                    }
                    else
                        ktra_trungmahanggiacong = true;

                if (ktra_trungmahanggiacong)
                {
                    HangGiaCongDTO hgc = new HangGiaCongDTO();
                    hgc.MaHangGiaCong = mahanggiacong;
                    DataTable dt = HangGiaCongDAO.SelectHangGiaCongByMaHangGiaCong(hgc);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        dgv_ChiTietPhieuHangGiaCong.Rows[stt].Cells[2].Value = Convert.ToString(dt.Rows[0]["TenHangGiaCong"]);
                        dgv_ChiTietPhieuHangGiaCong.Rows[stt].Cells[4].Value = Convert.ToString(dt.Rows[0]["DonGiaGiaCong"]);
                        dongia = Convert.ToUInt32(dgv_ChiTietPhieuHangGiaCong.Rows[stt].Cells[4].Value);
                        dgv_ChiTietPhieuHangGiaCong.Rows[stt].Cells[3].ReadOnly = false;
                        ktra_mahanggiacong = true;
                    }
                    else
                    {
                        MessageBox.Show("Mã hàng gia công trên không có trong danh sách hàng gia công!!");
                        ktra_mahanggiacong = false;
                    }
                }

                if (dgv_ChiTietPhieuHangGiaCong.Rows[stt].Cells[3].Value != null)
                {
                    try
                    {
                        soluong = Convert.ToUInt32(dgv_ChiTietPhieuHangGiaCong.Rows[stt].Cells[3].Value);
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

                if (ktra_mahanggiacong && ktra_soluong)
                {
                    ktra_chitietphieuhanggiacong = true;
                    long thanhtien = soluong * dongia;
                    dgv_ChiTietPhieuHangGiaCong.Rows[stt].Cells[5].Value = Convert.ToString(thanhtien);
                    dgv_ChiTietPhieuHangGiaCong.Rows[stt + 1].ReadOnly = false;
                    dgv_ChiTietPhieuHangGiaCong.Rows[dgv_ChiTietPhieuHangGiaCong.Rows.Count - 1].Cells[3].ReadOnly = true;
                }
                else
                    ktra_chitietphieuhanggiacong = false;
                if (ktra_chitietphieuhanggiacong && ktra_thogiacong)
                    btn_LapPhieu.Enabled = true;
                else
                    btn_LapPhieu.Enabled = false;
            }

            long tongcong = 0;
            for (int i = 0; i < dgv_ChiTietPhieuHangGiaCong.Rows.Count - 1; i++)
            {
                tongcong += Convert.ToInt64(dgv_ChiTietPhieuHangGiaCong.Rows[i].Cells[5].Value);
            }
            txt_TongCong.Text = tongcong.ToString();
        }

        private void btn_LapPhieu_Click(object sender, EventArgs e)
        {
            bool ktra_lapphieuhanggiacong = false;
            PhieuHangGiaCongDTO phgc = new PhieuHangGiaCongDTO();
            ChiTietPhieuHangGiaCongDTO ctphgc = new ChiTietPhieuHangGiaCongDTO();
            phgc.NgayGiaCong = dateTimePicker_NgayGiaCong.Value;
            phgc.NgayNhanHangGiaCong = dateTimePicker_NgayNhanHangGiaCong.Value;
            phgc.NgayThanhToan = dateTimePicker_NgayThanhToan.Value;
            phgc.TongCong = uint.Parse(txt_TongCong.Text);
            try
            {
                phgc.MaTho = uint.Parse(txt_MaTho.Text);
            }
            catch
            {
                MessageBox.Show("Mã thợ không hợp lệ, vui lòng kiểm tra lại!!");
                return;
            }
            if (PhieuHangGiaCongBUS.ThemPhieuHangGiaCong(phgc) == false)
                MessageBox.Show("Thêm thất bại!!");
            else
            {
                DataTable dt = PhieuHangGiaCongDAO.GetAllPhieuHangGiaCong();
                phgc.MaPhieuHangGiaCong = Convert.ToUInt32(dt.Rows[dt.Rows.Count - 1]["MaPhieuHangGiaCong"]);
                ctphgc.MaPhieuHangGiaCong = phgc.MaPhieuHangGiaCong;
                for (int i = 0; i < dgv_ChiTietPhieuHangGiaCong.Rows.Count - 1; i++)
                {
                    try
                    {
                        ctphgc.MaHangGiaCong = Convert.ToUInt32(dgv_ChiTietPhieuHangGiaCong.Rows[i].Cells[1].Value);
                    }
                    catch
                    {
                        MessageBox.Show("Mã hàng gia công trong danh sách không hợp lệ, vui lòng kiểm tra lại!!");
                        return;
                    }
                    try
                    {
                        ctphgc.SoLuong = Convert.ToUInt32(dgv_ChiTietPhieuHangGiaCong.Rows[i].Cells[3].Value);
                    }
                    catch
                    {
                        MessageBox.Show("Số lượng trong danh sách không hợp lệ, vui lòng kiểm tra lại!!");
                        return;
                    }
                    ctphgc.ThanhTien = Convert.ToUInt32(dgv_ChiTietPhieuHangGiaCong.Rows[i].Cells[5].Value);
                    if (ChiTietPhieuHangGiaCongBUS.ThemChiTietPhieuHangGiaCong(ctphgc) == false)
                        MessageBox.Show("Thêm thất bại!!");
                    else
                        ktra_lapphieuhanggiacong = true;
                }
                if (ktra_lapphieuhanggiacong)
                {
                    txt_MaPhieu.Text = phgc.MaPhieuHangGiaCong.ToString();
                    txt_MaTho.ReadOnly = true;
                    dgv_ChiTietPhieuHangGiaCong.ReadOnly = true;
                    btn_LapPhieu.Enabled = false;
                    btn_XoaPhieu.Enabled = true;
                    MessageBox.Show("Lập phiếu hàng gia công thành công!!");
                }
            }
        }

        private void btn_XoaPhieu_Click(object sender, EventArgs e)
        {
            DataTable dt = PhieuHangGiaCongDAO.GetAllPhieuHangGiaCong();
            PhieuHangGiaCongDTO phgc = new PhieuHangGiaCongDTO();
            phgc.MaPhieuHangGiaCong = Convert.ToUInt32(dt.Rows[dt.Rows.Count - 1]["MaPhieuHangGiaCong"]);
            if (PhieuHangGiaCongBUS.XoaPhieuHangGiaCong(phgc) == false)
                MessageBox.Show("Xóa thất bại!!");
            else
            {
                ChiTietPhieuHangGiaCongDTO ctphgc = new ChiTietPhieuHangGiaCongDTO();
                ctphgc.MaPhieuHangGiaCong = phgc.MaPhieuHangGiaCong;
                if (ChiTietPhieuHangGiaCongBUS.XoaChiTietPhieuHangGiaCong(ctphgc) == false)
                    MessageBox.Show("Xóa thất bại!!");
                else
                {
                    btn_XoaPhieu.Enabled = false;
                    TaoPhieuHangGiaCongMoi();
                    MessageBox.Show("Xóa phiếu hàng gia công thành công!!");
                }
            }
        }

        private void btn_TaoPhieuMoi_Click(object sender, EventArgs e)
        {
            TaoPhieuHangGiaCongMoi();
        }

        private void TaoPhieuHangGiaCongMoi()
        {
            ktra_thogiacong = false;
            ktra_chitietphieuhanggiacong = false;
            ktra_mahanggiacong = false;
            ktra_trungmahanggiacong = false;
            ktra_soluong = false;
            btn_LapPhieu.Enabled = false;
            btn_XoaPhieu.Enabled = false;
            txt_MaTho.ReadOnly = false;
            txt_MaPhieu.Text = null;
            txt_MaTho.Text = null;
            txt_TenTho.Text = null;
            txt_DiaChi.Text = null;
            txt_TongCong.Text = null;
            int num = dgv_ChiTietPhieuHangGiaCong.Rows.Count;
            for (int i = 0; i < num - 1; i++)
                dgv_ChiTietPhieuHangGiaCong.Rows.RemoveAt(0);
            dgv_ChiTietPhieuHangGiaCong.ReadOnly = false;
            dgv_ChiTietPhieuHangGiaCong.Rows[0].ReadOnly = true;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có thực sự muốn thoát khỏi nghiệp vụ này không?",
              "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
                this.Close();
        }

        private void txt_MaTho_TextChanged(object sender, EventArgs e)
        {
            if (txt_MaTho.Text == "")
            {
                txt_TenTho.Text = "";
                txt_DiaChi.Text = "";
            }
            uint matho;
            try
            {
                matho = uint.Parse(txt_MaTho.Text);
            }
            catch
            {
                MessageBox.Show("Mã thợ phải là số nguyên dương và không được để trống!!");
                return;
            }
            DataTable dt = ThoGiaCongDAO.SelectThoGiaCongByMaThoGiaCong(matho);
            if (dt != null && dt.Rows.Count > 0)
            {
                ktra_thogiacong = true;
                txt_TenTho.Text = Convert.ToString(dt.Rows[0]["TenTho"]);
                txt_DiaChi.Text = Convert.ToString(dt.Rows[0]["DiaChi"]);
                dgv_ChiTietPhieuHangGiaCong.Rows[0].Cells[1].ReadOnly = false;
            }
            else
            {
                MessageBox.Show("Mã thợ này không có trong danh sách thợ gia công!!");
                ktra_thogiacong = false;
            }
            if (ktra_thogiacong && ktra_phieuhanggiacong)
                btn_LapPhieu.Enabled = true;
            else
                btn_LapPhieu.Enabled = false;
        }
    }
}
