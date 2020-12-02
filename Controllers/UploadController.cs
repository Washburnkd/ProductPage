using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace ProductPage.Controllers
{
    public class UploadController : Controller
    {
        [HttpGet("ie")]
        public IActionResult ie()
        {
            //var products = _context.Products.Where(m => m.CustomerId == customerId).ToList();
            return View("ie");
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
