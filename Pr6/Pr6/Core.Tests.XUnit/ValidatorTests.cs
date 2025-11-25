using Xunit;
using Core;
using System;

namespace Core.Tests.XUnit
{
    public class ValidatorTests
    {
        [Fact]
        public void IsValidEmail_Valid_ReturnsTrue()
        {
            Assert.True(Validator.IsValidEmail("a@b.com"));
        }

        [Fact]
        public void IsValidEmail_Invalid_ReturnsFalse()
        {
            Assert.False(Validator.IsValidEmail("no_at_symbol"));
        }

        [Fact]
        public void EnsureAdult_Under18_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => Validator.EnsureAdult(17));
        }
    }
}