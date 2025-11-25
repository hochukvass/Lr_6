using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;
using System;

namespace Core.Tests.MSTest
{
    [TestClass]
    public class ValidatorTests
    {
        [DataTestMethod]
        [DataRow("a@b.com", true)]
        [DataRow("no_at_symbol", false)]
        [DataRow("test@example.", false)]
        public void IsValidEmail_Works(string email, bool expected)
        {
            Assert.AreEqual(expected, Validator.IsValidEmail(email));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EnsureAdult_Throws_WhenMinor()
        {
            Validator.EnsureAdult(17);
        }

        [DataTestMethod]
        [DataRow("user1", true)]
        [DataRow("u1", false)]
        [DataRow("user$", false)]
        [DataRow("valid_login", true)]
        [DataRow("", false)]
        public void IsValidLogin_Works(string login, bool expected)
        {
            Assert.AreEqual(expected, Validator.IsValidLogin(login));
        }
    }
}

