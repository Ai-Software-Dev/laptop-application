using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Statistics
    {
        laptopDataContext db = new laptopDataContext();
        public DAL_Statistics()
        {

        }
        public List<int> GetDistinctYears()
        {
            return db.hoadons
                .Where(hd => hd.NgayMua.HasValue)  // Kiểm tra có giá trị NgayMua
                .Select(hd => hd.NgayMua.Value.Year)  // Lấy năm từ NgayMua
                .Distinct()  // Lấy các năm duy nhất
                .OrderBy(y => y)  // Sắp xếp theo năm
                .ToList();  // Trả về danh sách các năm
        }
        public List<RevenueByMonth> GetRevenueByMonth(int year)
        {
            return db.hoadons
                .Where(hd => hd.NgayMua.Value.Year == year)
                .GroupBy(hd => hd.NgayMua.Value.Month)
                .Select(g => new RevenueByMonth
                {
                    Thang = g.Key,
                    TongDoanhThu = g.Sum(hd => hd.TongTien) ?? 0
                })
                .OrderBy(x => x.Thang)
                .ToList();
        }

        public List<ProductSalesByMonth> GetProductSalesByMonth(int year)
        {
            return db.chitiethoadons
                .Where(cthd => cthd.hoadon.NgayMua.Value.Year == year)
                .GroupBy(cthd => cthd.hoadon.NgayMua.Value.Month)
                .Select(g => new ProductSalesByMonth
                {
                    Thang = g.Key,
                    TongSoLuong = g.Sum(cthd => cthd.SoLuong) ?? 0
                })
                .OrderBy(x => x.Thang)
                .ToList();
        }

        public List<TopCustomer> GetTopCustomers(int year)
        {
            return db.hoadons
                .Where(hd => hd.NgayMua.Value.Year == year)
                .GroupBy(hd => new { hd.MaTaiKhoan, hd.user.TenKhachHang })
                .Select(g => new TopCustomer
                {
                    TenKhachHang = g.Key.TenKhachHang,
                    TongTien = g.Sum(hd => hd.TongTien) ?? 0
                })
                .OrderByDescending(x => x.TongTien)
                .Take(5)
                .ToList();
        }
    }
}
