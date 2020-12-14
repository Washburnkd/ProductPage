using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductPage.Data
{
    [Table("40 OItem")]
    public class OItem
    {
        [Key]
        public int IID { get; set; }
        public long AID { get; set; }
        public long OID { get; set; }
        public string Selections { get; set; }


    }
}
