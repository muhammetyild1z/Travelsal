using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class About
    {
        [Key]
        public int aboutId { get; set; }

        public string aboutDescription { get; set; }

        public string aboutDescription2 { get; set; }

        public string aboutTitle { get; set; }

        public string aboutTitle2 { get; set; }

        public string aboutImage { get; set; }

        public bool aboutStatus { get; set; }
    }
}
