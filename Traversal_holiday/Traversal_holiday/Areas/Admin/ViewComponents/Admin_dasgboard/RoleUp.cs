using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace Traversal_holiday.Areas.Admin.ViewComponents.Admin_dasgboard
{
    public class RoleUp:ViewComponent
    {
       
        private readonly RoleManager<AppRole> _roleManager;

        public RoleUp(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IViewComponentResult Invoke()
        {
            List<SelectListItem> RolesV = (from x in _roleManager.Roles.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.Id.ToString()

                                           }).ToList();
            ViewBag.cv = RolesV;
            // var values = await _userManager.GetUsersInRoleAsync("Rehber");
            //ViewBag.rol = _roleManager.Roles.ToList().Select(x=>x.Id); 
            return View();
        }
    }
}
