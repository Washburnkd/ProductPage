using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductPage.Data;

namespace ProductPage.Models
{
    public class OfferModel
    {
        public List<Upload> Uploads { get; set; }
        public List<XForm> XForms { get; set; }
        public List<XFormSelection> XFormSelections { get; set; }
        public List<Selection> Selections { get; set; }
    }
}
