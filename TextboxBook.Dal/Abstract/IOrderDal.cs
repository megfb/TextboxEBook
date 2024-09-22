using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using TextboxBook.Entity.Concrete;

namespace TextboxBook.Dal.Abstract
{
    public interface IOrderDal:IRepositoryBase<Order>
    {
        Order GetOrder(int id);
        List<Order> GetAllWithDetails(Expression<Func<Book, bool>> filter = null);
    }
}
