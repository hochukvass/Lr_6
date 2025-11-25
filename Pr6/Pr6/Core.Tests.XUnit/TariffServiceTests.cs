using Xunit;
using Core;
using System;

namespace Core.Tests.XUnit
{
    public class TariffServiceTests
    {
        [Fact]
        public void CalcPrice_Basic3Months_Returns15()
        {
            Assert.Equal(15, TariffService.CalcPrice("basic", 3));
        }

        [Fact]
        public void CalcPrice_UnknownPlan_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => TariffService.CalcPrice("unknown", 1));
        }

        [Fact]
        public void CalcPrice_ZeroMonths_ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => TariffService.CalcPrice("basic", 0));
        }
    }
}