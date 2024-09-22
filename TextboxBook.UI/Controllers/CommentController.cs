using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TextbokBook.Business.Abstract;
using TextboxBook.Entity.Concrete;
using TextboxBook.UI.Identity;

namespace TextboxBook.UI.Controllers
{

    [Authorize]
    public class CommentController : Controller
    {
        private ICommentService _commentService;
        private UserManager<ApplicationUser> _userManager;

        public CommentController(ICommentService commentService, UserManager<ApplicationUser> userManager)
        {
            _commentService = commentService;
            _userManager = userManager;
        }


        [HttpPost]
        public IActionResult Add(Comment comment)
        {
            var user = _userManager.GetUserAsync(HttpContext.User).Result;
            if (ModelState.IsValid)
            {
                comment.UserId = user.Id;
                comment.UserName = user.Name;
                _commentService.Add(comment);
            };

            return Redirect($"/book/detail/{comment.BookId}");
        }


        public ActionResult Delete(int Id, int bookId)
        {
            _commentService.Delete(Id);
            return Redirect($"/book/detail/{bookId}");
        }
    }
}
