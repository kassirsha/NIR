

namespace Store.DataAccess.Tests
{
    using Store.Core;
    using NUnit.Framework;
    using Store.DataAccess.Repositories;
    [TestFixture]
    internal class CustomerRepoTests : BaseMapTests
    {
        [Test]
        public void GetByName_ValidData_Success()
        {
            // arrange
            var repo = new CustomerRepository(this.Session);
            var name = "Виталий";

            var cust = new Customer(name, "Пупкин", "6456-2342-6452-5436"); 

            // act
            repo.Save(cust);
            var result = repo.GetByName(name);

            // assert
            Assert.AreEqual(name, result.Name);
        }

        public void Save_ValidData_Success()
        {
            // arrange
            var repo = new CustomerRepository(this.Session);
            var name = "Виталий";

            var product = new Customer(name, "Пупкин", "6456-2342-6452-5436");

            // act & assert
            Assert.IsTrue(repo.Save(product));
        }
    }
}
