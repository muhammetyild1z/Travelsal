using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal_holiday.ViewComponents.Home
{
    public class _subAbout:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            SubAboutManager sm = new SubAboutManager(new efSubAboutRepository());
            var values = sm.TgetList();
            return View(values);
        }
    }
}
