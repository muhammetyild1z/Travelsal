using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Traversal_holiday.Areas.Member.Models;

namespace Traversal_holiday.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProfilePanelController : Controller
    {

        private readonly UserManager<AppUser> _usermanager;

        public ProfilePanelController(UserManager<AppUser> usermanager)
        {
            _usermanager = usermanager;
        }

        [HttpGet]
        public async Task< IActionResult>profileUp(Profile p)
        {
            var values = await _usermanager.FindByIdAsync(User.Claims.Where(x => x.Type == ClaimTypes.NameIdentifier).First().Value);

            p.Name = values.Name;
            p.UserName = values.UserName;
            p.Email = values.Email  ;
            p.PhoneNumber = values.PhoneNumber;
           // p.imageUrl = values.imageUrl;
            return View(p);
        }
        [HttpPost]
        public async Task<IActionResult> profileUp(Profile p, AppUser appUser)
        {
            var values = await _usermanager.FindByIdAsync(User.Claims.Where(x => x.Type == ClaimTypes.NameIdentifier).First().Value);
            
            if (/*validationResult.IsValid &&*/ p.image != null)
            {
                var source = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.image.FileName);
                var imageName = Guid.NewGuid() + extension;
                var saveLocation = source + "/wwwroot/IFormFileImage/Userimages/" + imageName;
                // System.IO.File.Delete(deleteImage);
                var stream = new FileStream(saveLocation, FileMode.Create);
                await p.image.CopyToAsync(stream);
                values.ImagerUrl = imageName;
            }
            else if (/*validationResult.IsValid &&*/ p.image == null)
            {
                values.Name = p.Name;
                values.UserName = p.UserName;
                values.Email = p.Email;
                values.PhoneNumber = p.PhoneNumber;

            }
            var result = await _usermanager.UpdateAsync(values);

            if (result.Succeeded)
            {

                ViewBag.alert = 1;
                return View();
            }
            return View();
        }
        [HttpGet]
        public  IActionResult passwordUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> passwordUp(UpdateDatabaseViewModel p)
        {
            var user = await _usermanager.FindByIdAsync(User.Claims.Where(x => x.Type == ClaimTypes.NameIdentifier).First().Value);
            if (p.PasswordNew==p.PasswordNewR)
            {
                var result = await _usermanager.ChangePasswordAsync(user, p.PasswordHash, p.PasswordNew);
                if (result.Succeeded)
                {
                    ViewBag.changePassword = 1;
                    return View();
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            else
            {

                ModelState.AddModelError("", "Onay şifresi yanlış girildi.");
            }
            return View();

        }
    }
}
