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
using System.Dynamic;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace ProductPage.Controllers
{
    public class TableController : Controller
    {
        private PinitgoDbContext _context { get; set; }
        private List<TableModel> _table { get; set; }
        public IActionResult Index()
        {
            dynamic model = new ExpandoObject();
            model.Uploads = GetUploads();
            //model.Xforms = GetXforms();
            //_table.UploadData = from u in _context.Uploads select u;
            //_table.XformData = from x in _context.Xforms select x;

            return View(model);
        }

        private static List<UploadModel> GetUploads()
        {
            List<UploadModel> uploads = new List<UploadModel>();
            return uploads;
        }
    }
}
