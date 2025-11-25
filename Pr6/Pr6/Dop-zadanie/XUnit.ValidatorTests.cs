using Xunit;
using Core;
using System;

namespace Core.Tests.XUnit
{
    public class ValidatorTests
    {
        [Theory]
        [InlineData("a@b.com", true)]
        [InlineData("no_at_symbol", false)]
        [InlineData("test@example.", false)]
        public void IsValidEmail_Works(string email, bool expected)
        {
            Assert.Equal(expected, Validator.IsValidEmail(email));
        }

        [Fact]
        public void EnsureAdult_Throws_WhenMinor()
        {
            Assert.Throws<ArgumentException>(() => Validator.EnsureAdult(17));
        }

        [Theory]
        [InlineData("user1", true)]
        [InlineData("u1", false)]
        [InlineData("user$", false)]
        [InlineData("valid_login", true)]
        [InlineData("", false)]
        public void IsValidLogin_Works(string login, bool expected)
        {
            Assert.Equal(expected, Validator.IsValidLogin(login));
        }
    }
}
