using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class ucNhanVien : UserControl
    {
        public ucNhanVien()
        {
            InitializeComponent();
        }
        BUS_NhanVien xldl = new BUS_NhanVien();
        DTO_NhanVien dl = new DTO_NhanVien();
        private void ucNhanVien_Load(object sender, EventArgs e)
        {
            txtTim.Enabled = false;
            cbChonChiNhanh.DataSource = xldl.ChiNhanh_select(dl);
            cbChonChiNhanh.DisplayMember = "TenChiNhanh";
            cbChonChiNhanh.ValueMember = "MaChiNhanh";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                txtTim.Enabled = true;
                txtTim.Clear();
            }
            catch { MessageBox.Show("\tKiểm Tra Lại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            try
            {
                dl.MaChiNhanh = cbChonChiNhanh.SelectedValue.ToString();
                dtgNhanVien.DataSource = xldl.ThongTinNhanVien_Select(dl);
            }
            catch { MessageBox.Show("\tKiểm Tra Lại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnXemTatCa_Click(object sender, EventArgs e)
        {
            try
            {
                dtgNhanVien.DataSource = xldl.TatCaThongTinNhanVien_Select(dl);
            }
            catch { MessageBox.Show("\tKiểm Tra Lại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            txtTim.Enabled = false;
            txtTim.Clear();
        }       
        private void txtTim_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                dl.TenNhanVien = txtTim.Text;
                dtgNhanVien.DataSource = xldl.NV_Search(dl);
            }
            catch { MessageBox.Show("\tKiểm Tra Lại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
