using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal_holiday.Controllers
{
    [AllowAnonymous]
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new efCommentRepository());
        [HttpGet]
        public IActionResult AddComment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddComment(Comment p,int id)
        {
            
            p.destinationId = id;
            cm.Tadd(p);
            return RedirectToAction("Details","Destination",new { id});
        }
    }
}
