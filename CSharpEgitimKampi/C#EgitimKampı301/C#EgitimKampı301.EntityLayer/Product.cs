using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_EgitimKampı301.EntityLayer
{
    public class Product
    {

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string ProductStock{ get; set; }

        public decimal ProductPrice { get; set; }

        public string ProductDescription { get; set; }
    }
}
