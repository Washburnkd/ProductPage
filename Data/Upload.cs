using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductPage.Data
{
    [Table("70 Upload")]
    public class Upload
    {
        [Key]
        public int UID { get; set; }
        public int AID { get; set; }
        public string Name { get; set; }
    }
}
