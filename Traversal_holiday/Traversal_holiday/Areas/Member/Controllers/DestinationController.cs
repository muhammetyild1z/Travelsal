using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace Traversal_holiday.Areas.Member.Controllers
{
    [Area("Member")]
  
    public class DestinationController : Controller
    {
        DestinationManager dm = new DestinationManager(new efDestinationRepository());

        public IActionResult Index(int page=1)
        {
            var values = dm.TgetList().ToPagedList(page,8);
            return View(values);
        }
    }
}
