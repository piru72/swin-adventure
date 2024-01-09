using System;

namespace SwinAdventure
{
    public class LookCommand : Command
    {
        public LookCommand() : base(new string[] { "look" })
        {
        }

        public override string Execute(Player p, string[] text)
        {
            if (text.Length == 3 || text.Length == 5)
            {
                if (!AreYou(text[0]))
                {
                    return "Error in look input";
                }
                if (text[1] != "at")
                {
                    return "What do you want to look at?";
                }
                if (text.Length == 5 && text[3] != "in")
                {
                    return "What do you want to look in?";
                }
                IHaveInventory container = null;

                if (text.Length == 3)
                {
                    container = FetchContainer(p, "inventory");
                }
                else
                {
                    container = FetchContainer(p, text[4]);
                }
                if (container == null && text.Length == 5)
                {
                    return "I can't find the " + text[4];
                }

                return LookAtIn(text[2], container);
            }
            else
            {
                return "I don't know how to look like that";
            }
        }

        private IHaveInventory FetchContainer(Player p, string containerId)
        {
            if (containerId == "inventory")
            {
                return p;
            }
            return p.Locate(containerId) as IHaveInventory;
        }

        private string LookAtIn(string thingId, IHaveInventory container)
        {
            GameObject item = container.Locate(thingId);
            if (item == null)
            {
                if (container is Player)
                {
                    return "I can't find the " + thingId;
                }
                else
                {
                    return "I can't find the " + thingId + " in the " + container.Name;
                }
            }
            else
            {
                return item.FullDescription;
            }
        }
    }
}
