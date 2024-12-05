using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_AI
    {
        laptopDataContext db = new laptopDataContext();

        public List<InventoryData> getProductData(string searchKeyword = "")
        {
            var query = db.sanphams
           .Join(db.chitiethoadons,
                 sp => sp.MaSanPham,
                 cthd => cthd.MaSanPham,
                 (sp, cthd) => new { sp, cthd })
           .GroupBy(x => new { x.sp.MaSanPham, x.sp.TenSanPham, x.sp.SoLuong, x.sp.GiaBan })
           .Select(g => new InventoryData(
               g.Key.MaSanPham,
               g.Key.TenSanPham,
               g.Sum(x => x.cthd.SoLuong) ?? 0,
               g.Key.SoLuong ?? 0,
               g.Key.GiaBan ?? 0,
               g.Key.SoLuong <= 5
           ));

            if (!string.IsNullOrEmpty(searchKeyword))
            {
                query = query.Where(x => x.ProductName.ToLower().Contains(searchKeyword.ToLower()) ||
                                          x.ProductId.ToString().ToLower().Contains(searchKeyword.ToLower()));
            }

            return query.ToList();
        }
    }
}
