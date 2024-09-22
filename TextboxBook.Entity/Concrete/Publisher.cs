using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TextboxBook.Entity.Abstract;

namespace TextboxBook.Entity.Concrete
{
    public class Publisher : IEntity
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Publisher name cannot be empty")]

        public string Name { get; set; }
        public List<Book> Book { get; set; }

    }
}