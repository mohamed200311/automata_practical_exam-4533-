using FirstTask;
using NUnit.Framework;
using System;

namespace DFATests
{
    [TestFixture]
    public class DFATests
    {
        [Test] // Test value = "101" at start
        public void TestContains101AtStart()
        {
            Assert.That(Program.DFA("101"), Is.True);
        }

        [Test] // Test value = "101" in middle
        public void TestContains101InMiddle()
        {
            Assert.That(Program.DFA("0101"), Is.True);
            Assert.That(Program.DFA("11011"), Is.True);
        }

        [Test] // Test value = "101" at end
        public void TestContains101AtEnd()
        {
            Assert.That(Program.DFA("01101"), Is.True);
        }

        [Test] // Test multiple "101"
        public void TestMultiple101()
        {
            Assert.That(Program.DFA("101101"), Is.True);
            Assert.That(Program.DFA("1010101"), Is.True);
        }

        [Test] // Test value doesn't contain "101"
        public void TestDoesNotContain101()
        {
            Assert.That(Program.DFA(""), Is.False);
            Assert.That(Program.DFA("0"), Is.False);
            Assert.That(Program.DFA("1"), Is.False);
            Assert.That(Program.DFA("00"), Is.False);
            Assert.That(Program.DFA("11"), Is.False);
            Assert.That(Program.DFA("010"), Is.False);
            Assert.That(Program.DFA("011"), Is.False);
        }


        [Test] // Test value contains invalid characters
        public void TestInvalidCharacters()
        {
            Assert.That(Program.DFA("10201"), Is.False);
            Assert.That(Program.DFA("10a1"), Is.False);
            Assert.That(Program.DFA(" "), Is.False);
        }

        [Test] // Test value = Empty
        public void TestNullInput()
        {
            Assert.That(Program.DFA(""), Is.False);
        }

        [Test] // Test value =  long length strings 
        public void TestLongLengthStringsVaild()
        {
            Assert.That(Program.DFA("111010111"), Is.True);
            Assert.That(Program.DFA("000101000"), Is.True);
        }

        [Test] // Test long invalid strings
        public void TestLongLengthStringsInvaild()
        {
            Assert.That(Program.DFA("111000111"), Is.False);
            Assert.That(Program.DFA("010010010"), Is.False);
        }
    }
}