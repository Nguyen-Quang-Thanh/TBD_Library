using System;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TBD_library.Data.EF
{
    internal class TBD_libraryDbContextFactory : IDesignTimeDbContextFactory<TBD_libraryDBContext>
    {
        public TBD_libraryDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration.GetConnectionString("TBD_connectiton");

            var optionsBuilder = new DbContextOptionsBuilder<TBD_libraryDBContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new TBD_libraryDBContext(optionsBuilder.Options);
        }
    }
}
