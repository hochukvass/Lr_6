using Xunit;
using Moq;
using Core;

namespace Core.Tests.XUnit
{
    public class TariffWithDiscountTests
    {
        [Fact]
        public void Applies_Discount_From_Provider()
        {
            var mock = new Mock<IDiscountProvider>();
            mock.Setup(m => m.GetDiscount("pro")).Returns(0.1m);

            var sut = new TariffWithDiscount(mock.Object);
            var total = sut.Calc("pro", 3, 10m);

            Assert.Equal(27m, total);
        }

        [Fact]
        public void Calc_Student_WithRealProvider()
        {
            var provider = new DiscountProvider();
            var sut = new TariffWithDiscount(provider);
            var total = sut.Calc("student", 3, 5m);

            Assert.Equal(12m, total);
        }
    }
}
