using SwinburnAdventure;


namespace UnitTest
{
    internal class InventoryTests
    {
        private Inventory _inventory;
        private Item _rasengan, _shadowClone;
        [SetUp]
        public void Setup()
        {
            _inventory = new Inventory();
            String[] rasenId = new String[] { "wind", "chakra", "minato" }, cloneId = new String[] { "forbidden", "caught", "scroll" };
            _rasengan = new Item(rasenId, "a giant rasengan", "Rasengan is the creation of minato!");
            _shadowClone = new Item(cloneId, "Huge number of clones", "With the largest chakra reserve ");
            _inventory.Put(_rasengan);
            _inventory.Put(_shadowClone);
        }

        [TestCase("chakra")]
        [TestCase("minato")]
        [TestCase("wind")]
        public void FindItemTest(string testString)
        {
            Assert.IsTrue(_inventory.HasItem(testString));
        }

        [TestCase("chakra reserve")]
        [TestCase("minato namikaze")]
        [TestCase("wind character")]
        public void NoItemFindTest(string testString)
        {
            Assert.IsFalse(_inventory.HasItem(testString));
        }

        [TestCase("chakra")]
        [TestCase("minato")]
        [TestCase("wind")]
        public void FetchItemTest(string testString)
        {
            Assert.That(_inventory.Fetch(testString), Is.EqualTo(_rasengan));
        }

        [TestCase("minato")]
        public void TakeItemTest(string testString)
        {
            _inventory.Take(testString);
            Assert.That(_inventory.Fetch(testString), Is.EqualTo(null));
        }

        [TestCase("\n\ta giant rasengan (wind)\n\tHuge number of clones (forbidden)")]
        public void ListItemTest(string testString)
        {
            Assert.That(_inventory.ItemList, Is.EqualTo(testString));
        }
    }
}
