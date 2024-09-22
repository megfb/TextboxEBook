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
    public class LanguageDal : EfRepository<Language, EfContext>, ILanguageDal
    {
        public Language GetById(int id)
        {
            using (EfContext context = new EfContext())
            {
                Language Language = context.Language.Include(p => p.Book).FirstOrDefault(b => b.Id == id);

                return Language;
            }
        }
    }
}
