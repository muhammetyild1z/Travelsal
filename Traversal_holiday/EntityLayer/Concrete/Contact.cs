using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
  public  class Contact

    {
        [Key]
        public int contactId { get; set; }
        public string contactDescription { get; set; }
        public string contactMail { get; set; }
        public string contactAdress { get; set; }
        public string contactPhone { get; set; }
        public string contactMapLocation { get; set; }
        public bool contactStatus { get; set; }
    }
}
