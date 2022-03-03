using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Tests
{
	[TestClass()]
	public class RomanNumberTests
	{
        [TestMethod()]
        public void Add()
        {
            
            var romanNumber0 = new  RomanNumber(11);
            var romanNumber1 = new RomanNumber(20);
            var romanNumber2 = new RomanNumber(150);
            var expected1 = new RomanNumber(5);
            var expected2 = new RomanNumber(163);
         
            RomanNumber actual1 = romanNumber0 + romanNumber1;
            RomanNumber actual2 = romanNumber0 + romanNumber2;
            
            Assert.AreEqual(expected1.ToString(), actual1.ToString());
            Assert.AreEqual(expected2.ToString(), actual2.ToString());

        }
        [TestMethod()]
        public void Sub()
        {
            
            var romanNumber0 = new RomanNumber(10);
            var romanNumber1 = new RomanNumber(5);
            var romanNumber2 = new RomanNumber(150);
            var expected = new RomanNumber(11);

            

            RomanNumber actual = romanNumber0 - romanNumber1;

            
            Assert.AreEqual(expected.ToString(), actual.ToString());
            Assert.ThrowsException<RomanNumberException>(() => (romanNumber0 - romanNumber2));

        }
        [TestMethod()]
        public void Div()
        {
            var romanNumber0 = new RomanNumber(10);
            var romanNumber1 = new RomanNumber(5);
            var romanNumber2 = new RomanNumber(150);
            var expected = new RomanNumber(5);

            //act

            RomanNumber actual = romanNumber0 / romanNumber1;

            //assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
            Assert.ThrowsException<RomanNumberException>(() => (romanNumber0 / romanNumber2));
        }
        [TestMethod()]
        public void Mul()
        {
            
            var romanNumber0 = new RomanNumber(15);
            var romanNumber1 = new RomanNumber(5);
            var romanNumber2 = new RomanNumber(23);
            var expected1 = new RomanNumber(29);
            var expected2 = new RomanNumber(92);
            
            RomanNumber actual1 = romanNumber0 * romanNumber1;
            RomanNumber actual2 = romanNumber0 * romanNumber2;
            
            Assert.AreEqual(expected1.ToString(), actual1.ToString());
            Assert.AreEqual(expected2.ToString(), actual2.ToString());
        }

        [TestMethod()]
        public void ToStringTest()
        {
            
            RomanNumber romanNumber = new RomanNumber(3003);
            string expected = "MMMIII";
            
            string actual = romanNumber.ToString();
            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CloneTest()
        {
            
            RomanNumber romanNumber = new RomanNumber(5);
            RomanNumber expected = new RomanNumber(5);
            
            RomanNumber clone = (RomanNumber)romanNumber.Clone();
            
            Assert.AreEqual(expected.ToString(), clone.ToString());
            Assert.AreNotSame(expected, clone);
        }


        [TestMethod()]
        public void CompareToTest()
        {
            
            RomanNumber romanNumber = new RomanNumber(10);
            RomanNumber romanNumber1 = new RomanNumber(10);
            const int expected = 0;
            
            int actual = romanNumber.CompareTo(romanNumber1);
            
            Assert.AreEqual(expected, actual);
        }
    }
}