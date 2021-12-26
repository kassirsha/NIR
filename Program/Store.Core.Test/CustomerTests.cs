// <copyright file="CustomerTests.cs" company="NirEpiPol">
// Copyright (c) MIIT
// </copyright>

namespace Store.Core.Test
{
    using NUnit.Framework;
    using Store.Core;

    [TestFixture]

    /// <summary>
    /// Тесты.
    /// </summary>
    public class CustomerTests
    {
        [Test]
        public void ToString_ValidData_Success()
        {
            // arrange
            var customer = new Customer("Виталий", "Пупкин", "6456-2342-6452-5436");
            var expected = "Виталий 6456-2342-6452-5436";

            // act
            var actual = customer.ToString();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Ctor_ValidDataEmptyCustomer_Success()
        {
            // arrange & act & assert
            Assert.DoesNotThrow(() => _ = new Customer("Виталий", "Пупкин", "6456-2342-6452-5436"));
        }
    }
}
