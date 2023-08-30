using System.ComponentModel.DataAnnotations;

namespace Graduation_Project.ViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        [Display(Name ="Kategori Adı")]
        public string CategoryName { get; set; }
    }
}
