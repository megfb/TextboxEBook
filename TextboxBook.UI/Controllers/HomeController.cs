using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TextbokBook.Business.Abstract;
using TextboxBook.UI.Models;

namespace TextboxBook.UI.Controllers
{
    public class HomeController : Controller
    {

        private IBookService _bookService;
        public HomeController(IBookService bookService)
        {
            _bookService = bookService;
        }
        public IActionResult Index()
        {
            var model = new BookListViewModel()
            {
                Book = _bookService.GetAllWithDetails().TakeLast(4).ToList()
            };

            return View(model);
        }
    }
}
