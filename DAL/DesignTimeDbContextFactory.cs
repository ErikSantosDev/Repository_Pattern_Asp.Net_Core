using System.IO;
using System.Reflection;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DAL
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<EstoqueContext>
    {
        private static IConfiguration _configuration;

        public static IConfiguration Configuration
        {
            get
            {
                if (_configuration != null) return _configuration;

                _configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("dbconfig.json", optional: true, reloadOnChange: true)
                    .AddJsonFile($"appsettings.{EnvName ?? "Production"}.json", optional: true, reloadOnChange: true)
                    .AddEnvironmentVariables()
                    .Build();

                return _configuration;
            }
        }

        public static string EnvName { get; private set; }

        public EstoqueContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<EstoqueContext>();
            var connectionString = Configuration.GetConnectionString("DefaultConnection");
            var migrationsAssembly = typeof(EstoqueContext).GetTypeInfo().Assembly.GetName().Name;

            builder.UseSqlServer(connectionString, b => b.MigrationsAssembly(migrationsAssembly));

            return new EstoqueContext(builder.Options);
        }
    }
}
