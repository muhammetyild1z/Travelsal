using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class efResercationRepository:GenericRepository<Reservation>,IReservationDal
    {
        Context c = new Context();
        public List<Reservation> GetListAllByIdInclude()
        {
            return c.Reservations.Include(x => x.Destination).Include(x => x.AppUser).ToList();
        }

        public List<Reservation> GetReservationIncludeDestination()
        {
            
            return c.Reservations.Include(x => x.Destination).Include(x=>x.AppUser).ToList();
        }

        
    }
}
