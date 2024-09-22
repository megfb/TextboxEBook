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
    public class OrderDal : EfRepository<Order, EfContext>, IOrderDal
    {
        public List<Order> GetAllWithDetails(Expression<Func<Book, bool>> filter = null)
        {
            using (EfContext context = new EfContext())
            {
                return context.Set<Order>().Include(p => p.OrderItem).ThenInclude(p => p.Book).ToList();
            }
        }

        public Order GetOrder(int id)
        {
            using (EfContext context = new EfContext())
            {
                var order = context.Order.Include(p => p.OrderItem).ThenInclude(p => p.Book).FirstOrDefault(p => p.Id == id);
                return order;
            }
        }
    }
}
