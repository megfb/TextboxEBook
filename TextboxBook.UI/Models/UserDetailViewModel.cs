using System.Collections.Generic;
using TextboxBook.UI.Identity;

namespace TextboxBook.UI.Models
{
    public class UserDetailViewModel
    {

        public ApplicationUser User { get; set; }
        public IList<string> Roles { get; internal set; }
    }
}