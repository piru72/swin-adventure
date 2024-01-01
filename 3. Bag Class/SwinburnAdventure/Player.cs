using System;

namespace SwinburnAdventure
{
    public class Player : GameObject
    {
        // inheriting the GameObject classs meaning now this class can use all the method of GameObject
        private Inventory _inventory;


        public override string FullDescription
        {
            get
            {
                // creating the string that needes to be sent as the description
                string processedName = "You are " + Name + ", ";
                string processedDesc = base.FullDescription;
                string processedInventory = ".\nYou are carrying:" + _inventory.ItemList;
                string result = processedName + processedDesc + processedInventory;
                return result ;
            }
        }

        public Inventory Inventory 
        {
            get { return _inventory; }
        }



        public Player(string name, string desc) : base(new string[] { "me", "inventory" }, name, desc)
        {
            _inventory = new Inventory();

        }


        public GameObject Locate(string id)
        {
            // AreYou method is inherited and now being used here also using the inventory object fetch method to fetch the item if it returns null we are returning null
            if (AreYou(id)) 
                return this;
            GameObject gameObj;
            gameObj = _inventory.Fetch(id);
            return gameObj;
            
        }


    }
}
