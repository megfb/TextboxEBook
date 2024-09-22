using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TextboxBook.Dal.Abstract;
using TextboxBook.Entity.Concrete;

namespace TextboxBook.Dal.Concrete.EntityFramework
{
    public class CategoryDal : EfRepository<Category, EfContext>, ICategoryDal
    {
        public Category GetById(int id)
        {
            using (EfContext context = new EfContext())
            {
                return context.Category.FirstOrDefault(p => p.Id == id);
            }
        }
    }
}
