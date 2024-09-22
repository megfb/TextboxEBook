using System;
using System.Collections.Generic;
using System.Text;
using TextboxBook.Entity.Concrete;

namespace TextboxBook.Dal.Abstract
{
    public interface ICartDal : IRepositoryBase<Cart>
    {
        Cart GetByUserId(string id);
        void DeleteFromCart(int cartId, int bookId);

    }
}
