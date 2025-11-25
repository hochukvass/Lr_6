using System;

namespace Core
{
    public static class TariffService
    {
        public static decimal CalcPrice(string plan, int months)
        {
            if (months <= 0)
                throw new ArgumentOutOfRangeException("months");

            switch (plan)
            {
                case "basic":
                    return 5m * months;
                case "pro":
                    return 12m * months;
                case "enterprise":
                    return 25m * months;
                default:
                    throw new ArgumentException("Unknown plan");
            }
        }
    }
}