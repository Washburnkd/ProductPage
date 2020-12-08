using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.EntityFrameworkCore;

namespace ProductPage.Data
{
    [Table("30 XFormSelection")]
    public class XFormSelection
    {
        [Key]
        public int XSID { get; set; }
        public int OID { get; set; }
        public int XID { get; set; }
        public string SelectionSet { get; set; }
    }
}
