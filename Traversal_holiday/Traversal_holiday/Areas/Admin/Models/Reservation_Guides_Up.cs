using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using System;

namespace Traversal_holiday.Areas.Admin.Models
{
    public class Reservation_Guides_Up
    {
        public int rezervasyonId { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public string rezCount { get; set; }
        public DateTime rezDate { get; set; }
        public string rezStatus { get; set; }
        public string Description { get; set; }
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
    }
}
