using SwinburnAdventure;

namespace UnitTest
{
    public class PlayerTests
    {
        private Player _naruto;
        private Item _rasengan, _shadowClone;
        [SetUp]
        public void Setup()
        {
            _naruto = new Player("Naruto Uzumaki", "The seventh hokage");
            String[] rasenId = new String[] { "wind", "chakra", "minato" } , cloneId = new String[] { "forbidden", "caught", "scroll" };
            _rasengan = new Item(rasenId, "a giant rasengan", "Rasengan is the creation of minato!");
            _shadowClone = new Item(cloneId, "Huge number of clones", "With the largest chakra reserve ");
            _naruto.Inventory.Put(_rasengan);
            _naruto.Inventory.Put(_shadowClone);
        }

        [TestCase("me")]
        [TestCase("inventory")]
        public void PlayerIsIdentifiableTest(string testString)
        {
            Assert.IsTrue(_naruto.AreYou(testString));
            Assert.IsTrue(_naruto.AreYou(testString));
        }


        [TestCase("wind")]
        [TestCase("chakra")]
        [TestCase("minato")]
        public void PlayerLocatesItemsTest(string testString)
        {
            
            Assert.That(_naruto.Locate(testString), Is.EqualTo(_rasengan));
        }

        [TestCase("me")]
        [TestCase("inventory")]
        public void PlayerLocatesItselfTest(string testString)
        {
            Assert.That(_naruto.Locate(testString), Is.EqualTo(_naruto));
            Assert.That(_naruto.Locate(testString), Is.EqualTo(_naruto));
        }

        [TestCase("ranDomString")]
        [TestCase("men")]
        public void PlayerLocatesNothingTest(string testString)
        {
            Assert.That(_naruto.Locate(testString), Is.EqualTo(null));
        }

        [TestCase("You are Naruto Uzumaki, The seventh hokage.\nYou are carrying:\n\ta giant rasengan (wind)")]
        public void PlayerFullDescriptionTest(string testString)
        {
            _naruto.Inventory.Take("forbidden");
            Assert.That(_naruto.FullDescription, Is.EqualTo(testString));
        }
    }
}
