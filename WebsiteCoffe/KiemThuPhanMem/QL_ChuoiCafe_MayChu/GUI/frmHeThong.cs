using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAO;
using DTO;
using System.Globalization;

namespace GUI
{
    public partial class frmHeThong : Form
    {
        DTO_DoThiCot dlc = new DTO_DoThiCot(); // Khai báo đối tượng từ lớp BUS và DTO
       
        public frmHeThong()
        {
            InitializeComponent();
        }

        private void frmHeThong_Load(object sender, EventArgs e)
        {
            ucQuanLy_LoaiSanPham1.Hide();
            ucQuanLy_SanPham1.Hide();
            ucNhanVien1.Hide();
           
          
            lbNgay.Text = DateTime.Now.ToString("dddd,dd/MM/yyyy", new CultureInfo("vi-VN"));
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            pnBangDieuKhien_Show.Show();
            pnBangDieuKhien_Show.BringToFront();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            pnBangDieuKhien_Show.Hide();
        }
        public void ThoatChuongTrinh()
        {
            DialogResult dr;
            dr = MessageBox.Show("  Thoát Khỏi Ứng Dụng ?", "Thông Báo", MessageBoxButtons.OKCancel);

            if (dr == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            ThoatChuongTrinh();
        }

        private void btTrangChu_Click(object sender, EventArgs e)
        {
            pnSlide_L.Height = btTrangChu.Height; pnSlide_R.Height = btTrangChu.Height;
            pnSlide_L.Top = btTrangChu.Top; pnSlide_R.Top = btTrangChu.Top;
            pnSlide_Hide.Top = btTrangChu_Hide.Top; pnSlide_Hide.Height = btTrangChu_Hide.Height;           
            pbTrangChu.BringToFront();
            ucQuanLy_LoaiSanPham1.Hide();
            ucQuanLy_SanPham1.Hide();
            ucNhanVien1.Hide();
           
        }

        private void btLoaiSanPham_Click(object sender, EventArgs e)
        {
            pnSlide_L.Height = btLoaiSanPham.Height; pnSlide_R.Height = btLoaiSanPham.Height;
            pnSlide_L.Top = btLoaiSanPham.Top; pnSlide_R.Top = btLoaiSanPham.Top;
            pnSlide_Hide.Top = btLoaiSanPham_Hide.Top; pnSlide_Hide.Height = btLoaiSanPham_Hide.Height;
            pbTrangChu.SendToBack();
            ucQuanLy_SanPham1.Hide();
            ucNhanVien1.Hide();
          
            pbTrangChu.SendToBack();
            ucQuanLy_LoaiSanPham1.BringToFront();
            ucQuanLy_LoaiSanPham1.Show();
        }

        private void btSanPham_Click(object sender, EventArgs e)
        {
            pnSlide_L.Height = btSanPham.Height; pnSlide_R.Height = btSanPham.Height;
            pnSlide_L.Top = btSanPham.Top; pnSlide_R.Top = btSanPham.Top;
            pnSlide_Hide.Top = btNhanVien_Hide.Top; pnSlide_Hide.Height = btNhanVien_Hide.Height;
            pbTrangChu.SendToBack();
            ucQuanLy_LoaiSanPham1.Hide();
            ucNhanVien1.Hide();
           
            pbTrangChu.SendToBack();
            ucQuanLy_SanPham1.Show();
            ucQuanLy_SanPham1.BringToFront();
        }

        private void btNhanVien_Click(object sender, EventArgs e)
        {
            pnSlide_L.Height = btNhanVien.Height; pnSlide_R.Height = btNhanVien.Height;
            pnSlide_L.Top = btNhanVien.Top; pnSlide_R.Top = btNhanVien.Top;
            pnSlide_Hide.Top = btNhanVien_Hide.Top; pnSlide_Hide.Height = btNhanVien_Hide.Height;
            pbTrangChu.SendToBack();
            ucQuanLy_LoaiSanPham1.Hide();
            ucQuanLy_SanPham1.Hide();          
            pbTrangChu.SendToBack();
            ucNhanVien1.Show();
            ucNhanVien1.BringToFront();
        }

        private void btDoThi_Click(object sender, EventArgs e)
        {
          
            pbTrangChu.SendToBack();
            ucQuanLy_LoaiSanPham1.Hide();
            ucQuanLy_SanPham1.Hide();
            ucNhanVien1.Hide();
           
            pbTrangChu.SendToBack();
              
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {           
            pbTrangChu.SendToBack();
            ucQuanLy_LoaiSanPham1.Hide();
            ucQuanLy_SanPham1.Hide();
            ucNhanVien1.Hide();
         
            pbTrangChu.SendToBack();
           
            pnBangDieuKhien_Hide.BringToFront();
            pnBangDieuKhien_Show.Hide();
        }

        private void btHelp_Click(object sender, EventArgs e)
        {

        }
    }
}
