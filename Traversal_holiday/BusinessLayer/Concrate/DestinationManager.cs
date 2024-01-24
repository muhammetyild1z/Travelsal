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
    public class DestinationManager : IDestinationService
    {
        IDestinationDal _DestinationDal;

        public DestinationManager(IDestinationDal destinationDal)
        {
            _DestinationDal = destinationDal;
        }

        public void Tadd(Destination t)
        {
            _DestinationDal.Insert(t);
        }

        public void Tdelete(Destination t)
        {
            _DestinationDal.Delete(t);
        }

        public List<Destination> TgetList()
        {
            return _DestinationDal.GetList();
        }

        public List<Destination> TgetListById(int id)
        {
           
             var a=   _DestinationDal.GetListAllById(x=>x.destinationId==id);
            return a;
        }

        public void Tupdate(Destination t)
        {
            _DestinationDal.Update(t);
        }
        public List<Destination> GetDestinationIncludeDestination()
        {
            return _DestinationDal.GetDestinationIncludeDestination();
        }

    }
}
