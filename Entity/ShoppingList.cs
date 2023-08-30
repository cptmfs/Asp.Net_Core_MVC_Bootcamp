
namespace Entity
{
    public class ShoppingList
    {

        public int Id { get; set; }
        public string Name { get; set; }
        //public int ProductId { get; set; }
        //public string ProductName { get; set; }
        //public string ProductImage { get; set; }
        //public double Price { get; set; }
        //public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public bool IsCompleted { get; set; }
        public List<Product> Products { get; set; }
		public List<CartItem>? CartItems { get; set; } = new List<CartItem>(); // CartItem koleksiyonunu burada başlatıyoruz
		public CartItem CartItem { get; set; }

	}
}
