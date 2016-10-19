using System;
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
            return DuringTransactionDo(() =>
            {
                var order = new Order();
                session.Save(order);
                return order;
            });
        }

        public void AddFellowDinnerTo(Order anOrder, string aFellowDinner)
        {
            DuringTransactionDoWithOutReturn(() =>
            {
                anOrder.AddFellowDinner(aFellowDinner);
                session.Update(anOrder);
            });
        }

        public bool IsAFellowDinner(Order anOrder, string aFellowDinner)
        {
            return anOrder.ContainsFellowDinner(aFellowDinner);
        }

        private T DuringTransactionDo<T>(Func<T> aFunction)
        {
            using (var transaction = session.BeginTransaction())
            {
                try
                {
                    var ret = aFunction();
                    transaction.Commit();
                    return ret;
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        private void DuringTransactionDoWithOutReturn(Action anAction)
        {
            using (var transaction = session.BeginTransaction())
            {
                try
                {
                    anAction();
                    transaction.Commit();
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}