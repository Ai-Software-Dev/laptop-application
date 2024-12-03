using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RevenueReport
    {
        public int MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public int SoLuongBan { get; set; }
        public double GiaBan { get; set; }
        public double ThanhTien { get; set; }
    }
}
