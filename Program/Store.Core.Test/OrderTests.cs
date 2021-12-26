// <copyright file="OrderTests.cs" company="NirEpiPol">
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
    public class OrderTests
    {
        [Test]
        public void ToString_ValidData_Success()
        {
            // arrange
            var customer = new Customer("Виталий", "Пупкин", "6456-2342-6452-5436");
            var order = new Order(1000);
            order.AddCustomer(customer);
            var expected = "Виталий 1000";

            // act
            var actual = order.ToString();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Ctor_ValidDataEmptyOrders_Success()
        {
            // arrange & act & assert
            Assert.DoesNotThrow(() => _ = new Order(1000));
        }
    }
}
