using Xunit;
using Core;
using System;

namespace Core.Tests.XUnit
{
    public class TariffWithDiscountTests
    {
        [Fact]
        public void Calc_WithDiscount_ReturnsCorrectValue()
        {
            var mock = new Moq.Mock<IDiscountProvider>();
            mock.Setup(m => m.GetDiscount("pro")).Returns(0.1m);

            var tariff = new TariffWithDiscount(mock.Object);
            decimal result = tariff.Calc("pro", 3, 10);

            Assert.Equal(27, result);
            mock.Verify(m => m.GetDiscount("pro"), Moq.Times.Once());
        }
    }
}