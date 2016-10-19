using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Tool.hbm2ddl;
using NHibernate.Cfg;
using _10Masitas.Domain;

namespace _10Masitas.DataBase
{
    public static class ConfigurationMappingDataBase
    {
        public const string ServerDataBaseGlobal = "localhost";
        public const string DataBaseGlobal = "masitasTest";
        public const string UserDataBaseGlobal = "root";
        public const string PasswordDataBaseGlobal = "root";

        public static string DataBaseConeccionString()
        {
            return "Server=" + ServerDataBaseGlobal + ";" +
                "Database=" + DataBaseGlobal + ";" +
                "User ID=" + UserDataBaseGlobal + ";" +
                "Password=" + PasswordDataBaseGlobal + ";";
        }

        public static FluentConfiguration ConfigureDbMappingAndSchema()
        {
            return Fluently.Configure()
                .Database(MySQLConfiguration.Standard.ConnectionString(DataBaseConeccionString()))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Order>())
                .ExposeConfiguration(BuildSchema);
        }

        private static void BuildSchema(Configuration config)
        {
            new SchemaExport(config).Create(false, true); 
        }
    }
}
