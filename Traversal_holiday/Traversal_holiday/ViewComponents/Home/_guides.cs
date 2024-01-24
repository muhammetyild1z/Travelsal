using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal_holiday.ViewComponents.Home
{
    public class _guides:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            GuideManager gm = new GuideManager(new efGuideRepository());
                var values = gm.TgetList().Take(4).ToList();
            return View(values);
        }
    }
}
