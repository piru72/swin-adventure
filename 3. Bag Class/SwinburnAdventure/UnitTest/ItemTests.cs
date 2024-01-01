using SwinburnAdventure;


namespace UnitTest
{
    class ItemTests
    {
        private Item _rasengan;
        [SetUp]
        public void Setup()
        {
            String[] rasenId = new String[] { "wind", "chakra", "minato" };
            _rasengan = new Item(rasenId, "a giant rasengan", "Rasengan is the creation of minato!");
        }

        [TestCase("wind")]
        public void ItemIsIdentifiableTest(string testString)
        {
            Assert.IsTrue(_rasengan.AreYou(testString));
        }

        [TestCase("a giant rasengan (wind)")]
        public void ShortDescriptionTest(string testString)
        {
            Assert.That(_rasengan.ShortDescription, Is.EqualTo(testString));
        }

        [TestCase("Rasengan is the creation of minato!")]
        public void FullDescriptionTest(string testString)
        {
            Assert.That(_rasengan.FullDescription, Is.EqualTo(testString));
        }
    }
}
