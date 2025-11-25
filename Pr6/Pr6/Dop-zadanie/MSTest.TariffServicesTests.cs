using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;
using System;

namespace Core.Tests.MSTest
{
    [TestClass]
    public class TariffServiceTests
    {
        [TestMethod]
        public void CalcPrice_Basic_Correct()
        {
            Assert.AreEqual(15m, TariffService.CalcPrice("basic", 3));
        }

        [TestMethod]
        public void CalcPrice_InvalidPlan_Throws()
        {
            Assert.ThrowsException<ArgumentException>(() => TariffService.CalcPrice("unknown", 1));
        }

        [TestMethod]
        public void CalcPrice_Student_Under23_Discounted()
        {
            Assert.AreEqual(12m, TariffService.CalcPrice("student", 3, 20));
        }

        [TestMethod]
        public void CalcPrice_Student_23AndAbove_NoDiscount()
        {
            Assert.AreEqual(15m, TariffService.CalcPrice("student", 3, 23));
        }
    }
}
