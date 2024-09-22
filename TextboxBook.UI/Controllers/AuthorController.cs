using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TextbokBook.Business.Abstract;
using TextboxBook.Dal.Abstract;
using TextboxBook.UI.Models;

namespace TextboxBook.UI.Controllers
{
    public class AuthorController : Controller
    {
        private IAuthorService _authorService;

        public AuthorController( IAuthorService authorService)
        {
            _authorService = authorService;
        }
        public IActionResult List()
        {
            var model = new AuthorListViewModel()
            {
                Authors = _authorService.GetAll(),
            };
            return View(model);
        }
        public IActionResult Detail(int id)
        {
            var model = new AuthorViewModel()
            {
                Author = _authorService.GetById(id),
            };

            return View(model);
        }
    }
}
