using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;
using System;

namespace Core.Tests.MSTest
{
    [TestClass]
    public class ValidatorTests
    {
        [TestMethod]
        public void IsValidEmail_Valid_ReturnsTrue()
        {
            // arrange
            string email = "a@b.com";
            // act
            bool result = Validator.IsValidEmail(email);
            // assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsValidEmail_Invalid_ReturnsFalse()
        {
            string email = "no_at_symbol";
            bool result = Validator.IsValidEmail(email);
            Assert.IsFalse(result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EnsureAdult_Under18_ThrowsException()
        {
            Validator.EnsureAdult(17);
        }
    }
}