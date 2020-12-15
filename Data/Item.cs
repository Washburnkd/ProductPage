using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductPage.Data
{
    [Table("40 Item")]
    public class Item
    {
        [Key]
        public int IID { get; set; }
        public int AID { get; set; }
        public int OID { get; set; }
        public string Selections { get; set; }
        public long XFormSel { get; set; }


    }
}
