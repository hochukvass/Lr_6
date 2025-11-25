using Xunit;
using Core;
using System;

namespace Core.Tests.XUnit
{
    public class TariffServiceTests
    {
        [Fact]
        public void CalcPrice_Basic_Correct()
        {
            Assert.Equal(15m, TariffService.CalcPrice("basic", 3));
        }

        [Fact]
        public void CalcPrice_InvalidPlan_Throws()
        {
            Assert.Throws<ArgumentException>(() => TariffService.CalcPrice("unknown", 1));
        }

        [Fact]
        public void CalcPrice_Student_Under23_Discounted()
        {
            Assert.Equal(12m, TariffService.CalcPrice("student", 3, 20));
        }

        [Fact]
        public void CalcPrice_Student_23AndAbove_NoDiscount()
        {
            Assert.Equal(15m, TariffService.CalcPrice("student", 3, 23));
        }
    }
}
