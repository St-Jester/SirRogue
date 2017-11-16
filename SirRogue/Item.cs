using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirRogue
{
    public struct Item
    {
        public string itemName;
        public string itemType;
        public string itemRole;
        public double modifier;

        public Item(string n, string t, string r, double m)
        {
            itemName = n;
            itemType = t;
            itemRole = r;
            modifier = m;
        }
    }
}
