using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.EntityFrameworkCore;

namespace ProductPage.Models
{
    public class XformModel
    {
        public int XID { get; set; }
        public int OID { get; set; }
        public int UID { get; set; }
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
