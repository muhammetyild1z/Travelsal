using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal_holiday.ViewComponents.Destination
{
    public class DestinationDetailsGuideComment:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
