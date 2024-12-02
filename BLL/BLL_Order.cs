using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_Order
    {
        DAL_Order dalOrder = new DAL_Order();
        public BLL_Order()
        {

        }
        public List<hoadon> GetHoaDon()
        {
            return dalOrder.GetHoaDon();
        }
        public List<hoadon> SearchHoaDons(string searchKeyword)
        {
            return dalOrder.SearchHoaDons(searchKeyword);
        }
        public HoaDonChiTiet GetHoaDonByID(int mahd)
        {
            return dalOrder.GetHoaDonByID(mahd);
        }
        public bool UpdateOrders(int mahd)
        {
            return dalOrder.UpdateOrders(mahd);
        }
    }
}
