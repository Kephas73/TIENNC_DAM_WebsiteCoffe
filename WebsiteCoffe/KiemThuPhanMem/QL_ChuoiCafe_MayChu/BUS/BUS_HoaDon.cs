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
    public class BUS_HoaDon
    {
        DAO_KetNoi xl = new DAO_KetNoi();
        DTO_HoaDon dl = new DTO_HoaDon();
        public DataTable TuNgayDenNgay_Select(DTO_HoaDon dl)
        {
            return xl.table_Select("set dateformat dmy select MaNV,HoaDon.MaHD,HoaDon.Ngay,HoaDon.Gio,TenDoUong,DonGia,SlMua,Tong from HoaDon,ChiTietBanHang where HoaDon.MaHD=ChiTietBanHang.MaHD and HoaDon.Ngay >='" + dl.TuNgay + "' and HoaDon.Ngay <= '" + dl.DenNgay + "' and HoaDon.MaChiNhanh='" + dl.MaChiNhanh + "' order by Ngay desc");
        }
        public DataTable TongTienThongKe_Select(DTO_HoaDon dl)
        {
            return xl.table_Select("set dateformat dmy select Sum(Tong) as [TatCa] from HoaDon,ChiTietBanHang where HoaDon.MaHD=ChiTietBanHang.MaHD and HoaDon.Ngay >='" + dl.TuNgay + "' and HoaDon.Ngay <= '" + dl.DenNgay + "' and HoaDon.MaChiNhanh='" + dl.MaChiNhanh + "'");
        }
        public DataTable Gio_Select(DTO_HoaDon dl)
        {
            return xl.table_Select("set dateformat dmy select Gio, TenDoUong,sum(Tong) as [Tong] from ChiTietBanHang where MaChiNhanh ='" + dl.MaChiNhanh + "' group by Gio, TenDoUong order by sum(Tong) desc");
        }
        public DataTable ChiNhanh_select(DTO_HoaDon dl)
        {
            return xl.table_Select("select * from ChiNhanh");
        }
    }
}
