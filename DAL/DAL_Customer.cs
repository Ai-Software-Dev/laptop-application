using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Customer
    {
        laptopDataContext db = new laptopDataContext();
        public DAL_Customer()
        {

        }
        public List<user> GetCustomers()
        {
            db = new laptopDataContext();
            return db.users.ToList();
        }
        public List<user> SearchCustomers(string searchKeyword)
        {
            return db.users
                    .Where(u => u.TenTaiKhoan != null && u.TenTaiKhoan.ToLower().Contains(searchKeyword.ToLower()) ||
                    u.MaTaiKhoan.ToString().ToLower().Contains(searchKeyword))
                    .ToList();
        }

        public bool UpdateCustomer(user updatedCus)
        {
            var existingCus = db.users.FirstOrDefault(u => u.MaTaiKhoan == updatedCus.MaTaiKhoan);
            if (existingCus != null)
            {
                // Kiểm tra nếu tên hàng mới đã tồn tại trong cơ sở dữ liệu (trừ chính nó)
                var checkDuplicate = db.users
                    .FirstOrDefault(u => (u.TenTaiKhoan == updatedCus.TenTaiKhoan || u.Email == updatedCus.Email) && u.MaTaiKhoan != updatedCus.MaTaiKhoan);

                if (checkDuplicate != null)
                {
                    return false;
                }

                // Cập nhật các trường cần thiết
                existingCus.TenKhachHang = updatedCus.TenKhachHang;
                existingCus.TenTaiKhoan = updatedCus.TenTaiKhoan;
                existingCus.MatKhau = updatedCus.MatKhau;
                existingCus.Email = updatedCus.Email;

                db.SubmitChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                return true;
            }

            return false; // Trả về false nếu không tìm thấy bản ghi cần cập nhật
        }

        public void DeleteCustomer(int maKH)
        {
            var CusToDelete = db.users.FirstOrDefault(u => u.MaTaiKhoan == maKH);
            if (CusToDelete != null)
            {
                db.users.DeleteOnSubmit(CusToDelete);
                db.SubmitChanges();
            }
        }
    }
}
