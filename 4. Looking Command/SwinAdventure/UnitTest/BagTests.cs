using SwinAdventure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventureTest
{
    internal class BagTests
    {

        private Bag _bag;
        
        private Item _goldenSpade;
        private Item _bronzeSword;

        [SetUp]
        public void Setup()
        {
            _bag= new Bag(  new string[] {"luis" , "vutton" ,"designer"} , "Luis vutton bag" , "The bag is pretty rough and tough");
            _bronzeSword = new Item(new String[] { "sword", "bronze" }, "a bronze sword", "This sword can cut through dreams and nightmares");
            _goldenSpade = new Item(new String[] { "shovel", "spade" }, "a golden spade", "The golden shovel can even penetrate sword");
            _bag.Inventory.Put(_bronzeSword);
            _bag.Inventory.Put(_goldenSpade);

        }

        [Test]
        public void BagLocatesItemTests()
        {
            Assert.IsTrue(_bag.Inventory.HasItem("shovel"));
        }

        [Test]
        public void BagLocatesItselfTest()
        {
            Assert.That(_bag.Locate("luis") , Is.EqualTo(_bag));
        }


        [Test]
        public void BagLocatesNothingTests()
        {
            Assert.IsFalse(_bag.Inventory.HasItem("adidas"));
        }


        [Test]
        public void BagFullDescriptionTests()
        {
            Assert.IsTrue(_bag.Inventory.HasItem("shovel"));
        }


        [Test]
        public void BagInBagTests()
        {
            Assert.IsTrue(_bag.Inventory.HasItem("shovel"));
        }
    }
}
