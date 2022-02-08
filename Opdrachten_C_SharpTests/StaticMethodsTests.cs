using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opdrachten_C_Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrachten_C_Sharp.Tests
{
    [TestClass()]
    public class StaticMethodsTests
    {
        [TestMethod()]
        public void LuizenMoederTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PowerTest()
        {
            Assert.AreEqual(8 , StaticMethods.Power(2,3));
            
        }

        [TestMethod()]
        public void AddNumbers()
        {
            Assert.AreEqual(5, StaticMethods.AddNumbers(2, 3));

        }

    }
}