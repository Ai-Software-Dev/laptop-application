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
        public DAL_Product() { }
        public List<sanpham> getSanPham()
        {
            return db.sanphams.ToList();
        }
    }
}
