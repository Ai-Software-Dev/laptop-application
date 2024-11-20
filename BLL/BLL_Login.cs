using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLL_Login
    {
        DAL_Login da = new DAL_Login();
        public BLL_Login() { }
        public bool Login(string name, string pass)
        {
            return da.CheckLogin(name, pass);
        }
    }
}
