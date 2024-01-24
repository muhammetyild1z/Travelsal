using BusinessLayer.Concrate;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal_holiday.Areas.Member.ViewComponents.Member.Dasboard
{
    public class Profile_Guides:ViewComponent
    {
        public IViewComponentResult Invoke(AppUser user)
        {
           // birden fazla değer ile taboda arama yapılması gerekiyor 
           //giriş yapan kullanıcı id ile rezervasonları bulunur
           //rezervasyon tablosundan destination id alınarak destination tablosunda aranır 
           //çıkan sonuçlara göre guide id döndürülür
            GuideManager gm = new GuideManager(new efGuideRepository());
            ReservationManager rm = new ReservationManager(new efResercationRepository());
            DestinationManager dm = new DestinationManager(new efDestinationRepository());
            var reservation = rm.TgetListById(user.Id).Select(x=>x.destinationId).LastOrDefault();         
            var destination = dm.TgetListById(reservation).Select(x => x.guideId).FirstOrDefault();
            var guide = gm.TgetListById(destination);                                        
            return View(guide);
            
        }
    }
}
