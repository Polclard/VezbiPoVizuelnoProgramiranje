using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotrosuvackaKosnicka
{
    public class ProductItem
    {
        public Product TheProduct { get; set; }
        public decimal Quantity { get; set; }

        public override string ToString()
        {
            return $"{TheProduct.Name} {String.Format("{0:0.0}", Quantity)}x{String.Format("{0:0.00}", TheProduct.Price)} = {String.Format("{0:0.00}", (decimal)TheProduct.Price)}";

        }
    }
}
