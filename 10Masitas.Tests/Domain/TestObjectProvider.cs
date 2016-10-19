using _10Masitas.Domain;

namespace _10Masitas.Tests.Domain
{
    internal class TestObjectProvider
    {
        public Order NewOrder()
        {
            return new Order();
        }
    }
}