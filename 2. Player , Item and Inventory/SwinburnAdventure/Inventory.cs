
using System.Collections.Generic;

namespace SwinburnAdventure
{
    public class Inventory
    {
        private List<Item> _items;

        public string ItemList
        {
            get
            {
                // creating the list of item details for each item available 
                string itemDetails = "", lineGap = "\n\t";
               
                foreach (Item item in _items)
                {
                    itemDetails += lineGap; 
                    itemDetails +=item.ShortDescription;
                }    
                return itemDetails;
            }
        }

        public Inventory()
        {
            // initializing the variable
            _items = new List<Item>();
        }

        public bool HasItem(string id)
        {
            bool hasItem = false;
            // finding the item using areyou method of that class if it returns true then breaking the loop and sending it back
            foreach (Item item in _items)
            {
                if (item.AreYou(id))
                {
                    hasItem = true;
                    break;
                }       
            }
            return hasItem;

        }

        public void Put(Item itm)
        {
            // adding the item to the list
            _items.Add(itm);
        }
        public Item Fetch(string id)
        {
            Item foundItem = null;
            // finding the item at first and if found storing that item in another variable and sending that fariable
            foreach (Item item in _items)
            {
                if (item.AreYou(id))
                {
                    foundItem = item;
                    break;
                }

            }

            return foundItem;
        }
        public Item Take(string id)
        {
            Item foundItem = null;
            foundItem = Fetch(id);
            // fetching the item at first then checking if it's available if it is then removing the item from the list
            if (HasItem(id))
                _items.Remove(foundItem);

            return foundItem;
        }

       

       


    }
}
