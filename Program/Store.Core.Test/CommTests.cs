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
            var commodity = new Commodity(1, "Ручка", 0);
            var listcomm = new ListCom(50, commodity);
            var expected = "Ручка 1 0";

            // act
            var actual = commodity.ToString();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Ctor_ValidDataEmptyCommodities_Success()
        {
            // arrange & act & assert
            Assert.DoesNotThrow(() => _ = new Commodity(1, "Ручка", 0));
        }
    }
}
