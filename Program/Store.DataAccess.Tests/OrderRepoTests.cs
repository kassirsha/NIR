

namespace Store.DataAccess.Tests
{
    using Store.Core;
    using NUnit.Framework;
    using Store.DataAccess.Repositories;
    [TestFixture]
    class OrderRepoTests : BaseMapTests
    {
        [Test]
        public void GetByTotal_ValidData_Success() 
        {
            // arrange
            var repo = new OrderRepository(this.Session);

            var order = new Order(1000);

            // act
            repo.Save(order);

            // assert
            Assert.AreEqual(1000, order.OrderTotal);
        }
    }    
}

