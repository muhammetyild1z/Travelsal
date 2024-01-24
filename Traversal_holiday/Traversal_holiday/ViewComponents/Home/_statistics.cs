using BusinessLayer.Concrate;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal_holiday.ViewComponents.Home
{
     public class _statistics:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();

            ViewBag.guidesCount = c.Guides.Count();
            ViewBag.DestinastionCount = c.Destinations.Count();

            return View();
        }
    }
}
