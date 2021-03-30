using System;
using NUnit.Framework;

namespace TravisCILab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid_Titsworth()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid_Titsworth()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null_Titsworth()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above

        // Subtract
        [Test]
        public void Subtract_Valid_Titsworth()
        {
            Assert.AreEqual(3, Program.Subtract("5", "2"));
            Assert.AreEqual(6, Program.Subtract("12", "6"));
            Assert.AreEqual(1, Program.Subtract("3", "2"));
        }

        [Test]
        public void Subtract_Invalid_Titsworth()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("1", "a"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "1"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "a"));
        }

        [Test]
        public void Subtract_Null_Titsworth()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
        }

        // Multiply
        [Test]
        public void Multiply_Valid_Titsworth()
        {
            Assert.AreEqual(2, Program.Multiply("1", "2"));
            Assert.AreEqual(6, Program.Multiply("2", "3"));
            Assert.AreEqual(1, Program.Multiply("1", "1"));
        }

        [Test]
        public void Multiply_Invalid_Titsworth()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("1", "a"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "1"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "a"));
        }

        [Test]
        public void Multiply_Null_Titsworth()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
        }

        // Divide
        [Test]
        public void Divide_Valid_Titsworth()
        {
            Assert.AreEqual(2, Program.Divide("2", "1"));
            Assert.AreEqual(2, Program.Divide("6", "3"));
            Assert.AreEqual(6, Program.Divide("12", "2"));
        }

        [Test]
        public void Divide_Invalid_Titsworth()
        {
            Assert.Throws<FormatException>(() => Program.Divide("1", "a"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "1"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "a"));
        }

        [Test]
        public void Divide_Null_Titsworth()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
        }

        // Power
        [Test]
        public void Power_Valid_Titsworth()
        {
            Assert.AreEqual(2, Program.Power("1", "1"));
            Assert.AreEqual(9, Program.Power("3", "2"));
            Assert.AreEqual(8, Program.Divide("2", "3"));
        }

        [Test]
        public void Power_Invalid_Titsworth()
        {
            Assert.Throws<FormatException>(() => Program.Power("1", "a"));
            Assert.Throws<FormatException>(() => Program.Power("a", "1"));
            Assert.Throws<FormatException>(() => Program.Power("a", "a"));
        }

        [Test]
        public void Power_Null_Titsworth()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Power("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, null));
        }
    }
}
