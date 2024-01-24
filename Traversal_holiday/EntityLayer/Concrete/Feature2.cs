using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
  public  class Feature2
    {
        [Key]
        public int featureId2 { get; set; }

        public string featurePostName2 { get; set; }

        public string featurePostDescription2 { get; set; }

        public string featurePostImage2 { get; set; }

        public bool featurePostStatus2 { get; set; }
    }
}
