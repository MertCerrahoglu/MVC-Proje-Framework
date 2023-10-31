using BusinessLayer.Abstract;
using DateAccessLayer.Abstrack;
using DateAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AdminLoginManager : IAdminLoginService
    {
        IAdminLoginDal _adminDal;

        public AdminLoginManager(IAdminLoginDal adminDal)
        {
            _adminDal=adminDal;
        }

        public Admin GetAdmin(string username, string password)
        {
            return _adminDal.Get(x=>x.AdminUserName==username && x.AdminPassword==password);
        }
    }
}