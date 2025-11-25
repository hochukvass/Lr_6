using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;
using System;

namespace Core.Tests.MSTest
{
    [TestClass]
    public class ValidatorTests_Converted
    {
        [DataTestMethod]
        [DataRow("a@b.com", true)]
        [DataRow("no_at_symbol", false)]
        [DataRow("empty@", false)]
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

        [TestMethod]
        public void EnsureAdult_DoesNotThrow_WhenAdult()
        {
            try
            {
                Validator.EnsureAdult(20); // не должно выбрасывать
            }
            catch
            {
                Assert.Fail("Исключение было выброшено для взрослого пользователя");
            }
        }
    }
}