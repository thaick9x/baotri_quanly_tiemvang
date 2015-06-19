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
    public partial class DanhSachDichVu : Form
    {
        private uint madichvu;

        public DanhSachDichVu()
        {
            InitializeComponent();
        }

        private void DanhSachDichVu_Load(object sender, EventArgs e)
        {
            txt_TenDichVu.Select();
            DataTable dt = DichVuDAO.GetAllDichVu();
            dgv_DanhSachDichVu.DataSource = dt;
        }

        private void dgv_DanhSachDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = e.RowIndex;
            int Row = dgv_DanhSachDichVu.Rows.Count;
            if (Index >= 0 && Index < Row - 1)
            {
                madichvu = Convert.ToUInt32(dgv_DanhSachDichVu.Rows[Index].Cells[0].Value);
                txt_MaDichVu.Text = Convert.ToString(madichvu);
                txt_TenDichVu.Text = Convert.ToString(dgv_DanhSachDichVu.Rows[Index].Cells[1].Value);
                txt_DonGiaDichVu.Text = Convert.ToString(dgv_DanhSachDichVu.Rows[Index].Cells[2].Value);
            }

            if (Index >= Row - 1)
            {
                txt_MaDichVu.Text = "";
                txt_TenDichVu.Text = "";
                txt_DonGiaDichVu.Text = "";
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DichVuDTO dv = new DichVuDTO();
            if (txt_TenDichVu.Text == "")
                MessageBox.Show("Chưa nhập Tên dịch vụ");
            else if (txt_DonGiaDichVu.Text == "")
                MessageBox.Show("Chưa nhập đơn giá dịch vụ");
            else
            {
                dv.TenDichVu = txt_TenDichVu.Text;
                dv.DonGiaDichVu = uint.Parse(txt_DonGiaDichVu.Text);
                if (DichVuBUS.ThemDichVu(dv))
                {
                    DanhSachDichVu_Load(sender, e);
                    int num = dgv_DanhSachDichVu.Rows.Count;
                    madichvu = Convert.ToUInt32(dgv_DanhSachDichVu.Rows[num - 2].Cells[0].Value);
                    txt_MaDichVu.Text = Convert.ToString(madichvu);
                    MessageBox.Show("Thêm thành công");
                }
                else
                    MessageBox.Show("Thêm thất bại");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DichVuDTO dv = new DichVuDTO();
            dv.MaDichVu = madichvu;

            if (dv.MaDichVu != 0)
            {
                if (DichVuBUS.XoaDichVu(dv))
                {
                    DanhSachDichVu_Load(sender, e);
                    TaoMoi();
                    MessageBox.Show("Xóa thành công");
                }
                else
                    MessageBox.Show("Xoá thất bại");
            }
            else
                MessageBox.Show("Bạn chưa chọn dịch vụ để xóa");
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            DichVuDTO dv = new DichVuDTO();
            dv.MaDichVu = madichvu;
            if (dv.MaDichVu != 0)
                if (txt_TenDichVu.Text == "")
                    MessageBox.Show("Chưa nhập Tên dịch vụ");
                else if (txt_DonGiaDichVu.Text == "")
                    MessageBox.Show("Chưa nhập đơn giá dịch vụ");
                else
                {
                    dv.TenDichVu = txt_TenDichVu.Text;
                    dv.DonGiaDichVu = uint.Parse(txt_DonGiaDichVu.Text);
                    if (DichVuBUS.CapNhatDichVu(dv))
                    {
                        DanhSachDichVu_Load(sender, e);
                        MessageBox.Show("Cập nhật thành công");
                    }
                    else
                        MessageBox.Show("Cập nhật thất bại");
                }
            else
                MessageBox.Show("Bạn chưa chọn dịch vụ để cập nhật lại thông tin");
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            TaoMoi();
        }
        private void TaoMoi()
        {
            txt_MaDichVu.Text = "";
            txt_TenDichVu.Text = "";
            txt_DonGiaDichVu.Text = "";
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
