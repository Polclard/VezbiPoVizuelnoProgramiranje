using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashAccount
{
    public class Product
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(int code, string name, decimal price)
        {
            Code = code;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Code} : {Name} {String.Format("{0:0.00}",Price)}";
            //Код : Име Цена (две децимали).
        }

    }
}
