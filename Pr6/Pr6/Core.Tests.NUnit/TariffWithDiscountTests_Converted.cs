using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;
using Moq;

namespace Core.Tests.MSTest
{
    [TestClass]
    public class TariffWithDiscountTests_Converted
    {
        [TestMethod]
        public void Applies_Discount_From_Provider()
        {
            var mock = new Mock<IDiscountProvider>();
            mock.Setup(m => m.GetDiscount("pro")).Returns(0.1m);

            var sut = new TariffWithDiscount(mock.Object);
            var total = sut.Calc("pro", 3, 10m);

            Assert.AreEqual(27m, total); // 3 * 10 * (1 - 0.1)
            mock.Verify(m => m.GetDiscount("pro"), Times.Once());
        }
    }
}