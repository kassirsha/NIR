// <copyright file="CommTests.cs" company="NirEpiPol">
// Copyright (c) MIIT
// </copyright>

namespace Store.Core.Test
{
    using System;
    using NUnit.Framework;
    using Store.Core;

    [TestFixture]

    /// <summary>
    /// Тесты.
    /// </summary>
    public class CommTests
    {
        [Test]
        public void ToString_ValidData_Success()
        {
            // arrange
            var product = new Product(1, "Ручка", 0);
            var expected = "Номер: 1 \n Название: Ручка \n Цена: 0";

            // act
            var actual = product.ToString();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Ctor_ValidDataEmptyCommodities_Success()
        {
            // arrange & act & assert
            Assert.DoesNotThrow(() => _ = new Product(1, "Ручка", 0));
        }
    }
}
