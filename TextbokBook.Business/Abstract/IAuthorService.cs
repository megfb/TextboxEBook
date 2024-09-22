using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using TextboxBook.Entity.Concrete;

namespace TextbokBook.Business.Abstract
{
    public interface IAuthorService
    {
        List<Author> GetAll();

        void Add(Author author);
        void Delete(int id);
        void Update(Author author);
        Author GetById(int id);

    }
}
