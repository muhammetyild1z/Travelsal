using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
  public  class Feature
    {
        [Key]
        public int featureId { get; set; }
        public string featurePostName1 { get; set; }
        public string featurePostDescription1 { get; set; }
        public string featurePostImage1 { get; set; }
        public DateTime featurePostDate { get; set; }
        public string city { get; set; }

        public bool featurePostStatus1 { get; set; }
    }
}
