using System;
using System.Collections.Generic;
using System.Text;
using TextboxBook.Entity.Concrete;


namespace TextbokBook.Business.Abstract
{
    public interface IBookService
    {
        void Add(Book book);
        void Delete(int id);
        void Update(Book book);
        List<Book> GetAll();
        List<Book> GetByCategory(int id);
        List<Book> GetAllWithDetails();
        Book GetById(int id);
    }
}
