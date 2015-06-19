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
    public partial class BaoCaoTon : Form
    {
        public BaoCaoTon()
        {
            InitializeComponent();
        }

        private void btn_LapBaoCao_Click(object sender, EventArgs e)
        {
            DataTable dt = ChiTietBaoCaoTonDAO.SelectAllChiTietBaoCaoTon();
            dgv_ChiTietBaoCaoTon.DataSource = dt;
            txt_MaBaoCao.Text = "1";
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
