using System;
using System.Collections.Generic;
using System.Text;
using TextboxBook.Entity.Concrete;

namespace TextbokBook.Business.Abstract
{
    public interface ICommentService
    {
        void Add(Comment comment);
        void Delete(int Id);
        List<Comment> GetAll();
        List<Comment> GetByCommentId(int Id);
        List<Comment> GetByBookId(int Id);
        List<Comment> GetByUserId(string Id);
        Comment Get(int Id);

    }
}
