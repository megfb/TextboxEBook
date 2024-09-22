using System;
using System.Collections.Generic;
using System.Text;
using TextboxBook.Entity.Abstract;

namespace TextboxBook.Entity.Concrete
{
    public class Comment:IEntity
    {

        public int Id { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string CommentName { get; set; }
        public Book Book { get; set; }
        public int BookId { get; set; }
        public DateTime CommentDate { get; set; }
    }
}
