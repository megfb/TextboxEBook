using System;
using System.Collections.Generic;
using System.Text;
using TextboxBook.Dal.Abstract;
using TextboxBook.Entity.Concrete;

namespace TextboxBook.Dal.Concrete.EntityFramework
{
    public class CommentDal:EfRepository<Comment,EfContext>,ICommentDal
    {
    }
}
