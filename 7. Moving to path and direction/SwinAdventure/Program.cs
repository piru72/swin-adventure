using System;
namespace SwinAdventure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string name, desc;

            Console.WriteLine("Input your name");
            name = Console.ReadLine();

            Console.WriteLine("Input your description");
            desc = Console.ReadLine();

            Player p = new Player(name, desc);

            Item dagger = new Item(new String[] { "weapon", "mele" }, "A Dagger", "This will slice the enemy into two.");
            Item bow = new Item(new String[] { "weapon", "large" }, "A Bow", "Always hits bulls eye.");

            p.Inventory.Put(dagger);
            p.Inventory.Put(bow);

            string[] bagids = new string[] { "bag", "pouch" };
            Bag bag = new Bag(bagids, "A Bag", "Store your items here");
            p.Inventory.Put(bag);

            Item shovel = new Item(new String[] { "weapon", "saw" }, "A shovel", "Scars the enemy.");
            bag.Inventory.Put(shovel);

            string command = "Start";
            LookCommand lookCommand = new LookCommand();

            for (int i = 0; i < 1000; i++)
            {
                Console.Write("Your command :");
                command = Console.ReadLine();
                if (command == "exit")
                {
                    break;
                }
                string[] commandArr = command.Split(' ');
                string verdict = lookCommand.Execute(p, commandArr);
                Console.WriteLine(verdict);
            }

        }
    }
}