using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace _03_StudentManager_MVC.Data
{
    // This class is ONLY used by EF CLI at design time (migrations)
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            // Use same connection string as in appsettings.json
            optionsBuilder.UseSqlite("Data Source=students.db");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}