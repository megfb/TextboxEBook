using TextboxBook.Entity.Abstract;

namespace TextboxBook.Entity.Concrete
{
    public class OrderItem:IEntity
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }
        public Book Book { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }

    }
}