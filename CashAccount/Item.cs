using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashAccount
{
    public class Item
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public int MyProperty { get; set; }

        public Item(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
        public override string ToString()
        {
            return $"{Product.Name} {Product.Price} X {Quantity} = {String.Format("{0:0.00}",Product.Price * Quantity)}";
            //Име на продукт Цена на продукт X количина = Вкупна цена (две децимали).
        }
    }
}
