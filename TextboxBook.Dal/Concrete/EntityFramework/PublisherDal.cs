using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TextboxBook.Dal.Abstract;
using TextboxBook.Dal.Concrete.EntityFramework;
using TextboxBook.Entity.Concrete;

namespace TextboxBook.Dal.Concrete.EntityFramework
{
    public class PublisherDal : EfRepository<Publisher, EfContext>, IPublisherDal
    {
        public Publisher GetById(int id)
        {
            using (EfContext context = new EfContext())
            {
                var Publisher = context.Publisher.Include(p => p.Book).FirstOrDefault(p => p.Id == id);

                return Publisher;
            }
        }
    }
}
