using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_Statistics
    {
        DAL_Statistics dalSta = new DAL_Statistics();
        public BLL_Statistics()
        {

        }
        public List<int> GetDistinctYears()
        {
            return dalSta.GetDistinctYears();
        }
        public List<RevenueByMonth> GetRevenueByMonth(int year)
        {
            return dalSta.GetRevenueByMonth(year);
        }

        public List<ProductSalesByMonth> GetProductSalesByMonth(int year)
        {
            return dalSta.GetProductSalesByMonth(year);
        }

        public List<TopCustomer> GetTopCustomers(int year)
        {
            return dalSta.GetTopCustomers(year);
        }
    }
}
