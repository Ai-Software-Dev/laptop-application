using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLL_Revenue
    {
        DAL_Revenue dal_Revenue = new DAL_Revenue();
        public List<RevenueReport> GetProductSales(DateTime startDate, DateTime endDate)
        {
            return dal_Revenue.GetProductSales(startDate, endDate);
        }
    }
}
