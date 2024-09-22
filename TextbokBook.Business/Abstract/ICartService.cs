using System;
using System.Collections.Generic;
using System.Text;
using TextboxBook.Entity.Concrete;

namespace TextbokBook.Business.Abstract
{
    public interface ICartService
    {
        Cart GetCartByUserId(string id);
        void InitilaizeCart(string id);
        void AddToCart(string userId, int bookId, int quantity);
        void DeleteFromCart(string userId, int bookId);

    }
}
