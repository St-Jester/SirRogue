using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirRogue
{
    class Inventory
    {
        #region Singleton
        public static Inventory instance;
        #endregion

        public List<Item> items;
        int capacity = 30;

        // Callback which is triggered when
        // an item gets added/removed.
        // Used for UI update
        public delegate void OnItemChanged();
        public OnItemChanged onItemChangedCallback;

        public Inventory()
        {
            items = new List<Item>();
            if (instance != null)
            {
                throw new Exception("More than one instance of Inventory found!");  
            }
            instance = this;
        }

        public void Add(Item i)
        {
            if(items.Count>=capacity)
            {
                throw new Exception("OutOfRange");
            }
            else
            {
                items.Add(i);

                //callback
                if (onItemChangedCallback != null)
                    onItemChangedCallback.Invoke();
            }
        }

        public void Remove(Item i)
        {
            items.Remove(i);     // Remove item from list

            // Trigger callback
            if (onItemChangedCallback != null)
                onItemChangedCallback.Invoke();
        }
    }
}
