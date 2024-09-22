using System;
using System.Collections.Generic;
using System.Text;
using TextbokBook.Business.Abstract;
using TextboxBook.Dal.Abstract;
using TextboxBook.Entity.Concrete;

namespace TextbokBook.Business.Concrete
{
    public class CommentManager : ICommentService
    {
        private ICommentDal _commentDal;
        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }
        public void Add(Comment comment)
        {
            _commentDal.Add(comment);
        }

        public void Delete(int Id)
        {
            _commentDal.Delete(new Comment { Id = Id });
        }

        public Comment Get(int Id)
        {
            return _commentDal.Get(p => p.Id == Id);
        }

        public List<Comment> GetAll()
        {
            return _commentDal.GetAll();
        }

        public List<Comment> GetByBookId(int Id)
        {
            return _commentDal.GetAll(p => p.BookId == Id);
        }

        public List<Comment> GetByCommentId(int Id)
        {
            return _commentDal.GetAll(p => p.Id == Id);
        }

        public List<Comment> GetByUserId(string Id)
        {
            return _commentDal.GetAll(p => p.UserId == Id);
        }
    }
}
