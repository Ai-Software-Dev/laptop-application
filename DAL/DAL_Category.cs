using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_Category
    {
        laptopDataContext db;

        public DAL_Category()
        {
            db = new laptopDataContext();
        }

        public List<hang> GetHangs()
        {
            return db.hangs.ToList();
        }
        public List<hang> SearchHangs(string searchKeyword)
        {
            return db.hangs
                     .Where(h => h.TenHang.Contains(searchKeyword)) 
                     .ToList();
        }

        public void AddHang(hang newHang)
        {
            db.hangs.InsertOnSubmit(newHang);
            db.SubmitChanges();
        }

        public void UpdateHang(hang updatedHang)
        {
            var existingHang = db.hangs.FirstOrDefault(h => h.MaHang == updatedHang.MaHang);
            if (existingHang != null)
            {
                existingHang.TenHang = updatedHang.TenHang;
                db.SubmitChanges();
            }
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
