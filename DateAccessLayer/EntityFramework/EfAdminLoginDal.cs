using DateAccessLayer.Abstrack;
using DateAccessLayer.Concrete.Ropositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAccessLayer.EntityFramework
{
    public class EfAdminLoginDal: GenericRepository<Admin>, IAdminLoginDal
    {
    }
}
