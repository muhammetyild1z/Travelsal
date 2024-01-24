using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal_holiday.ViewComponents.Member
{
    public class Platform_settings:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
