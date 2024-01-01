using SwinburnAdventure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    internal class BagTests
    {


        private Bag _jutsuStore;
        private Item _rasengan, _shadowClone;
        [SetUp]
        public void Setup()
        {
            _jutsuStore = new Bag(new string[] { "chakra", "reserves", "jutsu" }, "A Jutsu Bag", "The bag that contains scroll of all  jutsu ");
            String[] rasenId = new String[] { "wind", "chakra", "minato" }, cloneId = new String[] { "forbidden", "caught", "scroll" };
            _rasengan = new Item(rasenId, "a giant rasengan", "Rasengan is the creation of minato!");
            _shadowClone = new Item(cloneId, "Huge number of clones", "With the largest chakra reserve ");

            _jutsuStore.Inventory.Put(_rasengan);
            _jutsuStore.Inventory.Put(_shadowClone);
        }

        [TestCase("wind")]
        [TestCase("minato")]

        public void BagLocatesItemsTest(string testString)
        {
            Assert.That(_jutsuStore.Locate(testString), Is.EqualTo(_rasengan));
            Assert.IsTrue(_jutsuStore.Inventory.HasItem(testString));

        }


        [TestCase("chakra")]
        [TestCase("reserves")]
        public void PlayerLocatesItselfTest(string testString)
        {
            Assert.That(_jutsuStore.Locate(testString), Is.EqualTo(_jutsuStore));
            Assert.That(_jutsuStore.Locate(testString), Is.EqualTo(_jutsuStore));
        }

        [TestCase("sarada")]
        [TestCase("sakura")]
        public void BagLocatesNothingTest(string testString)
        {

            Assert.That(_jutsuStore.Locate(testString), Is.EqualTo(null));


        }

      
        [TestCase("In the A Jutsu Bag you can see:\n\ta giant rasengan (wind)\n\tHuge number of clones (forbidden)")]
        public void BagFullDescriptionTest(string testString)
        {

            Assert.That(_jutsuStore.FullDesctiption, Is.EqualTo(testString));

        }

        
        public void BagInBagTest()
        {
            // Create two bags
            Bag b1 = new Bag(new string[] { "bag1", "small bag" }, "Small Bag", "A small brown leather bag."), b2 = new Bag(new string[] { "bag2", "large bag" }, "Large Bag", "A large black canvas bag.");

            b1.Inventory.Put(_rasengan);
            b2.Inventory.Put(_shadowClone);
        
            Assert.That(_jutsuStore.Locate("bag2") , Is.EqualTo(b2));
            Assert.That(_jutsuStore.Locate("wind"), Is.EqualTo(_rasengan));
            Assert.That(_jutsuStore.Locate("forbidden"), Is.EqualTo(_rasengan));

        }
    }
}
