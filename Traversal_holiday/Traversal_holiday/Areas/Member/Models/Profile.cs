using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal_holiday.Areas.Member.Models
{
    public class Profile
    {
        public string Name { get; set; }
        public string UserName { get; set; }       
        public string PasswordHash { get; set; }
        public string PasswordR { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string imageUrl { get; set; }
        public IFormFile image { get; set; }
    }
}
