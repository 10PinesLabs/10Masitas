using _10Masitas.Applications;
using _10Masitas.Domain;

namespace _10Masitas.Tests.Domain
{
    internal class TestObjectProvider
    {
        public Order NewOrder()
        {
            return new Order();
        }

        public MasitasApplication NewMasitasApplication()
        {
            return MasitasApplication.Create();
        }

        public LunchManagmentSystem CreateLunchManagementSystem()
        {
            return new LunchManagmentSystem();
        }
    }
}