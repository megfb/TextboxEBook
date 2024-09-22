using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using TextboxBook.Dal.Abstract;
using TextboxBook.Entity.Concrete;

namespace TextboxBook.Dal.Concrete.EntityFramework
{
    public class BookDal : EfRepository<Book, EfContext>, IBookDal
    {
        public Book GetBook(int id)
        {
            using (EfContext context = new EfContext())
            {
                var Book = context.Book
                    .Include(b => b.Author)
                    .Include(b => b.Category)
                    .Include(b => b.Language)
                    .Include(b => b.Publisher)
                    .FirstOrDefault(b => b.Id == id);
                return Book;

            }
        }

        public List<Book> GetBooks(Expression<Func<Book, bool>> filter = null)
        {
            using (EfContext context = new EfContext())
            {
                return filter == null ?
                    context.Set<Book>().Include(b => b.Author)
                    .Include(b => b.Category)
                    .Include(b => b.Language)
                    .Include(b => b.Publisher).ToList() :
                    context.Set<Book>().Include(b => b.Author)
                    .Include(b => b.Category)
                    .Include(b => b.Language)
                    .Include(b => b.Publisher).Where(filter).ToList();
            }
        }

    }
}


