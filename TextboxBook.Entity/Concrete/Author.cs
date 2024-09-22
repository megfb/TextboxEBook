using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TextboxBook.Entity.Abstract;

namespace TextboxBook.Entity.Concrete
{
    public class Author : IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Author name cannot be empty")]

        public string Name { get; set; }
        [Required(ErrorMessage = "Birth date cannot be empty")]

        public int BirthDate { get; set; }
        [Required(ErrorMessage = "Biography cannot be empty")]

        public string Biography { get; set; }
        [Required(ErrorMessage = "Image cannot be empty")]

        public string AuthorImg { get; set; }
        public List<Book> Book { get; set; }
    }
}