using Diana.DAL;
using Diana.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Diana.Controllers
{
    public class HomeController : Controller
    {

        private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                Products = await _context.Products.ToListAsync(),
            };
            return View(homeVM);
        }
    }
}
