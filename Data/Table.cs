using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProductPage.Data
{
    public class Table : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
