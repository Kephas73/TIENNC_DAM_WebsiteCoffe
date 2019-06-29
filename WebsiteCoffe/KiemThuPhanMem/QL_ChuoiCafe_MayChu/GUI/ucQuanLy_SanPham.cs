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
using DAO;
using DTO;


namespace GUI
{
    public partial class ucQuanLy_SanPham : UserControl
    {
        public ucQuanLy_SanPham()
        {
            InitializeComponent();
        }
        BUS_QuanLy xldl = new BUS_QuanLy();
        DTO_QuanLy dl = new DTO_QuanLy();
        void Binding()
        {
            txtTenDoUong.DataBindings.Clear();
            txtTenDoUong.DataBindings.Add("Text", dtgMenu.DataSource, "TenDoUong");
            txtGia.DataBindings.Clear();
            txtGia.DataBindings.Add("Text", dtgMenu.DataSource, "DonGia");
            txtSTT.DataBindings.Clear();
            txtSTT.DataBindings.Add("Text", dtgMenu.DataSource, "STT");
            double gia = double.Parse(txtGia.Text.Replace(",", ""));
            txtGia.Text = gia.ToString("0,00.##");
            txtGia.Select(txtGia.TextLength, 0);
        }
        void Clear()
        {
            txtTenDoUong.Clear();
            txtGia.Clear();
        }
        private void Enable_False()
        {
            txtGia.Enabled = false;
            txtTenDoUong.Enabled = false;
            txtMaLoai.Enabled = false;
        }
        private void Enable_True()
        {
            txtGia.Enabled = true;
            txtTenDoUong.Enabled = true;           
        }
        public void ChiNhapSo(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))  // chỉ cho phép nhập số và phím điều khiển
            {
                e.Handled = true;
            }
        }
        public void ChiNhapChu(KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 65 && e.KeyChar <= 122) || (e.KeyChar == 8));// chỉ cho phép nhập chữ
        }
        private void ucQuanLy_SanPham_Load(object sender, EventArgs e)
        {
            cbChonLoai.DataSource = xldl.Loai_Select(dl);
            cbChonLoai.DisplayMember = "TenLoai";
            cbChonLoai.ValueMember = "MaLoai";
            dl.MaLoai = Convert.ToInt32(cbChonLoai.SelectedValue.ToString());
            //dtgMenu.DataSource = xldl.ChonTen_Select(dl);
            Enable_False();            
        }      
        bool them = false;

        private void btThem_Click(object sender, EventArgs e)
        {
            Enable_True();
            them = true;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            btThem.ForeColor = Color.Red;
        }
        bool sua = false;

        private void btLuu_Click(object sender, EventArgs e)
        {
            try
            {
                dl.MaLoai = Convert.ToInt32(cbChonLoai.SelectedValue.ToString());
                dl.TenDoUong = txtTenDoUong.Text;
                dl.DonGia = decimal.Parse(txtGia.Text);
                if (them)
                {
                    xldl.TenDoUong_INSERT(dl);
                    DialogResult dr;
                    dr = MessageBox.Show("  Thêm thành công", "Thông Báo", MessageBoxButtons.OK);

                    if (dr == DialogResult.OK)
                    {
                        dtgMenu.DataSource = xldl.ChonTen_Select(dl);
                    }

                 
                }
                if (sua)
                {
                    dl.STT = int.Parse(txtSTT.Text);
                    xldl.TenDoUong_Update(dl);
                    dtgMenu.DataSource = xldl.ChonTen_Select(dl);
                    sua = false;
                }
                Clear();
                btThem.Enabled = true;
                btSua.ForeColor = Color.Black;
            }
            catch// lỗi khi chưa nhập đủ các ô
            { MessageBox.Show("Chưa Nhập Dữ Liệu", "!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            Enable_True();
            sua = true;
            them = false;
            btThem.Enabled = false;
            btXoa.Enabled = false;
            btSua.ForeColor = Color.Red;
            Binding();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Binding();
            try
            {
                DialogResult dr;
                dr = MessageBox.Show("Xóa" + "\t<" + txtTenDoUong.Text + "> " + " ?", "Thông Báo", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    dl.STT = Convert.ToInt32(txtSTT.Text);
                    dl.TrangThai = "Hết Phục Vụ";
                    xldl.TenDoUong_TrangThai(dl);
                    dtgMenu.DataSource = xldl.ChonTen_Select(dl);
                    Clear();
                }
            }
            catch { MessageBox.Show(" Lỗi !", "Thông Báo", MessageBoxButtons.OKCancel); }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            btSua.Enabled = true;
            btXoa.Enabled = true;
            btThem.Enabled = true;
            btThem.ForeColor = Color.Black;
            btSua.ForeColor = Color.Black;
            Enable_False();
            dl.MaLoai = Convert.ToInt32(cbChonLoai.SelectedValue.ToString());
            dtgMenu.DataSource = xldl.ChonTen_Select(dl);
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChiNhapSo(e);
        }

        private void txtGia_Leave(object sender, EventArgs e)
        {
            try
            {
                double gia = double.Parse(txtGia.Text.Replace(",", ""));
                txtGia.Text = gia.ToString("0,00.##");
                txtGia.Select(txtGia.TextLength, 0);
            }
            catch { MessageBox.Show("Bạn Chưa Nhập Giá !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void cbChonLoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btPhucHoi_Click(object sender, EventArgs e)
        {
            Binding();
            try
            {
                DialogResult dr;
                dr = MessageBox.Show("Phục Vụ Lại" + "\t<" + txtTenDoUong.Text + ">" + "?", "Thông Báo", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    dl.STT = Convert.ToInt32(txtSTT.Text);
                    dl.TrangThai = "";
                    xldl.TenDoUong_TrangThai(dl);
                    dtgMenu.DataSource = xldl.ChonTen_Select(dl);
                    Clear();
                }
            }
            catch { MessageBox.Show(" Lỗi !", "Thông Báo", MessageBoxButtons.OKCancel); }
        }

        private void cbChonLoai_Click(object sender, EventArgs e)
        {
            ucQuanLy_SanPham_Load(sender, e);           
        }

        private void cbChonLoai_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {                
                txtMaLoai.Text = cbChonLoai.SelectedValue.ToString();                
            }
            catch { MessageBox.Show("\tKiểm Tra Lại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
        }

        private void btTim_Click(object sender, EventArgs e)
        {
           
            dl.MaLoai = Convert.ToInt32(txtMaLoai.Text);
            dtgMenu.DataSource = xldl.ChonTen_Select(dl);
        }

        private void cbChonLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
