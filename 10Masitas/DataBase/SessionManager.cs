using Microsoft.Ajax.Utilities;
using NHibernate;

namespace _10Masitas.DataBase
{
    public static class SessionManager
    {
        private static ISessionFactory _sessionFactory;

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }

        private static ISessionFactory CreateSessionFactory()
        {
            var configurationDbMappingAndSchema = ConfigurationMappingDataBase.ConfigureDbMappingAndSchema();

            return configurationDbMappingAndSchema.BuildSessionFactory();
        }

        private static ISessionFactory SessionFactory
        {
            get
            {
                _sessionFactory.IfNotNull(factory => factory);
                
                _sessionFactory = CreateSessionFactory();
                return _sessionFactory;
            }
        }
    }
}