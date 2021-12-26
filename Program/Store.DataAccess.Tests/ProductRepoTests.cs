

namespace Store.DataAccess.Tests
{
    using Store.Core;
    using NUnit.Framework;
    using Store.DataAccess.Repositories;
    [TestFixture]
    internal class ProductRepoTests : BaseMapTests
    {
        [Test]
        public void GetByName_ValidData_Success()
        {
            // arrange
            var repo = new ProductRepository(this.Session);
            var name = "Ручка";

            var product = new Product(name, 10);

            // act
            repo.Save(product);
            var result = repo.GetByName(name);

            // assert
            Assert.AreEqual(name, result.Name);
        }

        public void Save_ValidData_Success()
        {
            // arrange
            var repo = new ProductRepository(this.Session);
            var name = "Ручка";

            var product = new Product(name, 10);

            // act & assert
            Assert.IsTrue(repo.Save(product));
        }
    }
}
