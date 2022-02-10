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
    public class IntExtensionsTests
    {
        [TestMethod()]
        public void IsAutomorphTest()
        {
            Assert.IsTrue(5.IsAutomorph());
            Assert.IsTrue(25.IsAutomorph());
            Assert.IsFalse(7.IsAutomorph());
        }

        [TestMethod()]
        public void IsDisariumTest()
        {
            Assert.IsTrue(175.IsDisarium());
            Assert.IsTrue(9.IsDisarium());
            Assert.IsFalse(987.IsDisarium());
        }
    }
}