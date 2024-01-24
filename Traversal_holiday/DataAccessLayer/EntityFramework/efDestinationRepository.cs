﻿using DataAccessLayer.Abstract;
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
    public class efDestinationRepository : GenericRepository<Destination>, IDestinationDal
    {
        public List<Destination> GetDestinationIncludeDestination()
        {
            Context c = new Context();
            return c.Destinations.Include(x => x.Guide).ToList();
        }

       
    }
}
