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
    public class ReservationManager : IReservationService
    {
        IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public void Tadd(Reservation t)
        {
            _reservationDal.Insert(t);
        }

        public void Tdelete(Reservation t)
        {
            _reservationDal.Delete(t);
        }

        public List<Reservation> TgetList()
        {
            return _reservationDal.GetList();
        }

        public List<Reservation> TgetListById(int id)
        {
            return _reservationDal.GetListAllById(x=>x.AppUserId==id);
        }
        public List<Reservation> TgetListByIdInclude(int id)
        {
            return _reservationDal.GetListAllByIdInclude(x => x.rezervasyonId == id);
        }

        public void Tupdate(Reservation t)
        {
            _reservationDal.Update(t);
        }
         
        public List<Reservation> GetReservationIncludeDestination()
        {
            return _reservationDal.GetReservationIncludeDestination();
        }
    }
}
