using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using OnlineShopProject.Models;

namespace OnlineShopProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;


        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult OurWork()
        {
            List<OurWork> model = _context.OurWork.ToList();

            return View(model);
        }

        public IActionResult Products()

        {

            List<Product> model = _context.Products.ToList();

            return View(model);

        }

        public IActionResult AllProducts()

        {

            List<Product> model = _context.Products.ToList();

            return View(model);

        }

        [HttpGet]
        public IActionResult ProductDetail(int id)
        {

            Product model = _context.Products.Find(id);
            return View(model);
        }


        public IActionResult Search(String SearchString, String PrType)
        {

            var Items = from m in _context.Products

                         select m;

            if (!string.IsNullOrEmpty(SearchString))

            {

                Items = Items.Where(s => s.ProductName.Contains(SearchString));

            }

            if (!string.IsNullOrEmpty(PrType))
            {
                Items = Items.Where(x => x.Image == PrType);
            }

            var productImage = _context.Products.Select(m => m.Image).Distinct();


            List<Product> model = Items.ToList();
            ViewData["SearchString"] = SearchString;
            ViewData["FilterProduct"] = PrType;
            ViewData["productImage"] = productImage.ToList();
            ViewData["productImageSelectList"] = new SelectList(productImage.ToList());
            return View(model);
        }

        [Produces("application/json")]
        public IActionResult ApiData()
        {
            List<Product> model = _context.Products.ToList();
            return Json(model, new JsonSerializerOptions
            {
                WriteIndented = true,
            });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
