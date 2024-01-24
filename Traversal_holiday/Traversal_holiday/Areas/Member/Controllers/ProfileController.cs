using BusinessLayer.Abstract;
using BusinessLayer.Concrate;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Traversal_holiday.Areas.Member.Models;

namespace Traversal_holiday.Areas.Member.Controllers
{
    
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class ProfileController : Controller
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly IAppUserService _appUserService;

        public ProfileController(UserManager<AppUser> userManager, IAppUserService appUserService)
        {
            _userManager = userManager;
            _appUserService = appUserService;
        }

        public async Task< IActionResult> Dasboard()
        {
            ReservationManager rm = new ReservationManager(new efResercationRepository());
            var activeUser = await _userManager.FindByIdAsync(User.Claims.Where(x=>x.Type==ClaimTypes.NameIdentifier).First().Value);
            ViewBag.user = activeUser;                    
            return View(activeUser);
        }

        [HttpGet]
        public async Task<IActionResult> Index(Profile p)
        {
            var values = await _userManager.FindByIdAsync(User.Claims.Where(x => x.Type == ClaimTypes.NameIdentifier).First().Value);
            Profile profil = new Profile();
            profil.Name = values.Name;
           // profil.imageUrl = values.ImagerUrl;
            profil.UserName = values.UserName;
            profil.PhoneNumber = values.PhoneNumber;
            profil.Email = values.Email;
            return View(profil);
        }

        [HttpPost]
        public async Task<IActionResult> Index(Profile p, AppUser appUser)
        {
           
            ProfileModelRules rmrules = new ProfileModelRules();
            ValidationResult validationResult = rmrules.Validate(appUser);
            
            var values = await _userManager.FindByIdAsync(User.Claims.Where(x => x.Type == ClaimTypes.NameIdentifier).First().Value);
            if (validationResult.IsValid && p.image != null)
            {
                // p.imageUrl = values.ImagerUrl;
                var source = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.image.FileName);
                var imageName = Guid.NewGuid() + extension;
                var saveLocation = source + "/wwwroot/IFormFileImage/Userimages/" + imageName;
                // System.IO.File.Delete(deleteImage);
                var stream = new FileStream(saveLocation, FileMode.Create);
                await p.image.CopyToAsync(stream);
                values.ImagerUrl = imageName;
            }
            else if (validationResult.IsValid&& p.image==null)
            {
            
                values.Email = p.Email;
                values.Name = p.Name;
                values.PhoneNumber = p.PhoneNumber;
                values.UserName = p.UserName;          
            }
            var result = await _userManager.UpdateAsync(values);

            if (result.Succeeded)
            {

                ViewBag.alert = 1;
                return View();
            }
           
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError("", item.ErrorMessage);
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult PasswordUpdate()
        {
            return View();
        }
        [HttpPost]
        public async Task< IActionResult> PasswordUpdate(UpdateDatabaseViewModel p)
        {
            
            var user = await _userManager.FindByIdAsync(User.Claims.Where(x => x.Type == ClaimTypes.NameIdentifier).First().Value);

          
            if (p.PasswordNew==p.PasswordNewR)
            {

              var  result  = await _userManager.ChangePasswordAsync(user, p.PasswordHash, p.PasswordNew);
                if (result.Succeeded)
                {
                    ViewBag.changePassword = 1;
                    
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("",item.Description);
                    }
                }
            }
            else
            {

                ModelState.AddModelError("","Onay şifresi yanlış girildi.");
            }
            
            return View();
        }
    }
}
