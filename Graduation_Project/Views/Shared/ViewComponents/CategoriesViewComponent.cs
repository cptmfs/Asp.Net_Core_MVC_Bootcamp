using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Graduation_Project.Views.Shared.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        private readonly ShoppingContext _context;

        public CategoriesViewComponent(ShoppingContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await _context.Categories.ToListAsync();
            return View(categories);
        }
    }
}