using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TextbokBook.Business.Abstract;
using TextboxBook.Entity.Concrete;
using TextboxBook.UI.Identity;
using TextboxBook.UI.Models;

namespace TextboxBook.UI.ViewComponents
{
    public class CommentViewComponent:ViewComponent
    {
        private ICommentService _commentService;
        private UserManager<ApplicationUser> _userManager;

        public CommentViewComponent(ICommentService commentService, UserManager<ApplicationUser> userManager)
        {
            _commentService = commentService;
            _userManager = userManager;
        }

        public ViewViewComponentResult Invoke(int Id)
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = _userManager.GetUserAsync(HttpContext.User).Result;
                var model = new CommentAddViewModel()
                {
                    Comment = new Comment(),
                    CommentList = _commentService.GetByBookId(Id),
                    getCurrentUser = user.Id

                };
                model.Comment.BookId = Id;
                return View(model);
            }
            else
            {
                var model = new CommentAddViewModel()
                {
                    Comment = new Comment(),
                    CommentList = _commentService.GetByBookId(Id),

                };
                model.Comment.BookId = Id;
                return View(model);
            }


        }
    }
}
