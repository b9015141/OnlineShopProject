using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineShopProject.Models;

namespace OnlineShopProject.Controllers
{
    [Authorize(Roles = "Manager")]
  
    public class CMSController : Controller
    {
        private readonly ILogger<CMSController> _logger;
        private readonly ApplicationDbContext _context;

        public CMSController(ILogger<CMSController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            List<Product> model = _context.Products.ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(ProductForm model)
        {

            if (ModelState.IsValid)
            {
                Product newProduct = new Product
                {
                    ProductName = model.ProductName,
                    PrDescription = model.PrDescription,
                    Image = model.Image,
                    PrSize = model.PrSize,
                    PrColor = model.PrColor,
                    PrPrice = model.PrPrice,
                    PrPriceSale = model.PrPriceSale,
                    DateTime = DateTime.Now,
                };
                _context.Add(newProduct);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();

        }

        
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            Product model = _context.Products.Find(id);
            ProductForm formModel = new ProductForm

            {
                Id = model.Id,
                ProductName = model.ProductName,
                PrDescription = model.PrDescription,
                Image = model.Image,
                PrSize = model.PrSize,
                PrColor = model.PrColor,
                PrPrice = model.PrPrice,
                PrPriceSale = model.PrPriceSale,
                DateTime = DateTime.Now,
            };
            ViewBag.ImageName = model.Image;
            return View(formModel);
        }

        [HttpPost]
        public IActionResult UpdateProduct(ProductForm model)
        {
            // Only run if image is changed

            Product editProduct = new Product
            {
                Id = model.Id,
                ProductName = model.ProductName,
                PrDescription = model.PrDescription,
                Image = model.Image,
                PrSize = model.PrSize,
                PrColor = model.PrColor,
                PrPrice = model.PrPrice,
                PrPriceSale = model.PrPriceSale,
                DateTime = DateTime.Now,
            };
            _context.Products.Update(editProduct);

            _context.SaveChanges();
            return RedirectToAction("Index");          
        }

        [HttpGet]
        public IActionResult DeleteProduct(int Id)
        {
            Product model = _context.Products.Find(Id);
            return View(model);
        }

        [HttpPost]
        public IActionResult DeleteProduct(Product model)
        {
            _context.Products.Remove(model);
            _context.SaveChanges();
            //return View(model);
            return RedirectToAction("Index");
        }    

    }
}

