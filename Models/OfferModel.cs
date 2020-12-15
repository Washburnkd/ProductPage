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
        public List<Item> Items { get; set; }
        public List<ItemSelection> ItemSelections { get; set; }
        public List<XForm> XForms { get; set; }
        public List<ItemXForm> ItemXForms { get; set; }
    }
}
