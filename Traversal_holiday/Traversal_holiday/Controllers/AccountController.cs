 using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Traversal_holiday.Models;

namespace Traversal_holiday.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        private readonly RoleManager<AppRole> _signInRole;

        public AccountController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager, RoleManager<AppRole> signInRole)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _signInRole = signInRole;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserSignInViewModel p, AppUser appuser)
        {

            LoginModelRules lmrules = new LoginModelRules();
            ValidationResult Validationresult = lmrules.Validate(appuser);
            if (Validationresult.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.UserName, p.PasswordHash,/*şifreyi hatırlasın mı?*/true, true/*5 yanlıştan sonra kitlesin mi hesabı*/);
                
                if (result.Succeeded)
                {
                    var user = await _userManager.FindByNameAsync(p.UserName);                
                   var roles = await _userManager.GetRolesAsync(user);
                    if (roles.Contains("Admin") || roles.Contains("Rehber"))
                    {
                       // Isıntrole == yazarak view tarafında rehbere başlık kapatabilirsin
                       //rehber url admin yetkili sayfayı yaıznca gidebilyor mu
                        return RedirectToAction("Index", "DestinationPanel", new { area = "Admin" });
                    }
                    else if (roles.Contains("Uye"))
                    {
                        return RedirectToAction("Dasboard", "Profile", new { area = "Member" });
                    }

                }
                else if (result.IsLockedOut)
                {
                    //hesap 5 yanlış denemeden sonra kitlendi mi                  
                    // ModelState.AddModelError("", (result.RequiresTwoFactor ? "" : "5 dakika sonra tekrar deneyin."));
                    ModelState.AddModelError("","Çok fazla hatalı giriş yaptınız 5 dakika sonra tekrar deneyin.");
                }
                else if (result.IsNotAllowed)
                {
                    //hesap mail veya tel onaylandı mı
                }
                else
                {
                    ModelState.AddModelError("", "Kullanıcı adı veya şifre yanlış girildi..");
                }
            }
          
            //else
            //{
            //    foreach (var item in Validationresult.Errors)
            //    {
            //        ModelState.AddModelError("", item.ErrorMessage);
            //    }
            //}

            return View(p);
        }

        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }


    }
}
