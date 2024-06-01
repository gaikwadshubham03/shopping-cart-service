using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.Models
{
	public class CartItem
	{
		[Required]
		public string Name { get; set; }

		[Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than zero")]
		public double Price { get; set; }

		[Range(1, int.MaxValue, ErrorMessage = "Item should have atleast 1 quantity")]
		public int Quantity { get; set; }

		public CartItem(string name, double price, int quantity)
		{
			Name = name;
			Price = price;
			Quantity = quantity;
		}


	}
}
