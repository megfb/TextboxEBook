using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TextbokBook.Business.Abstract;
using TextboxBook.UI.Identity;
using TextboxBook.UI.Models;

namespace TextboxBook.UI.Controllers
{
    public class CartController : Controller
    {
        private ICartService _cartService;
        private UserManager<ApplicationUser> _userManager;
        public CartController(ICartService cartService,UserManager<ApplicationUser>userManager)
        {
            _cartService = cartService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var cart = _cartService.GetCartByUserId(_userManager.GetUserId(User));

            var model = new CartModel()
            {
                CartId = cart.Id,
                CartItems = cart.CartItems.Select(b => new CartItemModel()
                {
                    CartItemId = b.Id,
                    BookId = b.Book.Id,
                    Name = b.Book.Name,
                    Price = b.Book.UnitPrice,
                    Img = b.Book.BookImg,
                    Quantity = b.Quantity

                }).ToList(),
            };
            return View(model);
        }

        public IActionResult AddCartItem(int Id, int quantity)
        {
            _cartService.AddToCart(_userManager.GetUserId(User), Id, quantity);


            return RedirectToAction("listbook", "book");
        }

        [HttpPost]
        public IActionResult Delete(int bookId)
        {
            _cartService.DeleteFromCart(_userManager.GetUserId(User), bookId);
            return RedirectToAction("index", "cart");
        }

    }
}
