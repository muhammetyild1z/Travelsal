using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal_holiday.Areas.Admin.ViewComponents.Admin_dashboard
{
    public class Admin_dashboard:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
