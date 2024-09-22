using System;
using System.Collections.Generic;
using TextboxBook.Entity.Concrete;

namespace TextboxBook.UI.Models
{
    public class BookAddViewModel
    {
        public Book Book { get; set; }
        public List<Category> Categories { get; internal set; }
        public List<Author> Authors { get; internal set; }
        public List<Language> Languages { get; internal set; }
        public List<Publisher> Publishers { get; internal set; }
    }
}