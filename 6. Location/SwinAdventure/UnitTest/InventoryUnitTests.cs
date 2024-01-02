using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinAdventure;
namespace SwinAdventureTest
{
    public class InventoryUnitTests
    {
        private Inventory _inventory;
        private Item _bronzeSword;
        private Item _goldenSpade;

        [SetUp]
        public void Setup()
        {
            _inventory = new Inventory();
            _bronzeSword = new Item(new String[] { "sword", "bronze" }, "a bronze sword", "This sword can cut through dreams and nightmares");
            _goldenSpade= new Item(new String[] { "shovel", "spade" }, "a golden spade", "The golden shovel can even penetrate sword");
            _inventory.Put(_bronzeSword);
            _inventory.Put(_goldenSpade);

        }

        [Test]
        public void FindItemTest()
        {
            Assert.IsTrue(_inventory.HasItem("shovel"));
        }

        [Test]
        public void NoItemFindTest()
        {
            Assert.IsFalse(_inventory.HasItem("a bronze sword"));
        }

        [Test]
        public void FetchItemTest()
        {
            _inventory.Fetch("shovel");
            Assert.IsTrue(_inventory.HasItem("shovel"));
        }

        [Test]
        public void TakeItemTest()
        {
            _inventory.Take("a golden spade");
            Assert.IsFalse(_inventory.HasItem("a golden spade"));
        }

        [Test]
        public void ListItemTest()
        {
            Assert.That(_inventory.ItemList, Is.EqualTo("\n\ta bronze sword (sword)\n\ta golden spade (shovel)"));
        }
    }
}
