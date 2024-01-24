using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traversal_holiday.Models;
using X.PagedList;

namespace Traversal_holiday.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Search(SearchModelView p,int page=1)
        {
            DestinationManager dm = new DestinationManager(new efDestinationRepository());

            var values = dm.TgetList().Where(x => x.destinationcreateDate >= p.destinationcreateDateStart)
               .Where(x => x.destinationcreateDate <= p.destinationcreateDateFinish)
                .Where(x=>x.destinationCity==p.destinationCity).ToPagedList(page,9);
            return View(values);
        }
        public IActionResult About()
        {
            AboutManager aboutManager = new AboutManager(new efAboutRepository());
            var values = aboutManager.TgetById(1);
            return View(values);
        }

        public IActionResult Contact()
        {
            ContactManager cm = new ContactManager(new efContactRepository());
            var values = cm.TgetList();
            return View(values);
        }
    }
}
