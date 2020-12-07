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
using ProductPage.Repository.Service;

namespace ProductPage.Controllers
{
    public class UploadController : Controller
    {
        private PinitgoDbContext _context { get; set; }
        private List<UploadModel> _uploads { get; set; }
        private List<XformModel> _xforms { get; set; }

        struct allTables
        {

        }

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
         var offer=   UploadingImages.GetUploadImages(1);
             var uploads = _context.Uploads.ToList();
            return View("ie", offer);
            //var products = _context.Products.Where(m => m.CustomerId == customerId).ToList();
            //List<string> allTables = new List<string>();
            //allTables.Add(uploads.ToString());


        }
        [HttpPost]
        public IActionResult UpdateWidth(int Xid)
        {
            var offer = UploadingImages.UpdateWidth(Xid);
            return Json(true);
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
                var u = new Upload();
                u.Name = ImageFile.FileName;
                u.AID = 1;
                //u.Extention = ImageFile.FileName.Split('.').Last();
                UploadingImages.UploadImages(u);
                //_context.Uploads.Add(u);
                //await _context.SaveChangesAsync();

                //var found = _context.Uploads.Where(x => x.UID == u.UID).FirstOrDefault();
                //_context.Uploads.Remove(found);
                //await _context.SaveChangesAsync();
                //System.IO.File.Delete(filePath);
                return Redirect("ie");
            }
            return Redirect("ie");
        }

        [HttpPost("upload/files")]
        public async Task<IActionResult> uploadFiles(IFormFile[] files)
        {
            foreach (var ImageFile in files)
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
