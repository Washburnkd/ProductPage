using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.IO;
using ProductPage.Data;
using ProductPage.Models;
using Microsoft.CodeAnalysis.Differencing;

namespace ProductPage.Controllers
{
    public class UploadController : Controller
    {
        private PinitgoDbContext _context { get; set; }
        private List<UploadModel> _uploads { get; set; }

        public UploadController(PinitgoDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            return View(_uploads);
        }

        [HttpGet("ie")]
        public IActionResult ie()
        {
            //var products = _context.Products.Where(m => m.CustomerId == customerId).ToList();
            return View("ie");
        }

        [HttpGet("uploads")]
        public IActionResult GetUploads()
        {
            var uploads = _context.Uploads.ToList();
            return View("ie", uploads);
        }

        [HttpPost("ie")]
        public async Task<IActionResult> GetImage(IFormFile ImageFile)
        {
            if (ImageFile != null && ImageFile.Length > 0)
            {
                var fileName = Path.GetFileName(ImageFile.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\img", fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await ImageFile.CopyToAsync(fileStream);
                }
                return View("ie");
            }
            return View("ie");
        }

        [HttpPost("upload/files")]
        public async Task<IActionResult> uploadFiles(IFormFile[] files)
        {
            foreach(var ImageFile in files)
            {
                if (ImageFile != null && ImageFile.Length > 0)
                {
                    var fileName = Path.GetFileName(ImageFile.FileName);
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\img", fileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await ImageFile.CopyToAsync(fileStream);
                    }
                }
            }
            return Ok(files.Count());
        }
    }
}
