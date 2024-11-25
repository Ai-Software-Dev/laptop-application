using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_Customer
    {
        DAL_Customer dalCustomer = new DAL_Customer();
        public BLL_Customer()
        {

        }
        public List<user> GetCustomers()
        {
            return dalCustomer.GetCustomers();
        }
        public List<user> SearchCustomers(string searchKeyword)
        {
            return dalCustomer.SearchCustomers(searchKeyword);
        }

        public bool UpdateCustomer(user updatedCus)
        {
            return dalCustomer.UpdateCustomer(updatedCus);
        }

        public void DeleteSanPham(int maKH)
        {
            dalCustomer.DeleteCustomer(maKH);
        }
    }
}
