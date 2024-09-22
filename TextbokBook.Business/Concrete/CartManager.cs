using System;
using System.Collections.Generic;
using System.Text;
using TextbokBook.Business.Abstract;
using TextboxBook.Dal.Abstract;
using TextboxBook.Entity.Concrete;

namespace TextbokBook.Business.Concrete
{
    public class CartManager : ICartService
    {
        private ICartDal _cartDal;
        public CartManager(ICartDal cartDal)
        {
            _cartDal = cartDal;
        }

        public void AddToCart(string userId, int bookId, int quantity)
        {
            var cart = _cartDal.GetByUserId(userId);
            if (cart != null)
            {
                var index = cart.CartItems.FindIndex(p => p.BookId == bookId);
                if (index<0)
                {
                    cart.CartItems.Add(new CartItem
                    {
                        BookId = bookId,
                        Quantity = quantity,
                        CartId = cart.Id
                    });
                }
                else
                {
                    cart.CartItems[index].Quantity += quantity;
                }
                _cartDal.Update(cart);
            }
        }

        public Cart GetCartByUserId(string id)
        {
            return _cartDal.GetByUserId(id);
        }

        public void InitilaizeCart(string id)
        {
            _cartDal.Add(new Cart { UserId = id });
        }

        public void DeleteFromCart(string userId, int bookId)
        {
            var cart = GetCartByUserId(userId);
            if (cart != null)
            {
                _cartDal.DeleteFromCart(cart.Id, bookId);
            }

        }
    }
}
