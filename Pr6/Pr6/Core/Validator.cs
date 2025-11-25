using System;
using System.Linq;

namespace Core
{
    public static class Validator
    {
        // Проверка корректности email
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;

            // Разделяем на части по '@'
            var parts = email.Split('@');
            if (parts.Length != 2) return false;

            var domain = parts[1];

            // Точка должна быть не в начале и не в конце доменной части, и должна присутствовать
            if (!domain.Contains('.') || domain.StartsWith(".") || domain.EndsWith("."))
                return false;

            // Можно добавить более строгие проверки, например, на допустимые символы в домене
            // и на минимальную длину доменной части

            return true;
        }

        // Проверка возраста
        public static void EnsureAdult(int age)
        {
            if (age < 18) throw new ArgumentException("User must be 18+");
        }
    }
}

