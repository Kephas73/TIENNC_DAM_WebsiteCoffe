using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DoThiCot
    {
        public int MaLoai { get; set; }
        public String TenLoai { get; set; }
        public String TenDoUong { get; set; }

        public decimal DonGia { get; set; }

        public int STT { get; set; }
        public String MaChiNhanh { get; set; }
        public String TenChiNhanh { get; set; }
        public String MaNV { get; set; }
        public DateTime Ngay { get; set; }
        public float SlMua { get; set; }
        public decimal Tong { get; set; }
        public String MaHD { get; set; }
    }
}
