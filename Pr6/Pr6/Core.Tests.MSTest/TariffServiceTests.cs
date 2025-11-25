using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;
using System;

namespace Core.Tests.MSTest
{
    [TestClass]
    public class TariffServiceTests
    {
        [TestMethod]
        public void CalcPrice_Basic3Months_Returns15()
        {
            decimal result = TariffService.CalcPrice("basic", 3);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalcPrice_UnknownPlan_ThrowsException()
        {
            TariffService.CalcPrice("unknown", 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CalcPrice_ZeroMonths_ThrowsException()
        {
            TariffService.CalcPrice("basic", 0);
        }
    }
}