using System.Collections.Generic;
using TextboxBook.Entity.Concrete;

namespace TextboxBook.UI.Models
{
    public class CategoryListViewModel
    {

        public List<Category> categoryList { get; set; }
        public int currentCategory { get; set; }
    }
}