using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductPage.Models
{
    public class OfferModel
    {
        public List<UploadModel> Uploadlist { get; set; }
        public List<XformModel> Formlist { get; set; }
        public List<SelectionModel> Selectionlist { get; set; }
    }
}
