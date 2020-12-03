using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.EntityFrameworkCore;

namespace ProductPage.Models
{
    public class UploadModel
    {
        public int UID { get; set; }
        public string Extention { get; set; }
        public int AID { get; set; }
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
