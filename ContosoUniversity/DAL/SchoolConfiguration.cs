using System.Data.Entity;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.SqlServer;

namespace ContosoUniversity.DAL
{
    //The Entity Framework automatically runs the code it finds in a class that derives from DbConfiguration. 
    //You can use the DbConfiguration class to do configuration tasks in code that you would otherwise do in the Web.config file.
    public class SchoolConfiguration : DbConfiguration
    {
        public SchoolConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());

            DbInterception.Add(new SchoolInterceptorTransientErrors());
            DbInterception.Add(new SchoolInterceptorLogging());
        }
    }
}