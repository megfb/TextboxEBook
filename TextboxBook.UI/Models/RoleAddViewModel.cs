using System.ComponentModel.DataAnnotations;

namespace TextboxBook.UI.Models
{
    public class RoleAddViewModel
    {
        [Required(ErrorMessage = "Role Name can't be null")]
        public string RoleName { get; set; }
    }
}