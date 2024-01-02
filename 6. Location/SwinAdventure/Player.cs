using System;
using System.Runtime.InteropServices;

namespace SwinAdventure
{
    public class Player : GameObject, IHaveInventory
    {
        private Inventory _inventory;
        private Locations _loactions;

        public override string FullDescription
        {
            get
            {
                return "You are " + Name + ", " + base.FullDescription + "\nYou are carrying:" + _inventory.ItemList;
            }
        }

        public Inventory Inventory
        {
            get { return _inventory; }
        }
        public Locations Locations
        {
            get { return _loactions; }
        }

        public Player(string name, string desc) : base(new string[] { "me", "inventory" }, name, desc)
        {
            _inventory = new Inventory();
            _loactions = new Locations(new string[] { "kings", "castle" }, "Sweet Home", "The holy land of king");
        }

        public GameObject Locate(string id)
        {
            if (AreYou(id))
                return this;
            else if (_inventory.HasItem(id))
                return _inventory.Fetch(id);

            return _loactions.Locate(id);
        }
    }
}
