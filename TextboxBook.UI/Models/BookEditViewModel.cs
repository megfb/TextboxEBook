using System.Collections.Generic;
using TextboxBook.Entity.Concrete;

namespace TextboxBook.UI.Models
{
    public class BookEditViewModel
    {

        public Book Book { get; set; }
        public List<Category> Categories { get; set; }
        public List<Author> Authors { get; set; }
        public List<Language> Languages { get; set; }
        public List<Publisher> Publishers { get; set; }
    }
}