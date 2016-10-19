using Microsoft.VisualStudio.TestTools.UnitTesting;
using _10Masitas.Domain;

namespace _10Masitas.Tests.Domain
{
    [TestClass]
    public class OrderTest
    {
        private TestObjectProvider objectProvider;
        private Order order;

        [TestInitialize]
        public void SetUp()
        {
            objectProvider = new TestObjectProvider();
            order = objectProvider.NewOrder();
        }

        [TestMethod]
        public void WhenCreateAnOrderThenIsActive()
        {
            Assert.IsTrue(order.IsActive());
        }

        [TestMethod]
        public void WhenCreateAnOrderThenItHasNoFellowsDinners()
        {
            Assert.IsFalse(order.HasFellowsDinners());
        }

        [TestMethod]
        public void WhenAnOrderIsActiveThenItCanAddAFellowDinners()
        {
            order.AddFellowDinner("Marcos Alvarenga");
            
            Assert.IsTrue(order.HasFellowsDinners());
        }
    }
}