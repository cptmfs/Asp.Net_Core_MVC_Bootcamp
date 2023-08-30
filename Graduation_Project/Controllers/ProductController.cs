using AutoMapper;
using DataAccess.EntityFramework;
using Entity;
using Graduation_Project.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;

namespace Graduation_Project.Controllers
{
    public class ProductController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly IFileProvider _fileProvider;
        private readonly IMapper _mapper;

        private readonly ShoppingContext _context;

        public ProductController(ILogger<HomeController> logger, IFileProvider fileProvider, IMapper mapper, ShoppingContext context)
        {
            _logger = logger;
            _fileProvider = fileProvider;
            _mapper = mapper;
            _context = context;
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            var categories = _context.Categories.ToList();
            ViewBag.category = new SelectList(categories, "Id", "CategoryName");//SelectedValue Id olacak Kullanıcı Name 'i  görecek.  
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid) // Validasyon başarılı ise aşağıdaki kaydetmeyi yap..
            {
                var product = _mapper.Map<Product>(productViewModel); // maplemeyii yaptık

                if (productViewModel.Image != null && productViewModel.Image.Length > 0)
                {
                    var root = _fileProvider.GetDirectoryContents("wwwroot"); // Projenin kök klasörünü verir bu "" boş tırnak ile.
                    var images = root.First(x => x.Name == "Images"); //wwwroot klasöründeki adı images olanı al .

                    var randomImageName = Guid.NewGuid() + Path.GetExtension(productViewModel.Image.FileName);
                    // GetExtension verilen dosyanın uzantısını alır. " nokta Jpg gibi "
                    //

                    var path = Path.Combine(images.PhysicalPath, randomImageName);//images klasörünün fiziksel yolunu al ( C:/Kaptan/github..vs gibi) birde newProduct'ın Image'inin dosya adını al.

                    using var stream = new FileStream(path, FileMode.Create); //kaydetmek için stream oluşturmak zorunlu. path = kaydet , den sonra FileMode.Create = eğer yoksa oluştur.

                    productViewModel.Image.CopyTo(stream); // resmi wwwroot images'e kaydettik.
                    product.ProductImage = randomImageName; // maplenmiş product'ın imagepath'ine upload edilen resmin dosya adını verdik.

                }
                _context.Products.Add(product); // ve bunu veritabanına ekledik..
                _context.SaveChanges();
                return RedirectToAction("Index");

            }

            return View();
        }


        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var product = _context.Products.Find(id);
            var categories = _context.Categories.ToList();
            ViewBag.category = new SelectList(categories, "Id", "CategoryName");//SelectedValue Id olacak Kullanıcı Name 'i  görecek.  
            var mapProduct = _mapper.Map<ProductViewModel>(product);
            return View(mapProduct);
        }
        [HttpPost]
        public IActionResult UpdateProduct(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                if (productViewModel.Image != null && productViewModel.Image.Length > 0)
                {
                    var root = _fileProvider.GetDirectoryContents("wwwroot"); // Projenin kök klasörünü verir bu "" boş tırnak ile.
                    var images = root.First(x => x.Name == "Images"); //wwwroot klasöründeki adı images olanı al .

                    var randomImageName = Guid.NewGuid() + Path.GetExtension(productViewModel.Image.FileName);
                    // GetExtension verilen dosyanın uzantısını alır. " nokta Jpg gibi "
                    //

                    var path = Path.Combine(images.PhysicalPath, randomImageName);//images klasörünün fiziksel yolunu al ( C:/Kaptan/github..vs gibi) birde newProduct'ın Image'inin dosya adını al.

                    using var stream = new FileStream(path, FileMode.Create); //kaydetmek için stream oluşturmak zorunlu. path = kaydet , den sonra FileMode.Create = eğer yoksa oluştur.

                    productViewModel.Image.CopyTo(stream); // resmi wwwroot images'e kaydettik.
                    productViewModel.ProductImage = randomImageName; // maplenmiş product'ın imagepath'ine upload edilen resmin dosya adını verdik.

                }
                var products = _mapper.Map<Product>(productViewModel);
                _context.Products.Update(products);
                _context.SaveChanges();

                return RedirectToAction("Index","Home");
            }
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> RemoveProduct(int productId)
        {
            var product = _context.Products.Find(productId);

            if (product != null)
            {
                 _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index", "Home");
        }

    }
}
