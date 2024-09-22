using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TextbokBook.Business.Abstract;
using TextboxBook.UI.Models;

namespace TextboxBook.UI.ViewComponents
{
    public class CategoryListViewComponent:ViewComponent
    {
        private ICategoryService _categoryService;
        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public ViewViewComponentResult Invoke()
        {
            var model = new CategoryListViewModel()
            {
                categoryList = _categoryService.GetAll(),
                currentCategory = Convert.ToInt32(HttpContext.Request.Query["Category"])
            };
            return View(model);
        }
    }
}
