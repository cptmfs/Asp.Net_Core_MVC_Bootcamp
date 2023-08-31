using AutoMapper;
using DataAccess.EntityFramework;
using Entity;
using Graduation_Project.Models;
using Graduation_Project.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.FileProviders;
using System.Diagnostics;

namespace Graduation_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFileProvider _fileProvider;
        private readonly IMapper _mapper;

        private readonly ShoppingContext _context;

        public HomeController(ILogger<HomeController> logger, ShoppingContext context, IFileProvider fileProvider, IMapper mapper)
        {
            _logger = logger;
            _context = context;
            _fileProvider = fileProvider;
            _mapper = mapper;
        }

        public IActionResult Index(int? id, int shoppingListId)
        {

            ViewBag.shoppingListIndex = shoppingListId;
            var products = _context.Products.
               Select(y => new ProductViewModel()
               {
                   Id = y.Id,
                   Name = y.Name.Length > 50 ? y.Name.Substring(0, 47) + "..." : y.Name,
                   Price = y.Price,
                   ProductImage = y.ProductImage ?? "1.png",
                   CategoryId = y.Category.Id,
               }).AsQueryable();
            if (id != null)
            {
                products = products.Where(i => i.CategoryId == id);
            }
            return View(products.ToList());
        }

        public IActionResult Filter(string searchString)
        {
            ViewBag.dataFilter = ("Filter");
            // Ürün ismine göre bir arama

            var products = _context.Products.Select(p => new ProductViewModel
            {
                Name = p.Name,
                Price = p.Price,
                Id = p.Id,
                ProductImage = p.ProductImage,
            }).ToList();

            if (!string.IsNullOrEmpty(searchString))
            {
                // eğer boş değilse view ekranında bir arama kelimesi yazılmıştır.
                var filteredResult = products.Where(n => n.Name.ToLower().Contains(searchString.ToLower())).ToList();

                return View("Index", filteredResult);
            }
			else
			{
				// Eğer searchString boş ise, tüm ürünleri döndür.
				return View("Index", products);
			}

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}