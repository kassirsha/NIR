namespace Store.DataAccess.Tests
{
    using FluentNHibernate.Testing;
    using Store.Core;
    using NUnit.Framework;

    /// <summary>
    /// Тесты на правила отображения <see cref="Mappings.ProductMap"/>.
    /// </summary>
    [TestFixture]
    internal class ProductMapTests : BaseMapTests
    {
        [Test]
        public void PersistenceSpecification_ValidData_Success()
        {
            // arrange
            var product = new Product("Книга", 0);

            // act & assert
            new PersistenceSpecification<Product>(this.Session)
                .VerifyTheMappings(product);
        }
    }
}