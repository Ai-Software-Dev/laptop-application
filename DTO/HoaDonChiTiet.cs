using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonChiTiet
    {
        public int MaHoaDon { get; set; }
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public DateTime NgayMua { get; set; }
        public string HinhThucThanhToan { get; set; }
        public double TongTien { get; set; }
        public string TrangThai { get; set; }
        public List<ChiTietSanPham> ChiTietSanPhams { get; set; }
    }
}
