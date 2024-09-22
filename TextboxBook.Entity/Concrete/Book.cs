using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TextboxBook.Entity.Abstract;

namespace TextboxBook.Entity.Concrete
{
    public class Book:IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Book name cannot be empty")]

        public string Name { get; set; }
        
        public decimal UnitPrice { get; set; }
        [Required(ErrorMessage = "Image cannot be empty")]
        public string BookImg { get; set; }
        [Required(ErrorMessage = "Description cannot be empty")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Production date cannot be empty")]
        public int ProductionDate { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }
        public Publisher Publisher { get; set; }
        public int PublisherId { get; set; }
        public Language Language{ get; set; }
        public int LanguageId { get; set; }
    }
}
