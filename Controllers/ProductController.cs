using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Differencing;
using ProductPage.Data;
using ProductPage.Models;
using System.IO;

namespace ProductPage.Controllers
{
    public class ProductController : Controller
    {
        private PinitgoDbContext _context { get; set; }
        private List<ProductVM> _products { get; set; }
        //public ProductController()
        //{
        //    _products = new List<ProductVM>();
        //    _products.Add(new ProductVM() { ProductId = 1, Name = "Save Big Preorder NOW - New Production Gold Pan BUNDLE", Image = "2.jpg", Price = 79.95M });
        //    _products.Add(new ProductVM() { ProductId = 2, Name = "Save Big Preorder NOW - New Production Gold Pan BUNDLE", Image = "header.png", Price = 79.95M });
        //    _products.Add(new ProductVM() { ProductId = 3, Name = "Save Big Preorder NOW - New Production Gold Pan BUNDLE", Image = "1.png", Price = 79.95M });
        //    _products.Add(new ProductVM() { ProductId = 4, Name = "Save Big Preorder NOW - New Production Gold Pan BUNDLE", Image = "1.png", Price = 79.95M });
        //    _products.Add(new ProductVM() { ProductId = 5, Name = "Save Big Preorder NOW - New Production Gold Pan BUNDLE", Image = "1.png", Price = 79.95M });
        //    _products.Add(new ProductVM() { ProductId = 6, Name = "Save Big Preorder NOW - New Production Gold Pan BUNDLE", Image = "1.png", Price = 79.95M });
        //    _products.Add(new ProductVM() { ProductId = 7, Name = "Save Big Preorder NOW - New Production Gold Pan BUNDLE", Image = "1.png", Price = 79.95M });
        //    _products.Add(new ProductVM() { ProductId = 8, Name = "Save Big Preorder NOW - New Production Gold Pan BUNDLE", Image = "1.png", Price = 79.95M });

        //    //_products.Add(new Product() { ProductId = 2, Name = "Young Man Gold Pan", Image = "1.png", Price = 15.99M });
        //    //_products.Add(new Product() { ProductId = 305, Name = "Man Gold Pan", Image = "1.png",  Price = 20.99M });
        //}

        public ProductController(PinitgoDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            return View(_products);
        }

        [HttpGet("products")]
        public IActionResult GetProducts()
        {
            var products = _context.Products.ToList();
            return View("ProductList", products);
        }

        [HttpGet("{customerId}/products")]
        public IActionResult GetCustomerProducts(int customerId)
        {
            var products = _context.Products.Where(m=>m.CustomerId==customerId).ToList();
            return View("ProductList", products);
        }

        [HttpGet("products/add")]
        public IActionResult AddProduct()
        {
            return View();
        }

       [HttpPost("products/add")]
       public IActionResult SaveNewProduct(Product product)
        {
            var entity = _context.Products.Add(product);
            _context.SaveChanges();
            return Redirect("/products");
        }

        [HttpGet("{customerId}/products/edit/{id}")]
        public IActionResult EditProduct(int id)
        {
            var product = _context.Products.Where(m => m.ProductId == id).FirstOrDefault();
            return View(product);
        }

        [HttpPost("products/edit/{id}")]

        public IActionResult UpdateProduct(int id, [FromForm] Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
            return Redirect("/products");
        }

        [HttpGet("editItem")]
        public IActionResult EditItem(int customerId)
        {
            //var products = _context.Products.Where(m => m.CustomerId == customerId).ToList();
            return View("EditItem");
        }

        
    }
}
