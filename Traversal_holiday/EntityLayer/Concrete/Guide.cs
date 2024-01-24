using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Guide
    {
        [Key]
        public int guideId { get; set; }
        public string guideName { get; set; }
        public string guideDescription { get; set; }
        public string guideImage { get; set; }
        public string guideTwitter { get; set; }
        public string guideInstgram { get; set; }
        public bool guideStatus { get; set; }
     
        public List<Destination> Destinations { get; set; }
    }
}
