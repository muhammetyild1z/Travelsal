using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Traversal_holiday.Areas.Member.Controllers
{
    [AllowAnonymous]
    [Area("Member")]
    public class CommentController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public CommentController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var userId = await _userManager.FindByIdAsync(User.Claims.Where(x=>x.Type==ClaimTypes.NameIdentifier).First().Value);  


            return View();
    }
}
}
