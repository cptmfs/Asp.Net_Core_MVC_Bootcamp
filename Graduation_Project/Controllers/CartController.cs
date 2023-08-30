using DataAccess.EntityFramework;
using DTO;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Graduation_Project.Controllers
{
	public class CartController : Controller
	{
		private readonly ShoppingContext _context;

		public CartController(ShoppingContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
            return View(GetCart());
		}
		[HttpPost]
		public IActionResult AddToCart(int productId, int quantity)
		{
           var isCompleted= HttpContext.Session.GetString("IsCompleted");

            if (isCompleted=="false" || isCompleted is null)
            {
                var cart = GetCart();

                var existingItem = cart.FirstOrDefault(item => item.ProductId == productId);

                if (existingItem != null)
                {
                    existingItem.Quantity += quantity;
                }
                else
                {
                    var product = _context.Products.Find(productId);
                    if (product != null)
                    {
                        cart.Add(new CartDto
                        {
                            ProductId = productId,
                            Quantity = quantity,
                            Price = product.Price,
                            ProductImage = product.ProductImage,
                            ProductName = product.Name,

                        });
                    }
                }
                HttpContext.Session.Set("Cart", cart);
            }
            else
            {
                TempData["InShopping"] = "Alışverişe Çıkıldığında listeye ürün eklenemez!";
            }
            
			
			return RedirectToAction("Index", "Home");
		}
		[HttpPost]
		public IActionResult RemoveFromCart(int productId)
		{
			var cart = GetCart();
            var itemToRemove = cart.FirstOrDefault(item => item.ProductId == productId);

			if (itemToRemove != null)
			{
				cart.Remove(itemToRemove);
				HttpContext.Session.Set("Cart", cart);
			}

            return RedirectToAction("Index", "Cart");
		}
        [HttpPost]
        public IActionResult ClearCart()
        {
            var cart = GetCart();

            if (cart != null)
            {
                cart.Clear();
                HttpContext.Session.Set("Cart", cart);
            }

            return RedirectToAction("Index", "Cart");
        }
        public List<CartDto> GetCart()
		{
			var cart= HttpContext.Session.Get<List<CartDto>>("Cart") ?? new List<CartDto>();
			return cart;
		}
		[HttpPost]
		public IActionResult GoShopping()
        {
            var cart = GetCart();
            HttpContext.Session.SetString("IsCompleted", "true");
			TempData["IsCompleted"] = true;

            return RedirectToAction("Index", "Cart"); // Alışveriş sonrası yönlendirme yapabilirsiniz
        }

        [HttpPost]
        public IActionResult CompletedShopping()
        {
            var cart = GetCart();
            HttpContext.Session.SetString("IsCompleted", "false");
            TempData["IsCompleted"] = false;

            return RedirectToAction("Index", "Cart"); // Alışveriş sonrası yönlendirme yapabilirsiniz
        }
        public PartialViewResult Summary()
        {
            return PartialView(GetCart());
        }
    }
}
