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
    public partial class ucQuanLy_LoaiSanPham : UserControl
    {
        public ucQuanLy_LoaiSanPham()
        {
            InitializeComponent();
        }
        BUS_QuanLy xldl = new BUS_QuanLy();
        DTO_QuanLy dl = new DTO_QuanLy();
        void Binding()
        {
            txtChonLoai.DataBindings.Clear();
            txtChonLoai.DataBindings.Add("Text", dtgMenu.DataSource, "TenLoai");
            txtMaLoai.DataBindings.Clear();
            txtMaLoai.DataBindings.Add("Text", dtgMenu.DataSource, "MaLoai");
        }
        void Clear()
        {
            txtChonLoai.ResetText();
            txtMaLoai.Clear();
        }
        private void Enable_False()
        {           
            txtChonLoai.Enabled = false;
        }
        private void Enable_True()
        {            
            txtChonLoai.Enabled = true;
        }
        private void btHuy_Click(object sender, EventArgs e)
        {
            dtgMenu.DataSource = xldl.ChonLoai_Select(dl);
            btXoa.Enabled = true;
            btThem.Enabled = true;
            btThem.ForeColor = Color.Black;
            Enable_False();
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            Binding();
            try
            {
                DialogResult dr;
                dr = MessageBox.Show("Xóa" + "\t<" + txtChonLoai.Text + ">" + "?", "Thông Báo", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    dl.MaLoai = Convert.ToInt32(txtMaLoai.Text);
                    dl.TrangThai = "Hết Phục Vụ";
                    xldl.LoaiDoUong_TrangThai(dl);
                    dtgMenu.DataSource = xldl.ChonLoai_Select(dl);
                    Clear();
                }
            }
            catch { MessageBox.Show(" Lỗi !", "Thông Báo", MessageBoxButtons.OKCancel); }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            try
            {                
                dl.TenLoai = txtChonLoai.Text;
                if (them)
                {
                    xldl.LoaiDoUong_INSERT(dl);
                    dtgMenu.DataSource = xldl.ChonLoai_Select(dl);
                }
                Clear();
                btThem.Enabled = true;
            }
            catch// lỗi khi chưa nhập đủ các ô
            { MessageBox.Show("Chưa Nhập Dữ Liệu", "!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                Enable_True();
                them = true;
                btXoa.Enabled = false;
                btThem.ForeColor = Color.Red;
            }
            catch { MessageBox.Show("\tKiểm Tra Lại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btPhucHoi_Click(object sender, EventArgs e)
        {
            Binding();
            try
            {
                DialogResult dr;
                dr = MessageBox.Show("Phục Vụ Lại" + "\t<" + txtChonLoai.Text + ">" + "?", "Thông Báo", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    //dl.MaLoai = Convert.ToInt32(txtMaLoai.Text);
                    dl.TrangThai = "";
                    xldl.LoaiDoUong_TrangThai(dl);
                    dtgMenu.DataSource = xldl.ChonLoai_Select(dl);
                    Clear();
                }
            }
            catch { MessageBox.Show(" Lỗi !", "Thông Báo", MessageBoxButtons.OKCancel); }
        }

        private void ucQuanLy_LoaiSanPham_Load(object sender, EventArgs e)
        {
            dtgMenu.DataSource = xldl.ChonLoai_Select(dl);
            Enable_False();
        }
        private void txtChonLoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                dl.TuKhoa = txtChonLoai.Text;
                dtgMenu.DataSource = xldl.LoaiDoUong_Search(dl);
                if (txtChonLoai.Text == "")
                {
                    dtgMenu.DataSource = xldl.ChonLoai_Select(dl);
                }
            }
            catch { MessageBox.Show("\tKiểm Tra Lại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        bool them = false;
    }
}
