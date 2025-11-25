using System;

namespace Core
{
    public static class TariffService
    {
        public static decimal CalcPrice(string plan, int months, int? age = null)
        {
            if (months <= 0)
                throw new ArgumentOutOfRangeException(nameof(months), "Кол-во месяцев должно быть положительным числом.");

            // Используем оператор switch-case для выбора нужного тарифа
            switch (plan.ToLower())
            {
                case "basic":
                    return 5m * months;
                case "pro":
                    return 12m * months;
                case "enterprise":
                    return 25m * months;
                case "student":
                    if (age.HasValue && age.Value < 23)
                        return 5m * months * 0.8m; // скидка 20%
                    else
                        return 5m * months;
                default:
                    throw new ArgumentException($"Ошибка: Неправильный тарифный план '{plan}'", nameof(plan));
            }
        }
    }
}
