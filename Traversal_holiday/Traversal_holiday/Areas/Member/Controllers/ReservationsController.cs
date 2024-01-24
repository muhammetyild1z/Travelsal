using BusinessLayer.Concrate;
using EntityLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Traversal_holiday.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]

    public class ReservationsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        

        DestinationManager dm = new DestinationManager(new efDestinationRepository());
        ReservationManager rm = new ReservationManager(new efResercationRepository());

        public ReservationsController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        
        //Aktif rezervasyon
        public async Task< IActionResult> MyCurrentReservation()
        {
             var user = await _userManager.FindByIdAsync(User.Claims.Where(x => x.Type == ClaimTypes.NameIdentifier).First().Value);
            var values = rm.GetReservationIncludeDestination().Where(x=>x.AppUserId==user.Id).Where(x=>x.Destination.destinationDate >= DateTime.Now).OrderByDescending(x=>x.Destination.destinationDate).ToList();
            
            return View(values); 
        }
        //eski rezervasonlar
        public async Task< IActionResult> MyOldReservation()
        {
            var user = await _userManager.FindByIdAsync(User.Claims.Where(x => x.Type == ClaimTypes.NameIdentifier).First().Value);
            var values = rm.GetReservationIncludeDestination().Where(x => x.AppUserId == Convert.ToInt32(user.Id)).Where(x=>x.Destination.destinationDate < DateTime.Now).ToList();
           
            
            
            return View(values);
        }

        [HttpGet]
        public IActionResult NewReservation()
        {
            List<SelectListItem> values = (from x in dm.TgetList().Where(x=>x.destinationDate > DateTime.Now)
                                           select new SelectListItem
                                           {
                                               Text = x.destinationCity,
                                               Value = x.destinationId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            ViewBag.ok = 1;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> NewReservation(Reservation p)
        {
            var user = await _userManager.FindByIdAsync(User.Claims.Where(x => x.Type == ClaimTypes.NameIdentifier).First().Value);
            p.AppUserId = Convert.ToInt32(user.Id);
            p.rezStatus = "Onay bekliyor";
            p.rezDate = DateTime.Now;
            rm.Tadd(p);

            return RedirectToAction("MyCurrentReservation");
        }


    }
}
