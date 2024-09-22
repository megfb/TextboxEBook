using System;
using System.Collections.Generic;
using System.Text;
using TextboxBook.Entity.Concrete;

namespace TextboxBook.Dal.Abstract
{
    public interface IAuthorDal:IRepositoryBase<Author>
    {

        Author GetAuthor(int id);
    }
}
