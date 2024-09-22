using System.Collections.Generic;
using TextboxBook.Entity.Concrete;
using TextboxBook.UI.Identity;

namespace TextboxBook.UI.Models
{
    public class UserEditViewModel
    {


        public ApplicationUser GetUser { get; set; }
        public List<Country> Country { get; internal set; }
        public List<Gender> Gender { get; internal set; }
        public List<ApplicationRole> Roles { get; internal set; }
        public List<string> Role { get; set; }
        public IList<string> UserRoles { get; internal set; }
    }
}