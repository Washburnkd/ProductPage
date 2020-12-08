using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductPage.Data
{
    [Table("20 Selection")]
    public class Selection
    {
        [Key]
        public int SID { get; set; }
        public int AID { get; set; }
        public int OID { get; set; }
        public int SsetID { get; set; }
        public int ORD { get; set; }
        public string Option { get; set; }

    }
}
