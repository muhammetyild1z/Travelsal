using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Traversal_holiday.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class ReservationController : Controller
    {
        ReservationManager rm = new ReservationManager(new efResercationRepository());
        public IActionResult Rezervation()
        {
            
            var values = rm.GetReservationIncludeDestination();
            return View(values);
        }
        public IActionResult Delete(int id)
        {
            var remove = rm.TgetList().Where(x => x.rezervasyonId == id).FirstOrDefault();
            rm.Tdelete(remove);        
            return RedirectToAction("Rezervation");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var values = rm.GetReservationIncludeDestination().Where(x => x.rezervasyonId == id).FirstOrDefault() ;
            return View(values);
        }
        [HttpPost]
        public IActionResult Edit(int id,Reservation p)
        {
            var values = rm.GetReservationIncludeDestination().Where(x => x.rezervasyonId == id).FirstOrDefault();
            values.rezStatus = p.rezStatus;
            values.AppUserId = p.AppUserId;
            values.destinationId = p.destinationId;
            values.rezCount = p.rezCount;
            values.Description = p.Description;
            rm.Tupdate(values);
            return RedirectToAction("Rezervation");
        }
        public IActionResult Info(int id)
        {
            var values = rm.GetReservationIncludeDestination().Where(x => x.rezervasyonId == id).FirstOrDefault();
            return View(values);
        }
    }
}
