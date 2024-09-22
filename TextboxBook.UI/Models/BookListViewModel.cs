using System.Collections.Generic;
using TextboxBook.Entity.Concrete;

namespace TextboxBook.UI.Models
{
    public class BookListViewModel
    {
        public List<Book> Book { get; internal set; }
        public int CurrentCategory { get; internal set; }
        public int PageCount { get; internal set; }
        public int PageSize { get; internal set; }
        public int CurrentPage { get; internal set; }

    }
}