using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashAccount
{
    public class Cashier
    {
        List<Product> Products;
        List<Item> Items;

        public Cashier()
        {
            Products = new List<Product>();
            Items = new List<Item>();
        }
    }
}
