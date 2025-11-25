namespace Core
{
    public interface IDiscountProvider
    {
        decimal GetDiscount(string plan);
    }
}