using _10Masitas.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _10Masitas.Tests.Models
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
    }
}