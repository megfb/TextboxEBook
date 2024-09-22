namespace TextboxBook.UI.Models
{
    public class CartItemModel
    {

        public int CartItemId { get; set; }
        public int BookId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Img { get; set; }
        public int Quantity { get; set; }
    }
}