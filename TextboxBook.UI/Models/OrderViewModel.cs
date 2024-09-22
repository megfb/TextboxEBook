using System.Collections.Generic;
using System.Linq;
using TextboxBook.Entity.Concrete;

namespace TextboxBook.UI.Models
{
    public class OrderViewModel
    {
        //public List<CartItem> CartItems { get; set; }

        public Order Order { get; set; }
        public List<OrderItemModel> OrderItems { get; set; }

        public decimal TotalPrice()
        {

            return OrderItems.Sum(i => i.Price * i.Quantity);
        }
    }
}