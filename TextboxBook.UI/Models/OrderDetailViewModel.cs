using System.Collections.Generic;
using System.Linq;
using TextboxBook.Entity.Concrete;

namespace TextboxBook.UI.Models
{
    public class OrderDetailViewModel
    {

        public Order Order { get; set; }
        public List<OrderItemModel> OrderItems { get; set; }

        public decimal TotalPrice()
        {

            return Order.OrderItem.Sum(i => i.Book.UnitPrice * i.Quantity);
        }
    }
}