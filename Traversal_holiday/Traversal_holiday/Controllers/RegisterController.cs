using BusinessLayer.Abstract;
using BusinessLayer.Concrate;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traversal_holiday.Models;

namespace Traversal_holiday.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IAppUserService _appUserService;

        public RegisterController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, IAppUserService appUserService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _appUserService = appUserService;
        }

        [HttpGet]
        public IActionResult SingnUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SingnUp(ModelRegisterView p, AppUser appUser)
        {
            

            RegisterModelRules rmr = new RegisterModelRules();
                    ValidationResult resultValidation = rmr.Validate(appUser);
            if (resultValidation.IsValid)
            {
                var mailcheck = _appUserService.TgetList().Where(x => x.Email == p.Email).Count();
                var usercheck = _appUserService.TgetList().Where(x => x.UserName == p.UserName).Count();
                if (p.PasswordHash == p.PasswordR 
                    && mailcheck <= 0 
                    && usercheck <= 0 )
                {
                    AppUser appuser = new AppUser()
                    {
                        ImagerUrl = "user.png",
                        Email = p.Email,
                        Name = p.Name,
                        UserName = p.UserName,
                        PhoneNumber = p.PhoneNumber,
                        CrateDate = DateTime.Now
                       
                    };
                    var result = await _userManager.CreateAsync(appuser, p.PasswordHash);
                    if (result.Succeeded)
                    {
                        var role = await _userManager.AddToRoleAsync(appuser,"Uye");
                        if (role.Succeeded)
                        {
                            return RedirectToAction("Login", "Account");
                        }
                        else
                        {
                            foreach (var item in role.Errors)
                            {
                                ModelState.AddModelError("",item.Description);
                            }
                        }
                        
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }
                }
                else if (mailcheck ==1)
                {
                    ViewBag.mailBad = "Bu mail adresi daha önce kayıt edilmiş.";
                }
                else if (usercheck==1)
                {
                    ViewBag.userBad = "Bu Kullanıcı adı  daha önce alınmış.";
                }
               
              
            }
            else
            {
                // @Html.ValidationSummary()  go to html
                foreach (var item in resultValidation.Errors)
                {
                    ModelState.AddModelError("", item.ErrorMessage);
                }
               
            }
            return View(p);

        }
    }
}
