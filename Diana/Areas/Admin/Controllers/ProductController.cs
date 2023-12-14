﻿using Diana.DAL;
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
            List<Products> a = await _context.Products
                .Include(b => b.ProductImages)
                .Include(b => b.ProductMaterials)
                .ThenInclude(b => b.Material)
                .Include(s => s.productSizes)
                .ThenInclude(s => s.Sizes)
                .ToListAsync();

            return View();
        }
    }
}