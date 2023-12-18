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
        IWebHostEnvironment _env;
        public ProductController(AppDbContext context,IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
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


        public async Task<IActionResult> Create()
        {
            List<Products> products = await _context.Products.ToListAsync();
            return View(); 
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductVm productVm)
        {
            List<Products> products = await _context.Products.ToListAsync();
            if (productVm is null)
            {
                return View("Error");
            }
            if (!ModelState.IsValid)
            {
                return View();
            }
            Products product = new Products()
            {
                Name = productVm.Name,
                Description = productVm.Description,
                ProductImages = new List<Images>()
            };

            Images image = new Images()
            {
                IsActive = true,
                //ImgUrl = productVm.ProductImages.Upload(_env.WebRootPath, @"\Upload\Product\"),
                Products = product,
            };
            TempData["Error"] = "";
            product.ProductImages.Add(image);
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Product");
        }
    }
}
