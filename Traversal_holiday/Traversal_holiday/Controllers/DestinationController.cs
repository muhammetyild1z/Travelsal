using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;
namespace Traversal_holiday.Controllers
{
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        
        DestinationManager dm = new DestinationManager(new efDestinationRepository());
        public IActionResult Index(int page=1)
        {
           
            var values = dm.TgetList().OrderByDescending(x=>x.destinationcreateDate).ToPagedList(page,9) ;
            return View(values);
        }

        public IActionResult Details(int id)
        {
            ViewBag.id = id;
            var values = dm.TgetListById(id).ToList();
            return View(values);
        }
    }
}
