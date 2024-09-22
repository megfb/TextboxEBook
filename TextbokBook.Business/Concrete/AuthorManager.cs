using System;
using System.Collections.Generic;
using System.Text;
using TextbokBook.Business.Abstract;
using TextboxBook.Dal.Abstract;
using TextboxBook.Entity.Concrete;

namespace TextbokBook.Business.Concrete
{
    public class AuthorManager:IAuthorService
    {
        private IAuthorDal _authorDal;
        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }

        public void Add(Author author)
        {

            _authorDal.Add(author);
        }

        public void Delete(int id)
        {
            _authorDal.Delete(new Author { Id = id });
        }

        public List<Author> GetAll()
        {
            return _authorDal.GetAll();
        }

        public Author GetById(int id)
        {
            return _authorDal.GetAuthor(id);
        }

        public void Update(Author author)
        {
            _authorDal.Update(author);
        }
    }
}
