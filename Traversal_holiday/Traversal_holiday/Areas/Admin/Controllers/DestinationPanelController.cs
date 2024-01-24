using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Traversal_holiday.Areas.Admin.Models;
using BusinessLayer.ValidationRules;
using FluentValidation.Results;
using System.Security.Claims;
using BusinessLayer.Abstract;

namespace Traversal_holiday.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class DestinationPanelController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        
       GuideManager gm = new GuideManager(new efGuideRepository());
         //private readonly UserManager<AppUser> _userManager;
        DestinationManager dm = new DestinationManager(new efDestinationRepository());
       // ReservationManager rm = new ReservationManager(new efResercationRepository());
        AdminPanelDestinationRules apdRules = new AdminPanelDestinationRules();

        public DestinationPanelController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
           
        }

        public  IActionResult Index()
        {
            var values =  dm.GetDestinationIncludeDestination();
            return View(values);
        }
        [HttpGet]
        public IActionResult destinationUp(int id)
        {
            var values = dm.TgetListById(id).FirstOrDefault();

            List<SelectListItem> value = (from x in gm.TgetList()
                                          select new SelectListItem
                                          {
                                              Text = x.guideName,
                                              Value = x.guideId.ToString()
                                          }).ToList();
            ViewBag.v = value;
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> destinationUp(Destination_update_list p, Destination d)
        {
            var values = dm.TgetListById(p.destinationId).FirstOrDefault();
            ValidationResult validationresult = apdRules.Validate(d);
            //dm.tupdate(p);
            if (p.CoverImage != null)
            {
                // p.imageUrl = values.ImagerUrl;
                var source = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.CoverImage.FileName);
                var imageName = Guid.NewGuid() + extension;
                var saveLocation = source + "/wwwroot/IFormFileImage/DestinationCoverImages/" + imageName;
                // System.IO.File.Delete(deleteImage);             
                var stream = new FileStream(saveLocation, FileMode.Create);
                await p.CoverImage.CopyToAsync(stream);
                values.CoverImage = imageName;
            }
            else if (p.destinationImage != null)
            {
                // p.imageUrl = values.ImagerUrl;
                var source = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.destinationImage.FileName);
                var imageName = Guid.NewGuid() + extension;
                var saveLocation = source + "/wwwroot/IFormFileImage/DestinationCoverImages/" + imageName;
                // System.IO.File.Delete(deleteImage);
                var stream = new FileStream(saveLocation, FileMode.Create);
                await p.destinationImage.CopyToAsync(stream);
                values.destinationImage = imageName;
            }
            else if (p.destinationImage2 != null)
            {
                // p.imageUrl = values.ImagerUrl;
                var source = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.destinationImage2.FileName);
                var imageName = Guid.NewGuid() + extension;
                var saveLocation = source + "/wwwroot/IFormFileImage/DestinationCoverImages/" + imageName;
                // System.IO.File.Delete(deleteImage);
                var stream = new FileStream(saveLocation, FileMode.Create);
                await p.destinationImage2.CopyToAsync(stream);
                values.destinationImage2 = imageName;
            }
            else
            values.destinationCapacity = p.destinationCapacity;
            values.destinationCity = p.destinationCity;
            values.destinationDate = p.destinationDate;
            values.destinationDayNight = p.destinationDayNight;
            values.destinationDescription = p.destinationDescription;
            values.destinationDetails1 = p.destinationDetails1;
            values.destinationDetails2 = p.destinationDetails2;
            values.destinationPrice = p.destinationPrice;
            values.destinationStatus = p.destinationStatus;
            values.guideId = p.guideId;
            values.destinationcreateDate = DateTime.Now;

            dm.Tupdate(values);
            ViewBag.success = 1;
        
            var id = values.destinationId;
            return RedirectToAction("destinationUp", new { id });
        }
        [HttpGet]
        public IActionResult AddDestination()
        {


            List<SelectListItem> value = (from x in gm.TgetList()
                                          select new SelectListItem
                                          {
                                              Text = x.guideName,
                                              Value = x.guideId.ToString()
                                          }).ToList();
            ViewBag.v = value;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddDestination(Destination p, Destination_update_list pd)
        {
            ValidationResult validationresult = apdRules.Validate(p);

            if (pd.CoverImage != null)
            {
                if (validationresult.IsValid)
                {
                    var source = Directory.GetCurrentDirectory();
                    var extension = Path.GetExtension(pd.CoverImage.FileName);
                    var imageName = Guid.NewGuid() + extension;
                    var saveLocation = source + "/wwwroot/IFormFileImage/DestinationCoverImages/" + imageName;
                    var stream = new FileStream(saveLocation, FileMode.Create);
                    await pd.CoverImage.CopyToAsync(stream);
                    p.CoverImage = imageName;
                }
                else
                {
                    foreach (var item in validationresult.Errors)
                    {
                        ModelState.AddModelError("", item.ErrorMessage);
                    }

                }
            }
            else if (pd.destinationImage != null)
            {
                if (validationresult.IsValid)
                {
                    var source = Directory.GetCurrentDirectory();
                    var extension = Path.GetExtension(pd.destinationImage.FileName);
                    var imageName = Guid.NewGuid() + extension;
                    var saveLocation = source + "/wwwroot/IFormFileImage/DestinationCoverImages/" + imageName;
                    var stream = new FileStream(saveLocation, FileMode.Create);
                    await pd.destinationImage.CopyToAsync(stream);
                    p.destinationImage = imageName;
                }
                else
                {
                    foreach (var item in validationresult.Errors)
                    {
                        ModelState.AddModelError("", item.ErrorMessage);
                    }
                    return View();
                }
            }
            else if (pd.destinationImage2 != null)
            {
                if (validationresult.IsValid)
                {
                    var source = Directory.GetCurrentDirectory();
                    var extension = Path.GetExtension(pd.destinationImage2.FileName);
                    var imageName = Guid.NewGuid() + extension;
                    var saveLocation = source + "/wwwroot/IFormFileImage/DestinationCoverImages/" + imageName;
                    var stream = new FileStream(saveLocation, FileMode.Create);
                    await pd.destinationImage2.CopyToAsync(stream);
                    p.destinationImage2 = imageName;
                }
                else
                {
                    foreach (var item in validationresult.Errors)
                    {
                        ModelState.AddModelError("", item.ErrorMessage);
                    }
                    return View();
                }
            }
            dm.Tadd(p);
            return RedirectToAction("Index");
        }

        public IActionResult destinationRemove(int id)
        {
            var value = dm.TgetList().Where(x => x.destinationId == id).FirstOrDefault();
            
            dm.Tdelete(value);
            return RedirectToAction("Index");
        } 
      


    }
}

