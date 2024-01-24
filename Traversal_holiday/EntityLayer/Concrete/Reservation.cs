using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Reservation
    {
        [Key]
        public int rezervasyonId { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public string rezCount { get; set; }
        public DateTime rezDate { get; set; }
        public string rezStatus { get; set; }     
        public string Description { get; set; }
         public int destinationId { get; set; }
       

        public Destination Destination { get; set; }



    }
}
