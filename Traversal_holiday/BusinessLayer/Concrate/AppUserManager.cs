using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
   public class AppUserManager:IAppUserService
    {
        IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public void Tadd(AppUser t)
        {
            throw new NotImplementedException();
        }

        public void Tdelete(AppUser t)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> TgetList()
        {
            return _appUserDal.GetList();
        }

        public List<AppUser> TgetListById(int id)
        {
            var a = _appUserDal.GetListAllById(x => x.Id == id).ToList();
            return a;
        }

        public void Tupdate(AppUser t)
        {
            throw new NotImplementedException();
        }
    }
}
