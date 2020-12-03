using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductPage.Data
{
    [Table("50 Upload")]
    public class Upload
    {
        public int UID { get; set; }
        public string Extention { get; set; }
        public int AID { get; set; }
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
