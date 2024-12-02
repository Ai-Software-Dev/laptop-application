using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Order
    {
        laptopDataContext db = new laptopDataContext();
        public DAL_Order()
        {

        }

        public List<hoadon> GetHoaDon()
        {
            db = new laptopDataContext();
            return db.hoadons.ToList();
        }
        public List<hoadon> SearchHoaDons(string searchKeyword)
        {
            return db.hoadons
                    .Where(h => h.MaHoaDon.ToString().ToLower().Contains(searchKeyword.ToLower()))
                    .ToList();
        }
        public HoaDonChiTiet GetHoaDonByID (int mahd)
        {
            var result = (from hd in db.hoadons
                          join u in db.users on hd.MaTaiKhoan equals u.MaTaiKhoan
                          join cthd in db.chitiethoadons on hd.MaHoaDon equals cthd.MaHoaDon
                          join sp in db.sanphams on cthd.MaSanPham equals sp.MaSanPham
                          where hd.MaHoaDon == mahd
                          group new { hd, u, cthd, sp } by new
                          {
                              hd.MaHoaDon,
                              hd.NgayMua,
                              hd.DiaChi,
                              hd.SDT,
                              hd.HinhThucThanhToan,
                              hd.TongTien,
                              hd.TrangThai,
                              u.TenKhachHang
                          } into g
                          select new HoaDonChiTiet
                          {
                              MaHoaDon = g.Key.MaHoaDon,
                              TenKhachHang = g.Key.TenKhachHang,
                              DiaChi = g.Key.DiaChi,
                              SDT = g.Key.SDT,
                              NgayMua = g.Key.NgayMua ?? DateTime.Now,
                              HinhThucThanhToan = g.Key.HinhThucThanhToan,
                              TongTien = g.Key.TongTien ?? 0,
                              TrangThai = g.Key.TrangThai,
                              ChiTietSanPhams = g.Select(x => new ChiTietSanPham
                              {
                                  MaSanPham = x.sp.MaSanPham,
                                  TenSanPham = x.sp.TenSanPham,
                                  SoLuong = x.cthd.SoLuong ?? 0,
                                  GiaBan = x.sp.GiaBan ?? 0,
                                  ThanhTien = x.cthd.ThanhTien ?? 0
                              }).ToList()
                          }).FirstOrDefault();

            return result;
        }
        public bool UpdateOrders(int mahd)
        {
            var existingorder = db.hoadons.FirstOrDefault(h => h.MaHoaDon == mahd);
            if (existingorder != null)
            {
                existingorder.TrangThai = "Đã xác nhận";

                db.SubmitChanges();
                return true;
            }

            return false;
        }
    }
}
