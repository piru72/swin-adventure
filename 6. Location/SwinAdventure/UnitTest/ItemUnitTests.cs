using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinAdventure;
namespace SwinAdventureTest
{
    public class ItemUnitTests
    {
        private Item _item;
        [SetUp]
        public void Setup()
        {

            _item = new Item(new String[] { "sword", "bronze" },"a bronze sword","This sword can cut through dreams and nightmares");
        }

        [Test]
        public void ItemIsIdentifiableTest()
        {
            Assert.IsTrue(_item.AreYou("sword"));
        }

        [Test]
        public void ShortDescriptionTest()
        {
            Assert.That(_item.ShortDescription , Is.EqualTo("a bronze sword (sword)"));
        }

        [Test]
        public void FullDescriptionTest()
        {
            Assert.That(_item.FullDescription, Is.EqualTo("This sword can cut through dreams and nightmares"));
        }
    }
}
