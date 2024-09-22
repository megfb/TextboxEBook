using System;
using System.Collections.Generic;
using System.Text;
using TextboxBook.Entity.Abstract;

namespace TextboxBook.Entity.Concrete
{
    public class CartItem : IEntity
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public int BookId { get; set; }
        public Cart Cart { get; set; }
        public int CartId { get; set; }
        public int Quantity { get; set; }
    }
}
