using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal_holiday.Models
{
    public class ModelRegisterView
    {
      //  [Required(ErrorMessage ="Ad alanı boş geçilemez")]
        public string Name { get; set; }
      //  [Required(ErrorMessage = "Soyad alanı boş geçilemez")]
        public string UserName { get; set; }
      //  [Required(ErrorMessage = "Telefon alanı boş geçilemez")]
        public string PhoneNumber { get; set; }
      //  [Required(ErrorMessage = "Mail alanı boş geçilemez")]
        public string Email { get; set; }
       // [Required(ErrorMessage = "Password alanı boş geçilemez")]
        public string PasswordR { get; set; }
      //  [Required(ErrorMessage = "Onay password alanı boş geçilemez")]
        public string PasswordHash { get; set; }
    }
}
