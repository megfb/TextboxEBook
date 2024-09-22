using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TextbokBook.Business.Abstract;
using TextboxBook.UI.Models;

namespace TextboxBook.UI.Controllers
{
    public class BookController : Controller
    {

        private IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public IActionResult listBook(int page = 1, int Category = 0)
        {
            int pageSize = 10;
            var books = _bookService.GetByCategory(Category);

            var model = new BookListViewModel()
            {
                Book = books.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                PageCount = (int)Math.Ceiling(books.Count / (double)pageSize),
                PageSize = pageSize,
                CurrentCategory = Category,
                CurrentPage = page,
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult Detail(int Id)
        {

            var model = new BookViewModel()
            {
                Book = _bookService.GetById(Id)
            };

            return View(model);
        }
    }
}
