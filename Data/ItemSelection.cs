using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductPage.Data
{
    [Table("45 ItemSelection")]
    public class ItemSelection
    {
        [Key]
        public int ISID { get; set; }
        public int AID { get; set; }
        public int OID { get; set; }
        public int IID { get; set; }
        public int SOID { get; set; }



    }
}
