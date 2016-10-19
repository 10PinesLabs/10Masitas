using NHibernate;
using _10Masitas.DataBase;
using _10Masitas.Domain;

namespace _10Masitas.Applications
{
    public class MasitasApplication
    {
        private ISession session;

        public static MasitasApplication Create()
        {
            return new MasitasApplication(SessionManager.OpenSession());
        }

        public MasitasApplication(ISession aSession)
        {
            session = aSession;
        }

        public Order CreateOrder()
        {
            var order = new Order();
            session.SaveOrUpdate(order);
            return order;
        }

        public void AddFellowDinnerTo(Order anOrder, string aFellowDinner)
        {
            anOrder.AddFellowDinner(aFellowDinner);
            session.SaveOrUpdate(anOrder);
        }

        public bool IsAFellowDinner(Order anOrder, string aFellowDinner)
        {
            var orderdb = session.QueryOver<Order>().Where(uS => uS.Id == anOrder.Id).SingleOrDefault<Order>();
            
            return orderdb.ContainsFellowDinner(aFellowDinner);
        }
    }
}