using System;


namespace SwinburnAdventure
{
    public class Item : GameObject
    {
        // inheriting the GameObject classs meaning now this class can use all the method of GameObject

        // this class only has a constructor and then it passes the value of the parameters to the base or parent class constructor
        public Item(string[] idents, string name, string desc) : base(idents, name, desc) { }
    }
}
