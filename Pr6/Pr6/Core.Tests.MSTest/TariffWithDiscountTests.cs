using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;
using System;

namespace Core.Tests.MSTest
{
    [TestClass]
    public class TariffWithDiscountTests
    {
        [TestMethod]
        public void Calc_WithDiscount_ReturnsCorrectValue()
        {
            // arrange
            var mock = new Moq.Mock<IDiscountProvider>();
            mock.Setup(m => m.GetDiscount("pro")).Returns(0.1m);

            var tariff = new TariffWithDiscount(mock.Object);

            // act
            decimal result = tariff.Calc("pro", 3, 10);

            // assert
            Assert.AreEqual(27, result);
            mock.Verify(m => m.GetDiscount("pro"), Moq.Times.Once());
        }
    }
}