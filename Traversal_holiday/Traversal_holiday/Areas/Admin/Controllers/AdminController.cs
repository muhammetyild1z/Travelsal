using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Traversal_holiday.Areas.Admin.Models;

namespace Traversal_holiday.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class AdminController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        ReservationManager rm = new ReservationManager(new efResercationRepository());
        AppUserManager am = new AppUserManager(new efAppUserRepository());
        DestinationManager dm = new DestinationManager(new efDestinationRepository());

        public AdminController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public PartialViewResult Partial_appdemo()
        {
            return PartialView();
        }

        public async Task<PartialViewResult> Partial_user()
        {
            //user pp
            var user = await _userManager.FindByIdAsync(User.Claims.Where(x => x.Type == ClaimTypes.NameIdentifier).FirstOrDefault().Value);
            ViewBag.userImg = user.ImagerUrl;

            return PartialView();
        }

        public async Task<IActionResult> yonetilenTurlar()
        {

            var user = await _userManager.FindByIdAsync(User.Claims.Where(x => x.Type == ClaimTypes.NameIdentifier).FirstOrDefault().Value);
            var guideTravel = rm.GetReservationIncludeDestination().Where(x => x.AppUserId == user.Id).ToList();
            return View(guideTravel);
        }

        public async Task<IActionResult> Customer()
        {

            // var roles = _roleManager.Roles.ToList().FindAll(x => x.Id != 1).Select(x => x.Id).Last() ;
            var values = await _userManager.GetUsersInRoleAsync("Uye");
            return View(values);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {

            return View(am.TgetListById(id).FirstOrDefault());
        }
        [HttpPost]
        public async Task<IActionResult> Edit(AppUser p)
        {
            var user = await _userManager.FindByIdAsync(p.Id.ToString());
            user.PhoneNumber = p.PhoneNumber;
            user.SurName = p.SurName;
            user.Gender = p.Gender;
            user.Email = p.Email;

            var values = await _userManager.UpdateAsync(user);


            return View();
        }

        public async Task<IActionResult> Delete(int id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            var values = await _userManager.DeleteAsync(user);
            return RedirectToAction("Customer");
        }

        public IActionResult info(int id)
        {
            var values = am.TgetListById(id).FirstOrDefault();
            return View(values);  
        }
        [HttpGet]
        public async Task< IActionResult> Authority()
        {

            var values = await _userManager.GetUsersInRoleAsync("Rehber");
            ////ViewBag.rol = _roleManager.Roles.ToList().Select(x=>x.Id); 
            
            return View(values);
        }

        [HttpPost]
        public IActionResult Authority(int id,AppUser p , string a ,AppRole pa)
        {
           
            return View();
        }
        //[HttpGet]
        //public async Task<IActionResult> RolesUp(int id)
        //{
        //    var user = await _userManager.FindByIdAsync(id.ToString());


        //    var values = await _userManager.AddToRoleAsync(user, "admin");

        //    return View(user);
        //}
        //[HttpPost]
        //public IActionResult RolesUp(int id, AppRole p, string a)
        //{

        //    return View();

        //    //var values = await _userManager.AddToRoleAsync(user, "admin");

        //}
    }
}

