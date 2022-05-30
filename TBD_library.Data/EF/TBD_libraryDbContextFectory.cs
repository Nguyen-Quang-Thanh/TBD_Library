using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace TBD_library.Data.EF
{
    public class TBD_libraryDbContextFectory : IDesignTimeDbContextFactory<TBD_libraryDBContext>
    {
        public TBD_libraryDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration.GetConnectionString("TBD_libraryDb");

            var optionBuildel = new DbContextOptionsBuilder<TBD_libraryDBContext>();
            optionBuildel.UseSqlServer(connectionString);

            return new TBD_libraryDBContext(optionBuildel.Options);
        }
    }
}
