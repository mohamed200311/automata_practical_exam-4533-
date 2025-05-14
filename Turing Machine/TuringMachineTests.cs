using NUnit.Framework;
using System;

namespace TMTask
{
    [TestFixture]
    public class TuringMachineTests
    {
        [Test] // Test Value = 0 
        public void TestZero()
        {
            var check = new TuringMachine("0");
            Assert.That(check.Run(),Is.True);
        }

        [Test]  // Test Value = 1 
        public void TestOne()
        {
            var check = new TuringMachine("1");
            Assert.That(check.Run(), Is.True);
        }

        [Test]   // Test Value = 3
        public void TestThree()
        {
            var check = new TuringMachine("11");
            Assert.That(check.Run(), Is.True);
        }

        [Test]   // Test Value = 6
        public void TestSix()
        {
            var check = new TuringMachine("110");
            Assert.That(check.Run(), Is.True);
        }

        [Test]  // Test Value = 9
        public void TestNine()
        {
            var check = new TuringMachine("1001");
            Assert.That(check.Run(), Is.True);
        }

        [Test] // Test Value = 10
        public void TestTen()
        {
            var check = new TuringMachine("1010");
            Assert.That(check.Run(), Is.True);
        }

        [Test]   // Test Value = 15
        public void TestFifteen()
        {
            var check = new TuringMachine("1111");
            Assert.That(check.Run(), Is.True);
        }

        [Test] // Test Value = 21 
        public void TestTwentyOne()
        {
            var check = new TuringMachine("10101");
            Assert.That(check.Run(), Is.True);
        }

        [Test] // Test Value = Empty
        public void TestEmptyString()
        {
            var check = new TuringMachine("");
            Assert.That(check.Run(), Is.True);
        }

        [Test] // Test Value = 54
        public void TestLargeNumber()
        {
            var check = new TuringMachine("110110"); 
            Assert.That(check.Run(), Is.True);
        }

        [Test] // Test Value contain Digits 
        public void TestInvalidInput()
        {
            var check = new TuringMachine("1021");
            Assert.That(check.Run(), Is.True);
        }
        [Test] // Test Value contain Characters  
        public void TestInvalidInputString()
        {
            var check = new TuringMachine("mohamed");
            Assert.That(check.Run(), Is.True);
        }
    }
}
