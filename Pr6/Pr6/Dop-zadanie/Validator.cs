using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Core
{
    public static class Validator
    {
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            var parts = email.Split('@');
            if (parts.Length != 2) return false;
            var domain = parts[1];
            if (!domain.Contains('.') || domain.StartsWith(".") || domain.EndsWith("."))
                return false;
            return true;
        }

        public static void EnsureAdult(int age)
        {
            if (age < 18) throw new ArgumentException("User must be 18+");
        }

        public static bool IsValidLogin(string login)
        {
            if (string.IsNullOrWhiteSpace(login)) return false;
            if (login.Length < 5) return false;
            return Regex.IsMatch(login, @"^[a-zA-Z0-9_]+$");
        }
    }
}
