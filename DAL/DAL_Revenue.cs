using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_Revenue
    {
        laptopDataContext db = new laptopDataContext();
        public List<RevenueReport> GetProductSales(DateTime startDate, DateTime endDate)
        {
            var result = (from cthd in db.chitiethoadons
                          join sp in db.sanphams on cthd.MaSanPham equals sp.MaSanPham
                          join hd in db.hoadons on cthd.MaHoaDon equals hd.MaHoaDon
                          where hd.NgayMua >= startDate && hd.NgayMua <= endDate
                                && hd.TrangThai == "Đã xác nhận"
                          group new { cthd, sp } by new { sp.MaSanPham, sp.TenSanPham, sp.GiaBan } into g
                          select new RevenueReport
                          {
                              MaSanPham = g.Key.MaSanPham,
                              TenSanPham = g.Key.TenSanPham,
                              SoLuongBan = g.Sum(x => x.cthd.SoLuong) ?? 0,
                              GiaBan = g.Key.GiaBan ?? 0,
                              ThanhTien = g.Sum(x => x.cthd.ThanhTien) ?? 0
                          }).ToList();

            return result;
        }
    }
}
