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
    public partial class PhieuChi : Form
    {
        private int stt = 0;
        private uint thanhtien;
        private bool ktra_makhoanphi = false;
        private bool ktra_trungmakhoanphi = false;
        private bool ktra_thanhtien = false;

        public PhieuChi()
        {
            InitializeComponent();
        }

        private void PhieuChi_Load(object sender, EventArgs e)
        {
            dgv_ChiTietPhieuChi.Rows[0].Cells[3].ReadOnly = true;
            btn_LapPhieu.Enabled = false;
            btn_XoaPhieu.Enabled = false;
        }

        private void dgv_ChiTietPhieuChi_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            stt = e.RowIndex;
            dgv_ChiTietPhieuChi.Rows[stt].Cells[0].Value = (stt + 1).ToString();
            if (dgv_ChiTietPhieuChi.Rows[stt].Cells[1].Value == null)
                dgv_ChiTietPhieuChi.Rows[stt].Cells[3].ReadOnly = true;
            else
            {
                dgv_ChiTietPhieuChi.Rows[stt + 1].ReadOnly = true;
                KhoanPhiDTO kp = new KhoanPhiDTO();
                try
                {
                    kp.MaKhoanPhi = Convert.ToUInt32(dgv_ChiTietPhieuChi.Rows[stt].Cells[1].Value);
                }
                catch
                {
                    MessageBox.Show("Mã khoản phí phải là số nguyên dương và không được để trống!!");
                    return;
                }
                if (dgv_ChiTietPhieuChi.Rows[stt].Cells[3].Value == null)
                    ktra_thanhtien = false;
                for (int i = 0; i < dgv_ChiTietPhieuChi.Rows.Count - 1; i++)
                    if (Convert.ToUInt32(dgv_ChiTietPhieuChi.Rows[stt].Cells[1].Value) == Convert.ToUInt32(dgv_ChiTietPhieuChi.Rows[i].Cells[1].Value) && i != stt)
                    {
                        ktra_trungmakhoanphi = false;
                        ktra_makhoanphi = false;
                        MessageBox.Show("Khoản phí trên đã tồn tại trong danh sách!!");
                        break;
                    }
                    else
                        ktra_trungmakhoanphi = true;
                if (ktra_trungmakhoanphi)
                {
                    DataTable dt = KhoanPhiDAO.SelectKhoanPhiByMaKhoanPhi(kp);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        dgv_ChiTietPhieuChi.Rows[stt].Cells[2].Value = Convert.ToString(dt.Rows[0]["TenKhoanPhi"]);
                        dgv_ChiTietPhieuChi.Rows[stt].Cells[3].ReadOnly = false;
                        ktra_makhoanphi = true;
                    }
                    else
                    {
                        MessageBox.Show("Mã khoản phí không có trong danh sách khoản phí!!");
                        ktra_makhoanphi = false;
                    }
                }
                if (dgv_ChiTietPhieuChi.Rows[stt].Cells[3].Value != null)
                {
                    try
                    {
                        thanhtien = Convert.ToUInt32(dgv_ChiTietPhieuChi.Rows[stt].Cells[3].Value);
                    }
                    catch
                    {
                        MessageBox.Show("Thành tiền phải là số nguyên dương và không được để trống!!");
                        return;
                    }
                    ktra_thanhtien = true;
                }
                if (ktra_makhoanphi && ktra_thanhtien)
                {
                    dgv_ChiTietPhieuChi.Rows[stt + 1].ReadOnly = false;
                    dgv_ChiTietPhieuChi.Rows[dgv_ChiTietPhieuChi.Rows.Count - 1].Cells[3].ReadOnly = true;
                    btn_LapPhieu.Enabled = true;
                }
                else
                    btn_LapPhieu.Enabled = false;
                long tongcong = 0;
                for (int i = 0; i < dgv_ChiTietPhieuChi.Rows.Count - 1; i++)
                {
                    tongcong += Convert.ToInt64(dgv_ChiTietPhieuChi.Rows[i].Cells[3].Value);
                }
                txt_TongCong.Text = tongcong.ToString();
            }
        }

        private void btn_LapPhieu_Click(object sender, EventArgs e)
        {
            bool ktra_lapphieuchi = false;
            PhieuChiDTO pc = new PhieuChiDTO();
            ChiTietPhieuChiDTO ctpc = new ChiTietPhieuChiDTO();
            pc.NgayChi = dateTimePicker_NgayChi.Value;
            pc.TongCong = uint.Parse(txt_TongCong.Text);
            if (PhieuChiBUS.ThemPhieuChi(pc) == false)
                MessageBox.Show("Thêm thất bại!!");
            else
            {
                DataTable dt = PhieuChiDAO.GetAllPhieuChi();
                pc.MaPhieuChi = Convert.ToUInt32(dt.Rows[dt.Rows.Count - 1]["MaPhieuChi"]);
                ctpc.MaPhieuChi = pc.MaPhieuChi; ;
                for (int i = 0; i < dgv_ChiTietPhieuChi.Rows.Count - 1; i++)
                {
                    try
                    {
                        ctpc.MaKhoanPhi = Convert.ToUInt32(dgv_ChiTietPhieuChi.Rows[i].Cells[1].Value);
                    }
                    catch
                    {
                        MessageBox.Show("Mã khoản phí trong danh sách không hợp lệ, vui lòng kiểm tra lại!!");
                        return;
                    }
                    try
                    {
                        ctpc.ThanhTien = Convert.ToUInt32(dgv_ChiTietPhieuChi.Rows[i].Cells[3].Value);
                    }
                    catch
                    {
                        MessageBox.Show("Thành tiền trong danh sách không hợp lệ, vui lòng kiểm tra lại!!");
                        return;
                    }
                    if (ChiTietPhieuChiBUS.ThemChiTietPhieuChi(ctpc) == false)
                        MessageBox.Show("Thêm thất bại!!");
                    else
                        ktra_lapphieuchi = true;
                }
                if (ktra_lapphieuchi)
                {
                    txt_MaPhieu.Text = pc.MaPhieuChi.ToString();
                    dgv_ChiTietPhieuChi.ReadOnly = true;
                    btn_LapPhieu.Enabled = false;
                    btn_XoaPhieu.Enabled = true;
                    MessageBox.Show("Lập phiếu chi thành công!!");
                }
            }
        }

        private void btn_XoaPhieu_Click(object sender, EventArgs e)
        {
            DataTable dt = PhieuChiDAO.GetAllPhieuChi();
            PhieuChiDTO pc = new PhieuChiDTO();
            pc.MaPhieuChi = Convert.ToUInt32(dt.Rows[dt.Rows.Count - 1]["MaPhieuChi"]);
            if (PhieuChiBUS.XoaPhieuChi(pc) == false)
                MessageBox.Show("Xóa thất bại!!");
            else
            {
                ChiTietPhieuChiDTO ctpc = new ChiTietPhieuChiDTO();
                ctpc.MaPhieuChi = pc.MaPhieuChi;
                if (ChiTietPhieuChiBUS.XoaChiTietPhieuChi(ctpc) == false)
                    MessageBox.Show("Xóa thất bại!!");
                else
                {
                    btn_XoaPhieu.Enabled = false;
                    TaoPhieuChiMoi();
                    MessageBox.Show("Xóa phiếu chi thành công!!");
                }
            }
        }

        private void btn_TaoPhieuMoi_Click(object sender, EventArgs e)
        {
            TaoPhieuChiMoi();
        }

        private void TaoPhieuChiMoi()
        {
            ktra_makhoanphi = false;
            ktra_trungmakhoanphi = false;
            ktra_thanhtien = false;
            btn_LapPhieu.Enabled = false;
            btn_XoaPhieu.Enabled = false;
            txt_MaPhieu.Text = null;
            txt_TongCong.Text = null;
            int num = dgv_ChiTietPhieuChi.Rows.Count;
            for (int i = 0; i < num - 1; i++)
                dgv_ChiTietPhieuChi.Rows.RemoveAt(0);
            dgv_ChiTietPhieuChi.ReadOnly = false;
            dgv_ChiTietPhieuChi.Rows[0].Cells[1].ReadOnly = false;
            dgv_ChiTietPhieuChi.Rows[0].Cells[3].ReadOnly = true;
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
