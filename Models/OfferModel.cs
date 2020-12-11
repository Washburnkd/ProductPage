using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductPage.Data;

namespace ProductPage.Models
{
    public class OfferModel
    {
        public int OID { get; set; }
        public List<Upload> Uploads { get; set; }
        public List<Selection> Selections { get; set; }
        public List<SelectionOption> SelectionOptions { get; set; }
        public List<OItem> OItems { get; set; }
        public List<XForm> XForms { get; set; }
        public List<XFormSelection> XFormSelections { get; set; }
        
    }
}
