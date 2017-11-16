using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SirRogue
{
    public class Player
    {
        Inventory inv;
        public Stats s = new Stats(100, 100, 200, 30);
        //Item[] equipped = new Item[4];
        public Player()
        {
            inv = Inventory.instance;
            
        }
        public void AddItem(Item i)
        {
            inv.Add(i);
        }
        public void RemoveItem(Item i)
        {
            inv.Remove(i);
        }
    }
}
