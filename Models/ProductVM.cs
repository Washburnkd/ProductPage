using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductPage.Models
{
    public class ProductVM
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Video { get; set; }
        public decimal Price { get; set; }
    }
}
