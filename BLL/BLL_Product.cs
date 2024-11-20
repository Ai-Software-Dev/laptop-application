using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLL_Product
    {
        DAL_Product _product = new DAL_Product();
        public List<sanpham> GetSanphams()
        {
            return _product.getSanPham();
        } 
    }
}
