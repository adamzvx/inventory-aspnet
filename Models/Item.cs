using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class Item
    {
        public int id { get; set; }
        public string nama { get; set; }
        public string supplier { get; set; }
        public int jumlah { get; set; }
        public Item()
        {

        }
    }
}
