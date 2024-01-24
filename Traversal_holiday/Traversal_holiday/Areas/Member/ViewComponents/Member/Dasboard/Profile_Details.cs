using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal_holiday.ViewComponents.Member
{
    public class Profile_Details:ViewComponent
    {
        
        public IViewComponentResult Invoke(AppUser user)
        {
          
            return View(user);
        }
    }
}
