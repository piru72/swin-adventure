using System;


namespace SwinburnAdventure
{
    internal class Program
    {
        static void Main()
        {

            Player naruto;
            Item rasengan, shadowClone;

            // creating the necessary objects
            naruto = new Player("Naruto Uzumaki", "The seventh hokage");
            String[] rasenId = new String[] { "wind", "chakra", "minato" }, cloneId = new String[] { "forbidden", "caught", "scroll" };

            rasengan = new Item(rasenId, "a giant rasengan", "Rasengan is the creation of minato!");
            shadowClone = new Item(cloneId, "Shadow clone jutsu", "With the largest chakra reserve ");

            naruto.Inventory.Put(rasengan);
            naruto.Inventory.Put(shadowClone);

            // taking commands as user input

            Console.Write(" Command -> ");
            string cmd = Console.ReadLine();
           
            if (cmd == "inventory")
                Console.WriteLine(naruto.FullDescription);
            else
                Console.WriteLine("Command isn't developed yet");
            

            
        }
    }
}
