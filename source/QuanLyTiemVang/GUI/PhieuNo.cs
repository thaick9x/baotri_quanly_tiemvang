using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyTiemVang.BUS;
using QuanLyTiemVang.DAO;
using QuanLyTiemVang.DTO;

namespace QuanLyTiemVang.GUI
{
    public partial class PhieuNo : Form
    {
        private bool ktra_maphieubanhang = false;
        private bool ktra_sotientra = false;
        private uint sotienno;
        private uint sotientra;
        public PhieuNo()
        {
            InitializeComponent();
        }

        private void PhieuNo_Load(object sender, EventArgs e)
        {
            txt_MaPhieuBanHang.Select();
            txt_SoTienTra.ReadOnly = true;
            btn_LapPhieu.Enabled = false;
            btn_XoaPhieu.Enabled = false;
        }

        private void txt_MaPhieuBanHang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                PhieuBanHangDTO pbh = new PhieuBanHangDTO();
                try
                {
                    pbh.MaPhieuBanHang = uint.Parse(txt_MaPhieuBanHang.Text);
                }
                catch
                {
                    MessageBox.Show("Mã phiếu bán hàng phải là số nguyên dương và không được để trống!!");
                    return;
                }
                DataTable dt1 = PhieuBanHangDAO.SelectPhieuBanHangByMaPhieuBanHang(pbh);
                if (dt1 != null && dt1.Rows.Count > 0)
                {
                    txt_MaKhachHang.Text = Convert.ToString(dt1.Rows[0]["MaKhachHang"]);
                    txt_SoTienNo.Text = Convert.ToString(dt1.Rows[0]["SoTienNo"]);
                    uint makh = uint.Parse(txt_MaKhachHang.Text);
                    DataTable dt2 = KhachHangDAO.SelectKhachHangByMaKhachHang(makh);
                    txt_TenKhachHang.Text = Convert.ToString(dt2.Rows[0]["TenKhachHang"]);
                    txt_LoaiKhachHang.Text = Convert.ToString(dt2.Rows[0]["LoaiKhachHang"]);
                    if (txt_LoaiKhachHang.Text == "Khách quen")
                    {
                        txt_SoTienTra.ReadOnly = false;
                        ktra_maphieubanhang = true;
                        sotienno = uint.Parse(txt_SoTienNo.Text);
                        if (txt_SoTienTra.Text == "")
                            sotientra = 0;
                        txt_SoTienConLai.Text = (sotienno - sotientra).ToString();
                    }
                    else
                    {
                        ktra_maphieubanhang = false;
                        MessageBox.Show("Chỉ được lập phiếu nợ đối với khách quen!!");
                    }
                }
                else
                {
                    MessageBox.Show("Mã phiếu bán hàng không có trong danh sách, xin vui lòng nhập lại!!");
                    ktra_maphieubanhang = false;
                }
                if (ktra_maphieubanhang)
                    btn_LapPhieu.Enabled = true;
                else
                    btn_LapPhieu.Enabled = false;
            }
        }

        private void txt_SoTienTra_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                try
                {
                    sotientra = uint.Parse(txt_SoTienTra.Text);
                }
                catch
                {
                    MessageBox.Show("Số tiền trả phải là số nguyên dương và không được để trống!!");
                    return;
                }
                sotienno = uint.Parse(txt_SoTienNo.Text);
                if (sotientra > sotienno)
                {
                    MessageBox.Show("Số tiền trả không được lớn hơn số tiền nợ!!");
                    ktra_sotientra = false;
                }
                else
                {
                    txt_SoTienConLai.Text = (sotienno - sotientra).ToString();
                    ktra_sotientra = true;
                }
                if (ktra_maphieubanhang && ktra_sotientra)
                    btn_LapPhieu.Enabled = true;
                else
                    btn_LapPhieu.Enabled = false;
            }
        }

        private void btn_LapPhieu_Click(object sender, EventArgs e)
        {
            if (txt_SoTienTra.Text != "")
                txt_SoTienConLai.Text = (uint.Parse(txt_SoTienNo.Text) - uint.Parse(txt_SoTienTra.Text)).ToString();
            PhieuNoDTO pn = new PhieuNoDTO();
            pn.MaPhieuBanHang = uint.Parse(txt_MaPhieuBanHang.Text);
            pn.NgayNo = dateTimePicker_NgayNo.Value;
            pn.NgayTra = dateTimePicker_NgayTra.Value;
            pn.TienConLai = uint.Parse(txt_SoTienConLai.Text);
            if (txt_SoTienTra.Text == "")
                pn.SoTienTra = 0;
            else
                pn.SoTienTra = uint.Parse(txt_SoTienTra.Text);
            if (PhieuNoBUS.ThemPhieuNo(pn))
            {
                DataTable dt = PhieuNoDAO.GetAllPhieuNo();
                pn.MaPhieuNo = Convert.ToUInt32(dt.Rows[dt.Rows.Count - 1]["MaPhieuNo"]);
                txt_MaPhieuNo.Text = pn.MaPhieuNo.ToString();
                btn_LapPhieu.Enabled = false;
                btn_XoaPhieu.Enabled = true;
                
                //Cập nhật Số tiền nợ
                PhieuBanHangDTO pbh = new PhieuBanHangDTO();
                pbh.MaPhieuBanHang = pn.MaPhieuBanHang;
                pbh.SoTienNo = pn.TienConLai;
                PhieuBanHangDAO.UpdateTienNo(pbh);
                if (txt_SoTienTra.Text != "")
                {
                    KhachHangDTO kh = new KhachHangDTO();
                    uint makh = uint.Parse(txt_MaKhachHang.Text);
                    DataTable dt2 = KhachHangDAO.SelectKhachHangByMaKhachHang(makh);
                    kh.TienNoHienTai = Convert.ToUInt32(dt2.Rows[0]["TienNoHienTai"]) - uint.Parse(txt_SoTienTra.Text);
                    kh.MaKhachHang = makh;
                    KhachHangDAO.UpdateTienNo(kh);
                }
                MessageBox.Show("Lập phiếu nợ thành công!!");
            }
            else
                MessageBox.Show("Thêm thất bại!!");
        }

        private void btn_XoaPhieu_Click(object sender, EventArgs e)
        {
            PhieuNoDTO pn = new PhieuNoDTO();
            pn.MaPhieuNo = uint.Parse(txt_MaPhieuNo.Text);
            pn.MaPhieuBanHang = uint.Parse(txt_MaPhieuBanHang.Text);
            if (PhieuNoBUS.XoaPhieuNo(pn))
            {
                btn_XoaPhieu.Enabled = false;

                //Cập nhật Số tiền nợ
                PhieuBanHangDTO pbh = new PhieuBanHangDTO();
                pbh.MaPhieuBanHang = pn.MaPhieuBanHang;
                pbh.SoTienNo = uint.Parse(txt_SoTienNo.Text);
                PhieuBanHangDAO.UpdateTienNo(pbh);
                if (txt_SoTienTra.Text != "")
                {
                    KhachHangDTO kh = new KhachHangDTO();
                    uint makh = uint.Parse(txt_MaKhachHang.Text);
                    DataTable dt2 = KhachHangDAO.SelectKhachHangByMaKhachHang(makh);
                    kh.TienNoHienTai = Convert.ToUInt32(dt2.Rows[0]["TienNoHienTai"]) + uint.Parse(txt_SoTienTra.Text);
                    kh.MaKhachHang = makh;
                    KhachHangDAO.UpdateTienNo(kh);
                }
                TaoPhieuNoMoi();
                MessageBox.Show("Xóa phiếu nợ thành công!!");
            }
            else
                MessageBox.Show("Xóa thất bại!!");
        }

        private void btn_TaoPhieuMoi_Click(object sender, EventArgs e)
        {
            TaoPhieuNoMoi();
        }

        private void TaoPhieuNoMoi()
        {
            txt_MaPhieuNo.Text = null;
            txt_MaPhieuBanHang.Text = null;
            txt_MaKhachHang.Text = null;
            txt_TenKhachHang.Text = null;
            txt_SoTienNo.Text = null;
            txt_SoTienTra.Text = null;
            txt_SoTienConLai.Text = null;
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
    }
}
