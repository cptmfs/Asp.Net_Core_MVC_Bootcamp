using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Graduation_Project.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        [ValidateNever]
        public IFormFile? Image { get; set; }
        [ValidateNever]
        public string ProductImage { get; set; }
        public int CategoryId { get; set; }
    }
}
