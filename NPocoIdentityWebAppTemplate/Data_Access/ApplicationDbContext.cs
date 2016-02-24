using System;
using NPoco;
using Pacal.NPoco_Idenity_Provider;

namespace NPocoIdentityWebAppTemplate.Data_Access
{
    public class ApplicationDbContext : IDisposable
    {
        public DataProvider Database { get; private set; }
        
        public ApplicationDbContext()
        {
            var connectionString =  System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            Database = new DataProvider(connectionString, DatabaseType.SqlServer2012);
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public ApplicationDbContext Get()
        {
            return Database != null ? this : new ApplicationDbContext();
        }

        public void Dispose()
        {
            Database.Dispose();
            Database = null;
        }
    }
}