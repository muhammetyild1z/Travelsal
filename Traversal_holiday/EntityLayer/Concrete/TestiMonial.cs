using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class TestiMonial
    {
        [Key]
        public int testiMonialId { get; set; }

        public string testiMonialClient { get; set; }

        public string testiMonialComment { get; set; }

        public string testiMonialClientImage { get; set; }

        public bool testiMonialStatus { get; set; }

    }
}
