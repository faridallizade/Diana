using Diana.DAL;
using Microsoft.AspNetCore.Mvc;

namespace Diana.Areas.Admin.Controllers
{
        [Area("Admin")]
    public class DashboardController : Controller
    {

        AppDbContext _context;
        public DashboardController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
