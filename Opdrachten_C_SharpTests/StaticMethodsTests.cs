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
            string expected = "Hallo allemaal wat leuk dat jullie er zijn";
            string actual = StaticMethods.LuizenMoeder();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PowerTest()
        {
            Assert.AreEqual(8, StaticMethods.Power(2, 3));

        }

        [TestMethod()]
        public void AddNumbersTest()
        {
            Assert.AreEqual(5, StaticMethods.AddNumbers(2, 3));
        }

        [TestMethod()]
        public void SteenbokTest()
        {
            var date = new DateTime(1958, 1, 10);
            var expected = "Steenbok";
            var actual = StaticMethods.Zodiac(date);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RamTest()
        {
            var date = new DateTime(1992, 3, 24);
            var expected = "Ram";
            var actual = StaticMethods.Zodiac(date);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void LeeuwTest()
        {
            var date = new DateTime(1992, 7, 23);
            var expected = "Leeuw";
            var actual = StaticMethods.Zodiac(date);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsLeapYearTest()
        {
            var expected = DateTime.IsLeapYear(DateTime.Now.Year);
            var actual = StaticMethods.IsLeapYear();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsLeapYearTest1()
        {
            Assert.IsTrue(StaticMethods.IsLeapYear(1600));
            Assert.IsTrue(StaticMethods.IsLeapYear(2000));
            Assert.IsTrue(StaticMethods.IsLeapYear(2012));
            Assert.IsFalse(StaticMethods.IsLeapYear(1700));
            Assert.IsFalse(StaticMethods.IsLeapYear(2003));
        }

        [TestMethod()]
        public void IsLeapYearTest2()
        {
            Assert.IsTrue(StaticMethods.IsLeapYear(new DateTime(1600, 1, 1)));
            Assert.IsTrue(StaticMethods.IsLeapYear(new DateTime(2000, 1, 1)));
            Assert.IsTrue(StaticMethods.IsLeapYear(new DateTime(2012, 1, 1)));
            Assert.IsFalse(StaticMethods.IsLeapYear(new DateTime(1700, 1, 1)));
            Assert.IsFalse(StaticMethods.IsLeapYear(new DateTime(2003, 1, 1)));
        }

        [TestMethod()]
        public void IsWeekendTest()
        {
            DateTime date1 = new DateTime(2022, 2, 9);
            DateTime date2 = new DateTime(2022, 2, 12);
            DateTime date3 = new DateTime(2022, 2, 13);
            DateTime date4 = new DateTime(2020, 2, 29);
            DateTime date5 = new DateTime(2024, 2, 29);
            Assert.IsFalse(StaticMethods.IsWeekend(date1));
            Assert.IsTrue(StaticMethods.IsWeekend(date2));
            Assert.IsTrue(StaticMethods.IsWeekend(date3));
            Assert.IsTrue(StaticMethods.IsWeekend(date4));
            Assert.IsFalse(StaticMethods.IsWeekend(date5));
        }

        [TestMethod()]
        public void EncryptTest()
        {
            Assert.AreEqual("KDOOR", StaticMethods.Encrypt("HALLO", 3));
            Assert.AreEqual("PDCCHO", StaticMethods.Encrypt("MAZZEL", 3));
        }

        [TestMethod()]
        public void DecryptTest()
        {
            Assert.AreEqual("HALLO", StaticMethods.Decrypt("KDOOR", 3));
            Assert.AreEqual("MAZZEL", StaticMethods.Decrypt("PDCCHO", 3));
        }

        [TestMethod()]
        public void GetCodeTest1()
        {
            string code = StaticMethods.GetCode(100000, "I0AE", false);
            bool expected = true;
            foreach (char c in "I0AE")
            {
                if (code.Contains(c))
                {
                    expected = false;
                    break;
                }
            }
            Assert.IsTrue(expected);
        }

        [TestMethod()]
        public void GetCodeTest2()
        {
            string code = StaticMethods.GetCode(100000, "i0Ae", true);
            bool expected = true;
            foreach (char c in "I0AE")
            {
                if (code.Contains(c))
                {
                    expected = false;
                    break;
                }
            }
            Assert.IsTrue(expected);
        }

        [TestMethod()]
        public void GetCodeTest3()
        {
            string code = StaticMethods.GetCode(25, "i0Ae", true);
            int expected = 25;
            Assert.AreEqual(expected, code.Length);
        }

        [TestMethod()]
        public void CheckBsnTestLength()
        {
            // Check for the correct length
            string bsn = "690226640";
            Assert.IsTrue(StaticMethods.CheckBsn(bsn));
            bsn = "6902266401";
            Assert.IsFalse(StaticMethods.CheckBsn(bsn));
            bsn = "69022640";
            Assert.IsFalse(StaticMethods.CheckBsn(bsn));
        }
        [TestMethod()]
        public void CheckBsnTestNumeric()
        {
            // Check for numeric 
            string bsn = "690226640";
            Assert.IsTrue(StaticMethods.CheckBsn(bsn));
            bsn = "6902a6640";
            Assert.IsFalse(StaticMethods.CheckBsn(bsn));
        }
        [TestMethod()]
        public void CheckBsnTestElevenCheck()
        {
            // Check for the correct length
            string bsn = "690226640";
            Assert.IsTrue(StaticMethods.CheckBsn(bsn));
            bsn = "690262640";
            Assert.IsFalse(StaticMethods.CheckBsn(bsn));
            bsn = "690236640";
            Assert.IsFalse(StaticMethods.CheckBsn(bsn));
        }

        [TestMethod()]
        public void RandomIntegerArrayTestLength()
        {
            Assert.AreEqual(99 , StaticMethods.RandomIntegerArray(99).Length);
        }
        [TestMethod()]
        public void RandomIntegerArrayTestCheckNumbers()
        {
            int[] numbers = StaticMethods.RandomIntegerArray(10000,100,999);
            bool validNumbers = true;
            foreach (var item in numbers)
            {
                if(item < 100 || item > 999)
                {
                    validNumbers = false;
                }
            }
            Assert.IsTrue(validNumbers);
        }
    }
}