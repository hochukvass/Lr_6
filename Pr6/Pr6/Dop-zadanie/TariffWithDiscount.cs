namespace Core
{
    public class TariffWithDiscount
    {
        private readonly IDiscountProvider _discountProvider;

        public TariffWithDiscount(IDiscountProvider discountProvider)
        {
            _discountProvider = discountProvider;
        }

        public decimal Calc(string plan, int months, decimal baseMonthly)
        {
            var discount = _discountProvider.GetDiscount(plan);
            return months * baseMonthly * (1 - discount);
        }
    }
}