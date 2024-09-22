using System.Linq;
using TextboxBook.UI.Identity;

namespace TextboxBook.UI.Models
{
    public class UserListViewModel
    {
        public IQueryable<ApplicationUser> UsersList { get; internal set; }
    }
}