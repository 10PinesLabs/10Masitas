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
            //pedido podria ser algo armado por alguien mas a partir 
            //de un diccionario de gustos y uan lista de usuarios. 
            //Pensarlo de manera mas funcional. 
            //El pedido es resultado DE: 
            //este come, este come. cerrar pedido.
            //que sentido tiene que este activa??
            //que sentido tiene tener una order y no alguien que reciba la gente que este presente 
            //y arme un pedido si fuese necesario
            
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