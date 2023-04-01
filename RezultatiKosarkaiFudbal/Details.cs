using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezultatiKosarkaiFudbal
{
    public class Details<K, V>
    {
        public K key { get; set; }
        public V value { get; set; }

        public Details(K key, V value) {
            this.key = key;
            this.value = value; 
        }
    }
}
