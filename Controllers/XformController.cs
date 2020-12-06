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
    public class XformController : Controller
    {
        private PinitgoDbContext _context { get; set; }
        private List<XformModel> _xforms { get; set; }

        public XformController(PinitgoDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            return View(_xforms);
        }

        //[HttpGet("ie")]
        //public IActionResult ie()
        //{
        //    //var products = _context.Products.Where(m => m.CustomerId == customerId).ToList();
        //    var xforms = _context.Xforms.ToList();
        //    return View("ie", xforms);
        //}

        [HttpGet("xforms")]
        public IActionResult GetXforms()
        {
            var xforms = _context.Xforms.ToList();
            return View("ie", xforms);
        }

        //[HttpPost("ie")]
        //public async Task<IActionResult> GetImage(IFormFile ImageFile)
        //{
        //    if (ImageFile != null && ImageFile.Length > 0)
        //    {
        //        var fileName = Path.GetFileName(ImageFile.FileName);
        //        var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\img", fileName);
        //        using (var fileStream = new FileStream(filePath, FileMode.Create))
        //        {
        //            await ImageFile.CopyToAsync(fileStream);
        //        }
        //        var x = new Xform();
        //        x.XformName = ImageFile.FileName;
        //        //u.Extention = ImageFile.FileName.Split('.').Last();
        //        _context.Xforms.Add(x);
        //        await _context.SaveChangesAsync();
        //        //var found = _context.Uploads.Where(x => x.UID == u.UID).FirstOrDefault();
        //        //_context.Uploads.Remove(found);
        //        //await _context.SaveChangesAsync();
        //        //System.IO.File.Delete(filePath);
        //        return Redirect("ie");
        //    }
        //    return Redirect("ie");
        //}

        //[HttpPost("xform/files")]
        //public async Task<IActionResult> uploadFiles(IFormFile[] files)
        //{
        //    foreach (var ImageFile in files)
        //    {
        //        if (ImageFile != null && ImageFile.Length > 0)
        //        {
        //            var fileName = Path.GetFileName(ImageFile.FileName);
        //            var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\img", fileName);
        //            using (var fileStream = new FileStream(filePath, FileMode.Create))
        //            {
        //                await ImageFile.CopyToAsync(fileStream);
        //            }
        //        }
        //    }
        //    return Ok(files.Count());
        //}
    }
}
