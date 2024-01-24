using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal_holiday.ViewComponents.Destination
{
    public class DestinationDetailsCommentList:ViewComponent
    {
        CommentManager dm = new CommentManager(new efCommentRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = dm.TgetListById(id);
            ViewBag.commentCount = dm.TgetListById(id).Count();
            return View(values);
        }
    }
}
