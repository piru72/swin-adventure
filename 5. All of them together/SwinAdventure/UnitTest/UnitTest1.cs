
using SwinAdventure;
namespace SwinAdventureTest
{
    public class IdentifiableObjectTests
    {

        private IdentifiableObject _obj;
        [SetUp]
        public void Setup()
        {

            _obj = new IdentifiableObject(new string[] { "fred", "bob" });

        }

        [Test]
        public void TestAreYou()
        {
            Assert.IsTrue(_obj.AreYou("fred"));
            Assert.IsTrue(_obj.AreYou("bob"));
        }

        [Test]
        public void TestNotAreYou()
        {
            Assert.IsFalse(_obj.AreYou("wilma"));
            Assert.IsFalse(_obj.AreYou("boby"));
        }

        [Test]
        public void TestCaseSensitive()
        {
            Assert.IsTrue(_obj.AreYou("FRED"));
            Assert.IsTrue(_obj.AreYou("bOB"));
        }

        [Test]
        public void TestFirstID()
        {
            Assert.That(_obj.FirstId, Is.EqualTo("fred"));
        }

        [Test]
        public void TestFirstIDWithNoIDs()
        {
            var obj2 = new IdentifiableObject(new string[0]);
            Assert.That(obj2.FirstId, Is.EqualTo(""));
        }

        [Test]
        public void TestAddID()
        {
            _obj.AddIdentifier("wilma");
            Assert.IsTrue(_obj.AreYou("wilma"));
          
        }
    }
}