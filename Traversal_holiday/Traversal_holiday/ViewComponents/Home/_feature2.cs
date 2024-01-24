using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal_holiday.ViewComponents.Home
{
    public class _feature2:ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            DestinationManager fm = new DestinationManager(new efDestinationRepository());
            
            var values = fm.TgetList().OrderByDescending(x => x.destinationcreateDate).Take(5).Reverse().Take(4).ToList();
           
            return View(values);
            
        }
    }
}
