using System.Collections.Generic;
using TextboxBook.Entity.Concrete;
using TextboxBook.UI.Identity;

namespace TextboxBook.UI.Models
{
    public class MyProfileViewModel
    {
     
        public ApplicationUser User { get; set; }
        public List<Country> Countrys { get; set; }
        public List<Gender> Genders { get; set; }
    }
}