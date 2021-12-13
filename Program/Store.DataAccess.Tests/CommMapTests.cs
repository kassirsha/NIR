namespace Store.DataAccess.Tests
{
    using FluentNHibernate.Testing;
    using Store.Core;
    using NUnit.Framework;

    /// <summary>
    /// Тесты на правила отображения <see cref="Store.DataAccess.Mappings.BookMap"/>.
    /// </summary>
    [TestFixture]
    internal class CommMapTests : BaseMapTests
    {
        [Test]
        public void PersistenceSpecification_ValidData_Success()
        {
            // arrange
            var commodity = new Product("Книга", 0);

            // act & assert
            new PersistenceSpecification<Product>(this.Session)
                .VerifyTheMappings(commodity);
        }
    }
}