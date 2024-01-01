using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinburnAdventure
{
    public class Bag : Item
    {

        private Inventory _inventory;

        public Inventory Inventory 
        { 
            get { return _inventory; }
        }
        public string FullDesctiption 
        { 
            get
            {
                string processedName = "In the " + Name + " ";
       
                string processedInventory = "you can see:" + _inventory.ItemList;
                string result = processedName + processedInventory;
                return result;
            }
        }
        public Bag(string[] ids, string name , string desctiption) : base(ids, name , desctiption)
        {
            _inventory = new Inventory();
        }

        public GameObject Locate(string id)
        {
            if (AreYou(id)) return this;
            else return _inventory.Fetch(id);
        }
    }
}
