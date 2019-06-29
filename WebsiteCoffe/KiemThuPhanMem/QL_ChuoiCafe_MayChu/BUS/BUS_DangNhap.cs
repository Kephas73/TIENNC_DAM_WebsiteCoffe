using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_DangNhap
    {
        DAO_KetNoi xl = new DAO_KetNoi();
        DTO_DangNhap dl = new DTO_DangNhap();
        public DataTable DangNhap_Select(DTO_DangNhap dl)
        {
            return xl.table_Select("select * from MayChu");
        }
        public DataTable TK_Check(DTO_DangNhap dl)
        {
            return xl.table_Select("select * from MayChu where TaiKhoan_admin=N'" + dl.TaiKhoan + "' and MatKhau_admin=N'" + dl.MatKhau + "'");
        }







    }
}
