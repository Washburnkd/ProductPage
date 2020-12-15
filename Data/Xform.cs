using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductPage.Data
{
    [Table("50 XForm")]
    public class XForm
    {
        [Key]
        public int XID { get; set; }
        public int AID { get; set; }
        public int OID { get; set; }
        public int IXbit { get; set; }
        public int ZOrder { get; set; }
        public string XFormName { get; set; }
        public int UID { get; set; }
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public double Rotation { get; set; }
        public double Transparency { get; set; }
        //public bool Crop { get; set; }
    }
}
