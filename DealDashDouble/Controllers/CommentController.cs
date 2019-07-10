using DealDashDouble.Models;
using DealDashDouble.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DealDashDouble.Controllers
{
    public class CommentController : Controller
    {
        CommentServices services = new CommentServices();

        // GET: Comment

         [HttpPost]
        public JsonResult LeaveComment(CommentViewModel model)
        {
            JsonResult result = new JsonResult();

            var comment = new tbl_Comment();

            comment.Text = model.Text;

            comment.Rating = model.Rating;

            comment.EntityID = model.EntityID;

            comment.RecordID = model.RecordID;

            comment.UserID = User.Identity.GetUserId();

            comment.TimpStamp = DateTime.Now;

            var res = services.LeaveComment(comment);


            result.Data = new { Success = res };






            //try
            //{
            //    var comment = new tbl_Comment();

            //    comment.Text = model.Text;

            //    comment.EntityID = model.EntityID;

            //    comment.RecordID = model.RecordID;

            //    comment.UserID = User.Identity.GetUserId();

            //    comment.TimpStamp = DateTime.Now;

            //    var res = services.LeaveComment(comment);


            //    result.Data = new { Success = res };

            //}
            //catch (Exception ex)
            //{

            //    result.Data = new { Success = false, Massage = ex.Message };
            //}

            return result;
        }
    }
}