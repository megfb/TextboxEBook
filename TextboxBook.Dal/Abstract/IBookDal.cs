using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using TextboxBook.Entity.Concrete;

namespace TextboxBook.Dal.Abstract
{
    public interface IBookDal:IRepositoryBase<Book>
    {

        List<Book> GetBooks(Expression<Func<Book, bool>> filter = null);
        Book GetBook(int id);
        

    }
}
