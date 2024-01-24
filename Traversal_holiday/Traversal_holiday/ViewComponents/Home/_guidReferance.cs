using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal_holiday.ViewComponents
{
    public class _guidReferance:ViewComponent
    {
        public IViewComponentResult Invoke(int id , DateTime destId)
        {
            GuideManager gm = new GuideManager(new efGuideRepository());
            DestinationManager dm = new DestinationManager(new efDestinationRepository());
            
            var values = gm.TgetList().Where(x => x.guideId == id).ToList();
            ViewBag.createtur = destId.ToString("dd-MMM-yyyy");


            return View(values);
        }
    }
}
