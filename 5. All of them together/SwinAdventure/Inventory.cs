using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventure
{
    public class Inventory
    {
        private List<Item> _items;


        public string ItemList
        {
            get
            {
                string itemList ="";

                foreach(Item item in _items)
                {
                    itemList += "\n\t" + item.ShortDescription  ;
                }
                return itemList;
            }
        }

        public Inventory()
        {
            _items = new List<Item>();
        }

        public bool HasItem(string id)
        {
            foreach(Item item in _items)
            {
                if(item.AreYou(id))
                    return true;
            }

            return false;

        }

        public void Put(Item itm)
        {
            _items.Add(itm);
           
        }

        

        public Item Fetch(string id)
        {
            foreach (Item item in _items)
            {
                if (item.AreYou(id))
                {
                    return item;
                }
            }
            
            
            return null;
        }

        public Item Take(string id)
        {
            foreach (Item item in _items)
            {
                if (item.AreYou(id))
                {
                    _items.Remove(item);
                    return item;
                }
            }


            return null;
        }


    }
}
