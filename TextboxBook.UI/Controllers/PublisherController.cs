using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TextbokBook.Business.Abstract;
using TextboxBook.UI.Models;

namespace TextboxBook.UI.Controllers
{
    public class PublisherController : Controller
    {

        private IPublisherService _publisherService;

        public PublisherController(IPublisherService publisherService)
        {
            _publisherService = publisherService;
        }

        public IActionResult List()
        {

            var model = new PublisherListViewModel()
            {
                Publisher = _publisherService.GetAll()
            };

            return View(model);
        }
        public IActionResult Detail(int Id)
        {

            var model = new PublisherDetailViewModel()
            {
                Publisher = _publisherService.GetById(Id)
            };

            return View(model);
        }
    }
}
