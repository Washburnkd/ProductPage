using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductPage.Data
{
    [Table("00 Xform")]
    public class Xform
    {
        [Key]
        public int XID { get; set; }
        public int OID { get; set; }
        public int TblType { get; set; }
        public int XSID { get; set; }
        public string XformName { get; set; }
        public float Rotation { get; set; }
        public int Top { get; set; }
        public int Left { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
    }
}
