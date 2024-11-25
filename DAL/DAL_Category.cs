using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_Category
    {
        laptopDataContext db = new laptopDataContext();

        public DAL_Category()
        {

        }

        public List<hang> GetHangs()
        {
            db = new laptopDataContext();
            return db.hangs.ToList();
        }
        public List<hang> SearchHangs(string searchKeyword)
        {
            return db.hangs
                    .Where(h => h.TenHang != null && h.TenHang.ToLower().Contains(searchKeyword.ToLower()) ||
                    h.MaHang.ToString().ToLower().Contains(searchKeyword))
                    .ToList();
        }

        public int GetLastIDHang()
        {
            return db.hangs.OrderByDescending(h => h.MaHang).FirstOrDefault()?.MaHang ?? 0;
        }

        public bool AddHang(hang newHang)
        {
            var checkHang = db.hangs.FirstOrDefault(h => h.TenHang.ToLower() == newHang.TenHang.ToLower());

            if (checkHang != null)
            {
                return false;
            }    
            db.hangs.InsertOnSubmit(newHang);
            db.SubmitChanges();
            return true;
        }

        public bool UpdateHang(hang updatedHang)
        {
            // Tìm bản ghi hiện tại có MaHang khớp với updatedHang
            var existingHang = db.hangs.FirstOrDefault(h => h.MaHang == updatedHang.MaHang);
            if (existingHang != null)
            {
                // Kiểm tra nếu tên hàng mới đã tồn tại trong cơ sở dữ liệu (trừ chính nó)
                var checkDuplicate = db.hangs
                    .FirstOrDefault(h => h.TenHang.ToLower() == updatedHang.TenHang.ToLower() && h.MaHang != updatedHang.MaHang);

                if (checkDuplicate != null)
                {
                    return false; // Trả về false nếu tên hàng trùng lặp
                }

                // Cập nhật các trường cần thiết
                existingHang.TenHang = updatedHang.TenHang;
                existingHang.Logo = updatedHang.Logo;

                db.SubmitChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                return true;
            }

            return false; // Trả về false nếu không tìm thấy bản ghi cần cập nhật
        }

        public void DeleteHang(int maHang)
        {
            var hangToDelete = db.hangs.FirstOrDefault(h => h.MaHang == maHang);
            if (hangToDelete != null)
            {
                db.hangs.DeleteOnSubmit(hangToDelete);  
                db.SubmitChanges();
            }
        }
    }
}
