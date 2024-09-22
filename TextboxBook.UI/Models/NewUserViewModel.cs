using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TextboxBook.Entity.Concrete;
using TextboxBook.UI.Identity;

namespace TextboxBook.UI.Models
{
    public class NewUserViewModel
    {

        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public int GenderId { get; set; }
        [Required]
        public int CountryId { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string EMail { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public List<Country> Country { get; set; }
        public List<ApplicationRole> Roles { get; set; }
        public List<string> Role { get; set; }
        public List<Gender> Gender { get; set; }
    }
}