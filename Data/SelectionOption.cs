using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductPage.Data
{
    [Table("30 SelectionOption")]
    public class SelectionOption
    {
        [Key]
        public int SOID { get; set; }
        public int AID { get; set; }
        public int OID { get; set; }
        public int SID { get; set; }
        public string OName { get; set; }
        public bool Default { get; set; }

    }
}
