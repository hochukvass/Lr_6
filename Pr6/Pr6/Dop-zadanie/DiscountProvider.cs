using Core;
using System.Collections.Generic;

public class DiscountProvider : IDiscountProvider
{
    private readonly Dictionary<string, decimal> discounts = new Dictionary<string, decimal>()
    {
        { "basic", 0.05m },
        { "pro", 0.1m },
        { "enterprise", 0.15m },
        { "student", 0.2m }
    };

    public decimal GetDiscount(string plan)
    {
        return discounts.TryGetValue(plan, out var value) ? value : 0m;
    }
}