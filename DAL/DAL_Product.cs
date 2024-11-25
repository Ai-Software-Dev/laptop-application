using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_Product
    {
        laptopDataContext db = new laptopDataContext();
        public DAL_Product()
        {

        }
        public List<sanpham> GetSanPham()
        {
            db = new laptopDataContext();
            return db.sanphams.ToList();
        }
        public List<sanpham> SearchSanPhams(string searchKeyword)
        {
            return db.sanphams
                    .Where(s => s.TenSanPham != null && s.TenSanPham.ToLower().Contains(searchKeyword.ToLower()) ||
                    s.MaSanPham.ToString().ToLower().Contains(searchKeyword))
                    .ToList();
        }

        public int GetLastIDSanPham()
        {
            return db.sanphams.OrderByDescending(s => s.MaSanPham).FirstOrDefault()?.MaSanPham ?? 0;
        }

        public bool AddSanPham(sanpham newSP)
        {
            var checkSP = db.sanphams.FirstOrDefault(s => s.TenSanPham.ToLower() == newSP.TenSanPham.ToLower() && s.MaHang == newSP.MaHang);

            if (checkSP != null)
            {
                return false;
            }

            db.sanphams.InsertOnSubmit(newSP);
            db.SubmitChanges();
            return true;
        }

        public bool UpdateSanPham(sanpham updatedSP)
        {
            // Tìm bản ghi hiện tại có MaHang khớp với updatedHang
            var existingSanPham = db.sanphams.FirstOrDefault(s => s.MaSanPham == updatedSP.MaSanPham);
            if (existingSanPham != null)
            {
                // Kiểm tra nếu tên hàng mới đã tồn tại trong cơ sở dữ liệu (trừ chính nó)
                var checkDuplicate = db.sanphams
                    .FirstOrDefault(s => s.TenSanPham.ToLower() == updatedSP.TenSanPham.ToLower() && s.MaHang == updatedSP.MaHang && s.MaSanPham != updatedSP.MaSanPham );

                if (checkDuplicate != null)
                {
                    return false;
                }

                // Cập nhật các trường cần thiết
                existingSanPham.TenSanPham = updatedSP.TenSanPham;
                existingSanPham.MoTa = updatedSP.MoTa;
                existingSanPham.HinhAnh = updatedSP.HinhAnh;
                existingSanPham.GiaBan = updatedSP.GiaBan;
                existingSanPham.CPU = updatedSP.CPU;
                existingSanPham.Ram = updatedSP.Ram;
                existingSanPham.OCung = updatedSP.OCung;
                existingSanPham.ManHinh = updatedSP.ManHinh;
                existingSanPham.VGA = updatedSP.VGA;
                existingSanPham.HeDieuHanh = updatedSP.HeDieuHanh;
                existingSanPham.TrongLuong = updatedSP.TrongLuong;
                existingSanPham.Pin = updatedSP.Pin;
                existingSanPham.SoLuong = updatedSP.SoLuong;
                existingSanPham.MaHang = updatedSP.MaHang;

                db.SubmitChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                return true;
            }

            return false; // Trả về false nếu không tìm thấy bản ghi cần cập nhật
        }

        public void DeleteSanPham(int maSP)
        {
            var SPToDelete = db.sanphams.FirstOrDefault(s => s.MaSanPham == maSP);
            if (SPToDelete != null)
            {
                db.sanphams.DeleteOnSubmit(SPToDelete);
                db.SubmitChanges();
            }
        }
    }
}
