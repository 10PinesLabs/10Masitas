using Microsoft.VisualStudio.TestTools.UnitTesting;
using _10Masitas.Domain;

namespace _10Masitas.Tests.Domain
{
    [TestClass]
    public class LunchManagmentSystemTest
    {
        private TestObjectProvider objectProvider;
        private LunchManagmentSystem lunchManagmentSystem;
        
        [TestInitialize]
        public void SetUp()
        {
            objectProvider = new TestObjectProvider();
            lunchManagmentSystem = objectProvider.CreateLunchManagementSystem();
        }

        [TestMethod]
        public void CuandoCreoMiSistemaDeAlmuerzosEsteSeEncuentraHabilitadoParaDarPresente()
        {
            Assert.IsTrue(lunchManagmentSystem.IsEnabledToSignUp());
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
        public void CuandoAgregoUnComensalAMiSistemaDeOrganizacionDeAlmuerzoTengoUnComensal()
        {
            var aFellowDiner = "Keven";

            lunchManagmentSystem.AddFellowDiner(aFellowDiner);

            Assert.IsTrue(lunchManagmentSystem.ExistsFellowDiner(aFellowDiner));
     
        }
    }
}