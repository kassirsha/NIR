namespace Store.DataAccess.Tests
{
    using FluentNHibernate.Testing;
    using Store.Core;
    using NUnit.Framework;

    /// <summary>
    /// Тесты на правила отображения <see cref="Library.DataAccess.Mappings.BookMap"/>.
    /// </summary>
    [TestFixture]
    internal class CommMapTests : BaseMapTests
    {
        [Test]
        public void PersistenceSpecification_ValidData_Success()
        {
            // arrange
            var commodity = new Commodity(1, "Книга", 0);

            // act & assert
            new PersistenceSpecification<Commodity>(this.Session)
                .VerifyTheMappings(commodity);
        }
    }
}