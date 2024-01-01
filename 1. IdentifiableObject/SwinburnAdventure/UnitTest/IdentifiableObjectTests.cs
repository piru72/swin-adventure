using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinburnAdventure;

namespace UnitTest
{
    public class IdentifiableObjectTests
    {
        // Arrange
        // Collect or setup the necessary things

        // Act
        // Get the actual answer

        // Assert
        // Show the result 
        

        private IdentifiableObject _obj;

        [SetUp]
        public void Setup()
        {
            _obj = new IdentifiableObject(new string[] { "fred", "bob" });
        }

        [Test]
        public void TestAreYou()
        {
            Assert.IsTrue(_obj.AreYou("bob"));
            Assert.IsTrue(_obj.AreYou("fred"));
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
            Assert.IsTrue(_obj.AreYou("bOB"));
            Assert.IsTrue(_obj.AreYou("FRED"));
        }

        [Test]
        public void TestFirstId()
        {
            Assert.That(_obj.FirstId,Is.EqualTo("fred"));
        
        }


        [Test]
        public void TestFirstIdWithNoId()
        {
            IdentifiableObject _obj2 = new IdentifiableObject(new string[0]);
            Assert.That(_obj2.FirstId, Is.EqualTo(""));
        }

        [Test]
        public void TestAddId()
        {
            _obj.AddIdentifier("wilma");
            Assert.IsTrue(_obj.AreYou("bob"));
            Assert.IsTrue(_obj.AreYou("fred"));
            Assert.IsTrue(_obj.AreYou("wilma"));
        }

    
    }
}
