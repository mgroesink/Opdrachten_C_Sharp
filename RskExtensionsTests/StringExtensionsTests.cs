using Microsoft.VisualStudio.TestTools.UnitTesting;
using RskExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RskExtensions.Tests
{
    [TestClass()]
    public class StringExtensionsTests
    {
        [TestMethod()]
        public void IsNumericTest()
        {
            Assert.IsTrue("123456".IsNumeric());
            Assert.IsFalse("1234a6".IsNumeric());
        }

        [TestMethod()]
        public void IsAlphaNumericTest()
        {
            Assert.IsTrue("123abc456".IsAlphaNumeric());
            Assert.IsTrue("aaa".IsAlphaNumeric());
            Assert.IsTrue("1234".IsAlphaNumeric());
            Assert.IsFalse("123$tyu".IsAlphaNumeric());
        }
    }
}