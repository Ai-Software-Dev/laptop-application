using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.Linq;

namespace DAL
{
    public class DAL_Login
    {
        laptopDataContext db = new laptopDataContext();
        public DAL_Login() { }
        public bool CheckLogin(string name, string pass)
        {
            var login = db.admins.SingleOrDefault(lg => lg.TenTaiKhoan == name && lg.MatKhau == pass);
            return login != null;
        }
    }
}
