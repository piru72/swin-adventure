using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinAdventure;
namespace SwinAdventureTest
{
    public class PlayerUnitTests
    {
        private Player _player;
        [SetUp]
        public void Setup()
        {
            _player = new Player("Lura" , "The mighty dream slayer.");
        }

        [Test]
        public void PlayerIsIdentifiableTest()
        {
            Assert.IsTrue(_player.AreYou("inventory"));
            Assert.IsTrue(_player.AreYou("me"));
        }

        [Test]
        public void PlayerLocatesItemsTest()
        {
            Item bronzeSword = new Item(new String[] { "sword", "bronze" }, "a bronze sword", "This sword can cut through dreams and nightmares");
            _player.Inventory.Put(bronzeSword);
            
            Assert.That(_player.Locate("sword"), Is.EqualTo(bronzeSword));
        }

        [Test]
        public void PlayerLocatesItselfTest()
        {
            Assert.That(_player.Locate("inventory") , Is.EqualTo(_player));
            Assert.That(_player.Locate("me"), Is.EqualTo(_player));
        }

        [Test]
        public void PlayerLocatesNothingTest()
        {
            Assert.That(_player.Locate("asdf"), Is.EqualTo(null));
        }

        [Test]
        public void PlayerFullDescriptionTest()
        {
            Item bronzeSword = new Item(new String[] { "sword", "bronze" }, "a bronze sword", "This sword can cut through dreams and nightmares");
            Item goldenSpade = new Item(new String[] { "shovel", "spade" }, "a golden spade", "The golden shovel can even penetrate sword");

            _player.Inventory.Put(bronzeSword);
            _player.Inventory.Put(goldenSpade);

            Assert.That(_player.FullDescription  , Is.EqualTo("You are Lura, The mighty dream slayer.\nYou are carrying:\n\ta bronze sword (sword)\n\ta golden spade (shovel)"));
        }
    }
}
