using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;
using BUS;
using System.Threading;

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        BUS_DangNhap xldl = new BUS_DangNhap();
        DTO_DangNhap dl = new DTO_DangNhap();
        public frmDangNhap()
        {
            InitializeComponent();
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(2000);// đặt thời gian chạy xong
            t.Abort();
        }
        public void SplashStart()
        {
            Application.Run(new frmManHinhChao());// gọi form Welcome 
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            dtgDangNhap.DataSource = xldl.DangNhap_Select(dl);            
        }
        public static string MaNV;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            MaNV = txtMatKhauDangNhap.Text;
            dl.TaiKhoan = txtTaiKhoanDangNhap.Text;//ta gán phương thức nhập của txtuser vào Tai khoan
            dl.MatKhau = txtMatKhauDangNhap.Text;// gán text box MaNV vào biến MaNV để dùng qua form khác           
            try
            {
                if (txtTaiKhoanDangNhap.Text == "" || txtMatKhauDangNhap.Text == "")//nếu txtuser trống
                {
                MessageBox.Show("Vui lòng nhập đầy đủ thong tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);            
            }
                else//nếu txt k trống 
                {
                    dtgDangNhap.DataSource = xldl.TK_Check(dl);// thì hàm Tk_check sẽ kiểm tra dữ liệu ở csdl...
                    if (dtgDangNhap.RowCount > 0)//nếu có thì đếm dòng ở datagrid view sẽ bằng 1
                    {
                        DialogResult dr;
                        dr = MessageBox.Show("  Đăng nhập thành công", "Thông Báo", MessageBoxButtons.OKCancel);

                        if (dr == DialogResult.OK)
                        {
                            this.Hide();
                            frmHeThong main = new frmHeThong();
                            main.Show();
                        }


                        
                    }
                    else
                    {
                        MessageBox.Show("Sai Mật Khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi Kết Nối !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("  Thoát Khỏi Ứng Dụng ?", "Thông Báo", MessageBoxButtons.OKCancel);

            if (dr == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
