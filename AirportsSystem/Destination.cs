using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportsSystem
{
    public class Destination
    {
        /// листа со дестинации 
        /// за секоја дестинација се чува име, оддалеченост и цена).
        public string Name { get; set; }
        public decimal Distance { get; set; }
        public decimal Price { get; set; }

        public Destination(string Name = "", decimal Distance=0, decimal Price = 0)
        {
            this.Name = Name;
            this.Distance = Distance;
            this.Price = Price;
        }

        public override string ToString()
        {
            return $"{Name} {Distance}km-{Price}EUR";
        }
    }
}
