using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TextboxBook.Entity.Concrete;

namespace TextboxBook.UI.Identity
{
    public class ApplicationUser:IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public int GenderId { get; set; }
        public Country Country { get; set; }
        public int CountryId { get; set; }
    }
}
