using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal_holiday.ViewComponents.Home
{
    public class _testimonial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            TestimonialManager tm = new TestimonialManager(new efTestiMonialRepository());
            var values = tm.TgetList();
            return View(values);
        }
    }
}
