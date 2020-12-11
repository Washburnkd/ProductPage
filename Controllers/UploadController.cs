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
        private ImageService _imageService { get; set; }
        private OfferService _offerService { get; set; }
        private List<Upload> _uploads { get; set; }
        private List<XForm> _xforms { get; set; }

        public UploadController(PinitgoDbContext context)
        {
            _context = context;
            _imageService = new ImageService(_context);
            _offerService = new OfferService(_context);
        }

        public IActionResult Index()
        {

            
            return View(_uploads);
        }



        [HttpGet("ie")]
        public IActionResult ie()
        {
            var offer = _offerService.GetOffer(2);
            return View("ie", offer);
        }


        [HttpPost("saveoffer")]
        public IActionResult SaveOffer([FromBody]List<XForm> xforms)
        {
            var success = _offerService.SaveXForms(xforms);
            //do something with this.
            return Json($"This was received and the result was {success}");
        }

        [HttpPost("removetransform")]
        public IActionResult RemoveTransform([FromBody] int xid)
        {
            var success = _offerService.RemoveXForms(xid);
            return Json(success);
        }

        [HttpPost("addtransform")]
        public IActionResult AddTransform([FromBody] AddTransformVM addTransformVM)
        {
            var success = _offerService.AddXForms(addTransformVM.UID, addTransformVM.OID);
            return Json(success);
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
                await _imageService.SaveImageAsync(fileName);


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
