using System;
using System.Collections.Generic;
using System.Text;
using TextboxBook.Entity.Concrete;

namespace TextboxBook.Dal.Abstract
{
    public interface ICategoryDal:IRepositoryBase<Category>
    {

        Category GetById(int id);
    }
}
