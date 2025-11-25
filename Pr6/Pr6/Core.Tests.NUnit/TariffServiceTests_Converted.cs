using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;
using System;

namespace Core.Tests.MSTest
{
    [TestClass]
    public class TariffServiceTests_Converted
    {
        [TestMethod]
        public void CalcPrice_Basic_Correct()
        {
            Assert.AreEqual(15m, TariffService.CalcPrice("basic", 3));
        }

        [TestMethod]
        public void CalcPrice_Pro_Correct()
        {
            Assert.AreEqual(36m, TariffService.CalcPrice("pro", 3));
        }

        [TestMethod]
        public void CalcPrice_Enterprise_Correct()
        {
            Assert.AreEqual(75m, TariffService.CalcPrice("enterprise", 3));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalcPrice_InvalidPlan_Throws()
        {
            TariffService.CalcPrice("unknown", 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CalcPrice_InvalidMonths_Throws()
        {
            TariffService.CalcPrice("basic", 0);
        }
    }
}