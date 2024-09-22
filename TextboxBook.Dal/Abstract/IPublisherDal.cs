using System;
using System.Collections.Generic;
using System.Text;
using TextboxBook.Entity.Concrete;

namespace TextboxBook.Dal.Abstract
{
    public interface IPublisherDal:IRepositoryBase<Publisher>
    {
        Publisher GetById(int id);
    }
}
