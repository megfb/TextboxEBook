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
    public class CartDal : EfRepository<Cart, EfContext>, ICartDal
    {
        public override void Update(Cart entity)
        {
            using (EfContext context = new EfContext())
            {
                context.Cart.Update(entity);
                context.SaveChanges();
            }
        }
        public Cart GetByUserId(string id)
        {
            using (EfContext context = new EfContext())
            {
                return context.Cart.Include(p => p.CartItems).ThenInclude(p => p.Book).FirstOrDefault(p => p.UserId == id);
            }
        }

        public void DeleteFromCart(int cartId, int bookId)
        {
            using (var context = new EfContext())
            {
                var cmd = @"delete from CartItem where CartId=@p0 And BookId=@p1";
                context.Database.ExecuteSqlCommand(cmd, cartId, bookId);
            }
        }
    }
}
