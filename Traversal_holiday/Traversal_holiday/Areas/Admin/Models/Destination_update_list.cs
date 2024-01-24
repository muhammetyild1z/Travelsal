using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal_holiday.Areas.Admin.Models
{
    public class Destination_update_list
    {
        [Key]
        public int destinationId { get; set; }

        public string destinationCity { get; set; }

        public string destinationDayNight { get; set; }

        public double destinationPrice { get; set; }

      

        public string destinationDescription { get; set; }

        public bool destinationStatus { get; set; }

        public int destinationCapacity { get; set; }

        public DateTime destinationDate { get; set; }

        public DateTime destinationcreateDate { get; set; }

        public IFormFile destinationImage { get; set; }
        public IFormFile destinationImage2 { get; set; }
        public IFormFile CoverImage { get; set; }

        public string destinationDetails1 { get; set; }
        public string destinationDetails2 { get; set; }
        
        public int guideId { get; set; }
    }
}
