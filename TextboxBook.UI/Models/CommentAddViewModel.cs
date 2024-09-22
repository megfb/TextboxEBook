using System.Collections.Generic;
using TextboxBook.Entity.Concrete;

namespace TextboxBook.UI.Models
{
    public class CommentAddViewModel
    {
   

        public Comment Comment { get; set; }
        public List<Comment> CommentList { get; set; }
        public string getCurrentUser { get; set; }
    }
}