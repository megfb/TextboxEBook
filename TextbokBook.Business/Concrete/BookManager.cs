using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TextbokBook.Business.Abstract;
using TextboxBook.Dal.Abstract;
using TextboxBook.Entity.Concrete;

namespace TextbokBook.Business.Concrete
{
    public class BookManager : IBookService
    {
        private IBookDal _bookDal;
        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }
        public void Add(Book book)
        {
            _bookDal.Add(book);
        }

        public void Delete(int id)
        {
            _bookDal.Delete(new Book { Id = id });
        }

        public List<Book> GetAll()
        {
            return _bookDal.GetAll();
        }
        public List<Book> GetAllWithDetails()
        {
            return _bookDal.GetBooks();
        }

        public List<Book> GetByCategory(int id)
        {
            return _bookDal.GetBooks(p => p.CategoryId == id || id == 0);
        }

        public Book GetById(int id)
        {
            return _bookDal.GetBook(id);
        }

        public void Update(Book book)
        {
            _bookDal.Update(book);
        }
    }
}
