using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About2
    {
        [Key]
        public int aboutId2 { get; set; }

        public string aboutDescription { get; set; }

       

        public string aboutTitle { get; set; }
        public string aboutTitle2 { get; set; }

        

        public string aboutImage { get; set; }

      
    }
}
