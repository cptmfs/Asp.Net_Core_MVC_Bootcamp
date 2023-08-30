using DataAccess.EntityFramework;
using DataAccess.Migrations;
using DTO;
using Entity;
using Graduation_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Graduation_Project.Controllers
{

    public class ShoppingListController : Controller
    {
        private int _nextId = 1; // Başlangıç değeri
        private readonly ShoppingContext _context;

        public ShoppingListController(ShoppingContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            List<ShoppingList> shoppingLists = HttpContext.Session.Get<List<ShoppingList>>("ShoppingLists") ?? new List<ShoppingList>();
            return View(shoppingLists);
        }
        [HttpPost]
		public IActionResult Index(int shoppingListId)
		{
            List<ShoppingList> shoppingLists = HttpContext.Session.Get<List<ShoppingList>>("ShoppingLists") ?? new List<ShoppingList>();
            var selectedShoppingList = shoppingLists.FirstOrDefault(sl => sl.Id == shoppingListId);
            selectedShoppingList.IsCompleted= true;
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ShoppingList shoppingList)
        {
            List<ShoppingList> shoppingLists = HttpContext.Session.Get<List<ShoppingList>>("ShoppingLists") ?? new List<ShoppingList>();

			int _nextId = HttpContext.Session.GetInt32("NextId") ?? 1;
            shoppingList.Id = _nextId;
            shoppingList.IsCompleted = false;
            shoppingLists.Add(shoppingList);

            HttpContext.Session.SetInt32("NextId", _nextId + 1);
			// Kullanıcıya özel bir anahtar oluştur
			HttpContext.Session.Set("ShoppingLists", shoppingLists);

			return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult AddToCart(int shoppingListId, int productId, int quantity )
        {
			List<ShoppingList> shoppingLists = HttpContext.Session.Get<List<ShoppingList>>("ShoppingLists") ?? new List<ShoppingList>();
            			var shoppingListKey = $"ShoppingList_{shoppingListId}";

			var selectedShoppingList = shoppingLists.FirstOrDefault(sl => sl.Id == shoppingListId);

			if (selectedShoppingList != null)
            {
				//var existingItem = shoppingLists.FirstOrDefault(item => item.CartItems.ProductId == productId);

				//if (existingItem != null)
				//{
				//	existingItem.CartItem.Quantity += quantity;
				//}
				var product = _context.Products.Find(productId);
                if (product != null)
                {
                    selectedShoppingList.CartItems.Add( new CartItem
                    {
                        ProductId = productId,
                        Quantity = quantity,
                        Price = product.Price,
                        ProductImage = product.ProductImage,
                        ProductName = product.Name
					});
					HttpContext.Session.Set("ShoppingLists", shoppingLists);
				}
			}

			return RedirectToAction("Index");

		}



		[HttpPost]
        public IActionResult RemoveProduct(int shoppingListIndex, int productIndex)
        {
            List<ShoppingList> shoppingLists = HttpContext.Session.Get<List<ShoppingList>>("ShoppingLists") ?? new List<ShoppingList>();
            if (shoppingListIndex >= 0 && shoppingListIndex < shoppingLists.Count)
            {
                if (productIndex >= 0 && productIndex < shoppingLists[shoppingListIndex].Products.Count)
                {
                    shoppingLists[shoppingListIndex].Products.RemoveAt(productIndex);
                    HttpContext.Session.Set("ShoppingLists", shoppingLists);
                }
            }
            return RedirectToAction("Index");
        }



        [HttpPost, ActionName("Delete")]
        public IActionResult Delete(int id)
        {
            List<ShoppingList> shoppingLists = HttpContext.Session.Get<List<ShoppingList>>("ShoppingLists") ?? new List<ShoppingList>();
            ShoppingList selectedShoppingList = shoppingLists.FirstOrDefault(sl => sl.Id == id);

            if (selectedShoppingList != null)
            {
                shoppingLists.Remove(selectedShoppingList);
                HttpContext.Session.Set("ShoppingLists", shoppingLists);
            }

            return RedirectToAction("Index", "ShoppingList"); // Burada Index'e gitmek için "ShoppingList" controller'ını belirtiyoruz.
        }
    }

}
