using System;
using SwinAdventure;
using NUnit.Framework;

namespace UnitTest
{
    public class LookCommandUnitTests
    {
        LookCommand _look;
        Player _player;
        Item gem;
        Item _pencil;
        Bag _bag;
        Item _marker;

        [SetUp]
        public void Setup()
        {
            _player = new Player("Lura", "Great potter head");
            _bag = new Bag(new string[] { "Red", "Gucci", "bag" }, "Gucci", "Short purse");
            gem = new Item(new string[] { "Ring", "blue" }, "I have a gem ring", "It is very expensive");
            _pencil = new Item(new string[] { "pencil", "black" }, "John wick's pencil", "The deadly pencil of John Wick");
            _marker = new Item(new string[] { "green", "white" }, "Permanent marker green one", "Temporary is the white one");
            _bag.Inventory.Put(_marker);
            _bag.Inventory.Put(gem);
            _player.Inventory.Put(gem);
            _player.Inventory.Put(_pencil);
            _player.Inventory.Put(_bag);
            _look = new LookCommand();
        }

        [Test]
        public void TestLookAtMe()
        {
            string[] command = new string[] { "look", "at", "inventory" };
            Assert.That(_look.Execute(_player, command), Is.EqualTo("You are Lura, Great potter head\nYou are carrying:\n\tI have a gem ring (ring)\n\tJohn wick's pencil (pencil)\n\tGucci (red)"));
        }

        [Test]
        public void TestLookAtGem()
        {
            string[] command = new string[] { "look", "at", "blue" };
            Assert.That(_look.Execute(_player, command), Is.EqualTo("It is very expensive"));
        }

        [Test]
        public void TestLookAtUnk()
        {
            string[] command = new string[] { "look", "at", "Unk" };
            Assert.That(_look.Execute(_player, command), Is.EqualTo("I can't find the Unk"));
        }

        [Test]
        public void TestLookAtGemInMe()
        {
            string[] command = new string[] { "look", "at", "blue", "in", "inventory" };
            Assert.That(_look.Execute(_player, command), Is.EqualTo("It is very expensive"));
        }

        [Test]
        public void TestLookAtGemInBag()
        {
            string[] command = new string[] { "look", "at", "blue", "in", "bag" };
            Assert.That(_look.Execute(_player, command), Is.EqualTo("It is very expensive"));
        }

        [Test]
        public void TestLookAtGemInNoBag()
        {
            string[] command = new string[] { "look", "at", "green", "in", "lv" };
            Assert.That(_look.Execute(_player, command), Is.EqualTo("I can't find the lv"));
        }

        [Test]
        public void TestLookAtNoGemInBag()
        {
            string[] command = new string[] { "look", "at", "lv", "in", "bag" };
            Assert.That(_look.Execute(_player, command), Is.EqualTo("I can't find the lv in the Gucci"));
        }

        [Test]
        public void TestInvalidLook1()
        {
            string[] command = new string[] { "look", "yourself" };
            Assert.That(_look.Execute(_player, command), Is.EqualTo("I don't know how to look like that"));
        }

        [Test]
        public void TestInvalidLook2()
        {
            string[] command = new string[] { "Hi", "Sariya", "lura" };
            Assert.That(_look.Execute(_player, command), Is.EqualTo("Error in look input"));
        }

        [Test]
        public void TestInvalidLook3()
        {
            string[] command = new string[] { "look", "for", "yourself" };
            Assert.That(_look.Execute(_player, command), Is.EqualTo("What do you want to look at?"));
        }

        [Test]
        public void TestInvalidLook4()
        {
            string[] command = new string[] { "look", "at", "bag", "for", "lura" };
            Assert.That(_look.Execute(_player, command), Is.EqualTo("What do you want to look in?"));
        }
    }
}
