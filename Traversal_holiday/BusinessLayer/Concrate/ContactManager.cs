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
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void Tadd(Contact t)
        {
            throw new NotImplementedException();
        }

        public void Tdelete(Contact t)
        {
            throw new NotImplementedException();
        }

        public List<Contact> TgetList()
        {
           return _contactDal.GetList();
        }

        public List<Contact> TgetListById(int id)
        {
            throw new NotImplementedException();
        }

        public void Tupdate(Contact t)
        {
            throw new NotImplementedException();
        }
    }
}
