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
    public class BUS_NhanVien
    {
        DAO_KetNoi xl = new DAO_KetNoi();
        DTO_NhanVien dl = new DTO_NhanVien();
        public DataTable ThongTinNhanVien_Select(DTO_NhanVien dl)
        {
            return xl.table_Select("select STT,TenChiNhanh,NhanVien.MaNV,ViTri,TenNhanVien,NamSinh,SDT from NhanVien,ViTriNhanVien,ChiNhanh where ChiNhanh.MaChiNhanh = NhanVien.MaChiNhanh and ViTriNhanVien.MaNV = NhanVien.MaNV and ChiNhanh.MaChiNhanh='" + dl.MaChiNhanh + "'");
        }
        public DataTable TatCaThongTinNhanVien_Select(DTO_NhanVien dl)
        {
            return xl.table_Select("select STT,TenChiNhanh,NhanVien.MaNV,ViTri,TenNhanVien,NamSinh,SDT from NhanVien,ViTriNhanVien,ChiNhanh where ChiNhanh.MaChiNhanh = NhanVien.MaChiNhanh and ViTriNhanVien.MaNV = NhanVien.MaNV ");
        }
        public DataTable NV_Search(DTO_NhanVien dl)
        {
            return xl.table_Select("Select STT,TenChiNhanh,NhanVien.MaNV,ViTri,TenNhanVien,NamSinh,SDT from NhanVien,ViTriNhanVien,ChiNhanh where ChiNhanh.MaChiNhanh = NhanVien.MaChiNhanh and ViTriNhanVien.MaNV = NhanVien.MaNV and TenNhanVien like N'%" + dl.TenNhanVien + "%' ");
        }
        public DataTable ChiNhanh_select(DTO_NhanVien dl)
        {
            return xl.table_Select("select * from ChiNhanh");
        }


    }
}
