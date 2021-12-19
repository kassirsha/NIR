namespace Store.DataAccess.Tests
{
    using FluentNHibernate.Testing;
    using Store.Core;
    using NUnit.Framework;

    /// <summary>
    /// Тесты на правила отображения <see cref="Mappings.CustomerMap"/>.
    /// </summary>
    [TestFixture]
    internal class CustomerMapTests : BaseMapTests
    {
        [Test]
        public void PersistenceSpecification_ValidData_Success()
        {
            // arrange
            var customer = new Customer("Петр","Степанов","0320-2301-0231-2130");

            // act & assert
            new PersistenceSpecification<Customer>(this.Session)
                .VerifyTheMappings(customer);
        }
    }
}
