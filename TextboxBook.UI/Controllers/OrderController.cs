using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TextbokBook.Business.Abstract;
using TextboxBook.Entity.Concrete;
using TextboxBook.UI.Identity;
using TextboxBook.UI.Models;

namespace TextboxBook.UI.Controllers
{
    public class OrderController : Controller
    {

        private ICartService _cartService;
        private UserManager<ApplicationUser> _userManager;
        private IOrderService _orderService;
        public OrderController(ICartService cartService, UserManager<ApplicationUser> userManager, IOrderService orderService)
        {
            _cartService = cartService;
            _userManager = userManager;
            _orderService = orderService;
        }
        public IActionResult Index()
        {
            var Cart = _cartService.GetCartByUserId(_userManager.GetUserId(User));
            var model = new OrderViewModel()
            {
                OrderItems = Cart.CartItems.Select(b => new OrderItemModel()
                {
                    BookId = b.BookId,
                    BookImg = b.Book.BookImg,
                    Bookname = b.Book.Name,
                    Price = b.Book.UnitPrice,
                    Quantity = b.Quantity
                }).ToList()

            };
            return View(model); 
        }

        [HttpPost]
        public IActionResult Index(Order order)
        {
            order.UserId = _userManager.GetUserId(User);
            var cart = _cartService.GetCartByUserId(_userManager.GetUserId(User));
            foreach (var item in cart.CartItems)
            {
                var orderItem = new OrderItem()
                {
                    BookId = item.BookId,
                    Quantity = item.Quantity
                };
                order.OrderItem.Add(orderItem);
            }

            _orderService.Add(order);
            foreach (var item in cart.CartItems)
            {
                _cartService.DeleteFromCart(order.UserId, item.BookId);
            }

            TempData.Add("Success", "Order Completed");
            return RedirectToAction("listbook","book");
        }

        [HttpGet]
        public IActionResult OrderHistory()
        {
            var model = new OrderHistoryViewModel()
            {
                OrderHistory = _orderService.GetOrderByUserId(_userManager.GetUserId(User)),
            };

            return View(model);
        }
        [HttpGet]
        public IActionResult Detail(int id)
        {
            var getOrder = _orderService.GetByOrderId(id);
            var model = new OrderDetailViewModel()
            {
                Order = getOrder,
            };

            return View(model);
        }

    }
}
