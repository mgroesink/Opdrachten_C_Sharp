using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opdrachten_C_Sharp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrachten_C_Sharp.Controllers.Tests
{
    [TestClass()]
    public class StaticMethodsTests
    {
        [TestMethod()]
        public void EncryptTest()
        {
            string password = "HALLO";
            Assert.AreEqual("KDOOR", StaticMethods.Encrypt(password, 3));
            password = "MAZZEL";
            Assert.AreEqual("PDCCHO", StaticMethods.Encrypt(password, 3));
        }

        [TestMethod()]
        public void DecryptTest()
        {
            string password = "KDOOR";
            Assert.AreEqual("HALLO", StaticMethods.Decrypt(password, 3));
            password = "PDCCHO";
            Assert.AreEqual("MAZZEL", StaticMethods.Decrypt(password, 3));
        }

        [TestMethod()]
        public void FilterCharactersTest()
        {
            string expected = "ABCDEGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDFGHIJKLMNOPQRSTUVWXYZ".ToLower() + "012346789";
            string actual = StaticMethods.FilterCharacters("Fe5");

            Assert.AreEqual(expected, actual);
        }
    }
}