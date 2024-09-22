using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TextboxBook.Dal.Abstract;
using TextboxBook.Entity.Concrete;

namespace TextboxBook.Dal.Concrete.EntityFramework
{
    public class AuthorDal : EfRepository<Author, EfContext>, IAuthorDal
    {
        public Author GetAuthor(int id)
        {
            using (EfContext context = new EfContext())
            {
                var author = context.Author.Include(b => b.Book).FirstOrDefault(b => b.Id == id);

                return author;
            }
        }
    }
}
