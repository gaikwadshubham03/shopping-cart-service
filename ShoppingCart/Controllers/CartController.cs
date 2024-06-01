using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Models;


namespace ShoppingCart.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class CartController : ControllerBase
	{
		private static List<CartItem> cartItems = new List<CartItem>();

		[HttpPost]
		public IActionResult AddItem([FromBody] CartItem item)
		{
			if (item == null || item.Quantity <= 0)
			{
				return BadRequest("Invalid item data");
			}
			cartItems.Add(item);
			return Ok(item);
		}


		[HttpGet]
		public IActionResult GetItems()
		{
			return Ok(cartItems);
		}
	}
}
