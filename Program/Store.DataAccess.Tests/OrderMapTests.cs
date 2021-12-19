
namespace Store.DataAccess.Tests
{
    using FluentNHibernate.Testing;
    using Store.Core;
    using NUnit.Framework;

    /// <summary>
    /// Тесты на правила отображения <see cref="Mappings.OrderMap"/>.
    /// </summary>
    [TestFixture]
    internal class OrderMapTests : BaseMapTests
    {
        [Test]
        public void PersistenceSpecification_ValidData_Success()
        {
            // arrange
            var order = new Order(1000);

            // act & assert
            new PersistenceSpecification<Order>(this.Session)
                .VerifyTheMappings(order);
        }
    }
}
