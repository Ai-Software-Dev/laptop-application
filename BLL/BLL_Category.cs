using System;
using System.Collections.Generic;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_Category
    {
        private DAL_Category dalCategory;

        public BLL_Category()
        {
            dalCategory = new DAL_Category();
        }

        public List<hang> GetHangs()
        {
            return dalCategory.GetHangs();
        }
        public List<hang> SearchHangs(string searchKeyword)
        {
            return dalCategory.SearchHangs(searchKeyword);
        }
        public void AddHang(hang newHang)
        {
            dalCategory.AddHang(newHang);
        }

        public void UpdateHang(hang updatedHang)
        {
            dalCategory.UpdateHang(updatedHang);
        }

        public void DeleteHang(int maHang)
        {
            dalCategory.DeleteHang(maHang);
        }
    }
}
