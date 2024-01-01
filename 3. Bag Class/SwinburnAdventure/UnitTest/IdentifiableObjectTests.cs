
using SwinburnAdventure;

namespace UnitTest
{
    public class IdentifiableObjectTests
    {

        private IdentifiableObject _obj;

        [SetUp]
        public void Setup()
        {
            _obj = new IdentifiableObject(new string[] { "naruto", "sasuke" });
        }

        [TestCase("naruto")]
        [TestCase("sasuke")]
        public void AreYouTest(string testString)
        {
            Assert.IsTrue(_obj.AreYou(testString));
           
        }

        [TestCase("shikamru")]
        [TestCase("sarada")]
        public void NotAreYouTest(string testString)
        {
            Assert.IsFalse(_obj.AreYou(testString));
         
        } 


        [TestCase("NARUTO")]
        [TestCase("SaSuKe")]
        public void CaseSensitiveTest(string testString)
        {
            Assert.IsTrue(_obj.AreYou(testString));
          
        }

        [TestCase("naruto")]
        public void FirstIdTest(string testString)
        {
            Assert.That(_obj.FirstId,Is.EqualTo(testString));
        
        }


        public void FirstIdWithNoIdTest()
        {
            IdentifiableObject _obj2 = new IdentifiableObject(new string[0]);
            Assert.That(_obj2.FirstId, Is.EqualTo(""));
        }

        [TestCase("shikamaru")]
        [TestCase("hintata")]
        [TestCase("sarada")]
        public void AddIdTest(string testString)
        {
            _obj.AddIdentifier(testString);
            Assert.IsTrue(_obj.AreYou("naruto"));
            Assert.IsTrue(_obj.AreYou("sasuke"));
            Assert.IsTrue(_obj.AreYou(testString));
        }

    
    }
}
