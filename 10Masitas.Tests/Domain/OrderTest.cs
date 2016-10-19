using Microsoft.VisualStudio.TestTools.UnitTesting;
using _10Masitas.Domain;

namespace _10Masitas.Tests.Domain
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void WhenCreateAnOrderThenIsActive()
        {
            var order = new Order();

            Assert.IsTrue(order.IsActive());
        }

        [TestMethod]
        public void WhenCreateAnOrderThenItHasNoFellowsDinners()
        {
            var order = new Order();

            Assert.IsFalse(order.HasFellowsDinners());
        }

        [TestMethod]
        public void WhenAnOrderIsActiveThenItCanAddAFellowDinner()
        {
            var order = new Order();

            order.AddFellowDinner("Marcos Alvarenga");
            
            Assert.IsTrue(order.HasFellowsDinners());
        }
    }
}