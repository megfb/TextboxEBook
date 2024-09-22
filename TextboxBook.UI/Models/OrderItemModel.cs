namespace TextboxBook.UI.Models
{
    public class OrderItemModel
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string Bookname { get; set; }
        public string BookImg { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}