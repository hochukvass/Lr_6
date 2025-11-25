using System;

namespace Core
{
    public interface IDiscountProvider
    {
        decimal GetDiscount(string plan);
    }

    public class TariffWithDiscount
    {
        private readonly IDiscountProvider _discountProvider;

        public TariffWithDiscount(IDiscountProvider discountProvider)
        {
            _discountProvider = discountProvider;
        }

        public decimal Calc(string plan, int months, decimal baseMonthly)
        {
            if (months <= 0)
                throw new ArgumentOutOfRangeException("months");

            var discount = _discountProvider.GetDiscount(plan);
            return months * baseMonthly * (1 - discount);
        }
    }
}