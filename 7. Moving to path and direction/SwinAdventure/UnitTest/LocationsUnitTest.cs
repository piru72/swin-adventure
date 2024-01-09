using SwinAdventure;
using System;
using System.Collections.Generic;
namespace SwinAdventureTest
{
    internal class LocationsUnitTest
    {
        private Locations _locations;

        private Item _goldenSpade;
        private Item _bronzeSword;

        [SetUp]
        public void Setup()
        {
            _locations = new Locations(new string[] { "kings", "castle", "horror" }, "Kings Swweet Castle", "Kings castle has all the items");
            _bronzeSword = new Item(new String[] { "sword", "bronze" }, "a bronze sword", "This sword can cut through dreams and nightmares");
            _goldenSpade = new Item(new String[] { "shovel", "spade" }, "a golden spade", "The golden shovel can even penetrate sword");
            _locations.Inventory.Put(_bronzeSword);
            _locations.Inventory.Put(_goldenSpade);

        }

        [Test]
        public void LocationIdentifyThemselves()
        {
            Assert.That(_locations.Locate("kings"), Is.EqualTo(_locations));
        }

        [Test]
        public void LocationLocateItems()
        {
            Assert.That(_locations.Locate("shovel"), Is.EqualTo(_goldenSpade));
        }

        [Test]
        public void PlayersLocateItems()
        {
            Player _player = new Player("Lura", "The mighty dream slayer.");
            _player.Locations.Inventory.Put(_bronzeSword);
            Assert.That(_player.Locate("sword"), Is.EqualTo(_bronzeSword));
        }
    }
}
