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
    public class BUS_QuanLy
    {
        DAO_KetNoi xl = new DAO_KetNoi();
        DTO_QuanLy dl = new DTO_QuanLy();
        public DataTable ChonLoai_Select(DTO_QuanLy dl)
        {
            return xl.table_Select("select * from LoaiDoUong");
        }
        public DataTable Loai_Select(DTO_QuanLy dl)
        {
            return xl.table_Select("select * from LoaiDoUong where TrangThai=N''");
        }
        public DataTable ChonTen_Select(DTO_QuanLy dl)
        {
            return xl.table_Select("select * from TenDoUong where MaLoai='" + dl.MaLoai + "'");
        }
        public void TenDoUong_INSERT(DTO_QuanLy dl)
        {
            xl.table_Command("INSERT into TenDoUong VALUES('" + dl.MaLoai + "', N'" + dl.TenDoUong + "', '" + dl.DonGia + "','')");
        }
        public void TenDoUong_Update(DTO_QuanLy dl)
        {
            xl.table_Command("Update TenDoUong set MaLoai ='" + dl.MaLoai + "', TenDoUong= N'" + dl.TenDoUong + "',DonGia= '" + dl.DonGia + "' where STT = '" + dl.STT + "'");
        }
        public void TenDoUong_TrangThai(DTO_QuanLy dl)
        {
            xl.table_Command("Update TenDoUong set TrangThai=N'" + dl.TrangThai + "' where STT = '" + dl.STT + "'");
        }
        public DataTable LoaiDoUong_Search(DTO_QuanLy dl)
        {
            return xl.table_Select("Select * from LoaiDoUong where TenLoai like N'" + dl.TuKhoa + "%' ");
        }
        public void LoaiDoUong_INSERT(DTO_QuanLy dl)
        {
            xl.table_Command("INSERT into LoaiDoUong VALUES( N'" + dl.TenLoai + "','')");/*'" + dl.MaLoai + "',*/
        }
        public void LoaiDoUong_TrangThai(DTO_QuanLy dl)
        {
            xl.table_Command("Update LoaiDoUong set TrangThai=N'" + dl.TrangThai + "' where MaLoai = '" + dl.MaLoai + "'");
        }

    }
}
