using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportsSystem
{
    public class Airport
    {
        /// град (string)
        /// име (string)
        /// кратенка (string)
        /// листа со дестинации
        public string Town { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public List<Destination> Destinations { get; set;}

        public Airport(string town = "", string name = "", string shortName = "", List<Destination>? destinations = null)
        {
            Town = town;
            Name = name;
            ShortName = shortName;
            if(destinations == null)
            {
                Destinations = new List<Destination>();
            }
            else
            { 
                Destinations = destinations;
            }
        }

        public override string ToString()
        {
            return $"{ShortName} - {Name} - {Town}";
        }
    }
}
