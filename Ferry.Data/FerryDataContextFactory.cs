using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Reflection;

namespace Ferry.Data
{
    public class FerryDataContextFactory : IDesignTimeDbContextFactory<FerryDataContext>
    {
        public FerryDataContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<FerryDataContext>();
            builder.UseSqlServer("Server= .\\;Database=Ferry;Trusted_Connection=True;",
                optionsBuilder => optionsBuilder.MigrationsAssembly(typeof(OnSolveMobileContextFactory).GetTypeInfo().Assembly.GetName().Name));

            return new FerryDataContext(builder.Options);
        }
    }
}
