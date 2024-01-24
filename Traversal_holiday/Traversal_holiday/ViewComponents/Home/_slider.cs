using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal_holiday.ViewComponents.Home
{
    public class _slider:ViewComponent
    {
        DestinationManager dm = new DestinationManager(new efDestinationRepository());
        public IViewComponentResult Invoke()
        {
            var values = dm.TgetList();
            return View(values);
        }
    }
}
