using System;
using System.Collections.Generic;
using System.Text;
using TextboxBook.Entity.Abstract;

namespace TextboxBook.Entity.Concrete
{
    public class Order:IEntity
    {
        public Order()
        {
            OrderItem = new List<OrderItem>();
        }

        public int Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public List<OrderItem> OrderItem { get; set; }
        //public int MyProperty { get; set; }

    }
}
