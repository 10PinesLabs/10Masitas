using Microsoft.VisualStudio.TestTools.UnitTesting;
using _10Masitas.Applications;

namespace _10Masitas.Tests.Domain
{
    [TestClass]
    public class MasitasApplicationTest
    {
        private TestObjectProvider objectProvider;
        private MasitasApplication masitasApp;

        [TestInitialize]
        public void SetUp()
        {
            objectProvider = new TestObjectProvider();
            masitasApp = objectProvider.NewMasitasApplication();
        }

        [TestMethod]
        public void CanCreateAnOrder()
        {
            var anOrder = masitasApp.CreateOrder();

            Assert.IsTrue(anOrder.IsActive());
        }

        [TestMethod]
        public void WhenAnOrderIsActiveCanAddAFellowDinner()
        {
            var anOrder = masitasApp.CreateOrder();
            var aFellowDinner = "Keven";

            masitasApp.AddFellowDinnerTo(anOrder, aFellowDinner);

            Assert.IsTrue(masitasApp.IsAFellowDinner(anOrder, aFellowDinner));
        }
    }
}

