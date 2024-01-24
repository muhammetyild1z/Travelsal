using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.ViewComponents.AdminDashboard
{
    public class _Cards1Statistic : ViewComponent
    {
        private readonly IDestinationService _destinationService;
        private readonly IAppUserService _appUserService;

        public _Cards1Statistic(IDestinationService destinationService, IAppUserService appUserService)
        {
            _destinationService = destinationService;
            _appUserService = appUserService;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = _destinationService.TgetList().Count;
            ViewBag.v2 = _appUserService.TgetList().Count;
            return View();
        }
    }
}
