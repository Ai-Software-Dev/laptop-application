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
        DAL_Product dalProduct = new DAL_Product();
        public BLL_Product()
        {

        }
        public List<sanpham> GetSanPham()
        {
            return dalProduct.GetSanPham();
        }
        public List<sanpham> SearchSanPhams(string searchKeyword)
        {
            return dalProduct.SearchSanPhams(searchKeyword);
        }
        public int GetLastIDSanPham()
        {
            return dalProduct.GetLastIDSanPham();
        }

        public bool AddSanPham(sanpham newSP)
        {
            return dalProduct.AddSanPham(newSP);
        }

        public bool UpdateSanPham(sanpham updatedSP)
        {
            return dalProduct.UpdateSanPham(updatedSP);
        }

        public void DeleteSanPham(int maSP)
        {
            dalProduct.DeleteSanPham(maSP);
        }
    }
}
