using System;
using System.Collections.Generic;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_Category
    {
        private DAL_Category dalCategory = new DAL_Category();

        public BLL_Category()
        {

        }

        public List<hang> GetHangs()
        {
            return dalCategory.GetHangs();
        }
        public List<hang> SearchHangs(string searchKeyword)
        {
            return dalCategory.SearchHangs(searchKeyword);
        }
        public int GetLastIDHang()
        {
            return dalCategory.GetLastIDHang();
        }
        public bool AddHang(hang newHang)
        {
            return dalCategory.AddHang(newHang);
        }

        public bool UpdateHang(hang updatedHang)
        {
            return dalCategory.UpdateHang(updatedHang);
        }

        public void DeleteHang(int maHang)
        {
            dalCategory.DeleteHang(maHang);
        }
    }
}
