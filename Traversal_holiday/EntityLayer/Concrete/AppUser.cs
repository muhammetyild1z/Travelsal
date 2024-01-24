using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
  public  class AppUser:IdentityUser<int>
    {
        public string ImagerUrl { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Gender { get; set; }
        public DateTime CrateDate { get; set; }
        public List<Reservation> Reservation { get; set; }
    }
}
