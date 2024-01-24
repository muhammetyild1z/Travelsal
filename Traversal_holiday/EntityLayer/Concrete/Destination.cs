using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Destination
    {
        [Key]
        public int destinationId { get; set; }

        public string destinationCity { get; set; }

        public string destinationDayNight { get; set; }

        public double destinationPrice { get; set; }

        public string destinationImage { get; set; }

        public string destinationDescription { get; set; }

        public bool  destinationStatus { get; set; }

        public int destinationCapacity { get; set; }

        public DateTime destinationDate { get; set; }

        public DateTime destinationcreateDate { get; set; }

        public string CoverImage { get; set; }
        public string destinationDetails1 { get; set; }
        public string destinationDetails2 { get; set; }
        public string destinationImage2 { get; set; }

        public List<Comment> Comments { get; set; }
        public List<Reservation> Reservations { get; set; }

       public int guideId { get; set; }
       public Guide Guide { get; set; }

      //public int  rezervasyonId { get; set; }





    }
}
