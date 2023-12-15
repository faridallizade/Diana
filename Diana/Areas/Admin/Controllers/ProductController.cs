using Diana.Areas.Admin.ViewModels;
using Diana.DAL;
using Diana.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Diana.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {

        AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Products> product = await _context.Products
                .Include(b => b.ProductImages)
                .Include(b => b.ProductMaterials)
                .ThenInclude(b => b.Material)
                .Include(s => s.productSizes)
                .ThenInclude(s => s.Sizes)
                .Include(pc => pc.ProductColors)
                .ThenInclude(c => c.Colors)
                .Include(c => c.Category)
                .ToListAsync();

            return View(product);
        }
    }
}
