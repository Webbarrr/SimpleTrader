using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace SimpleTrader.EntityFramework
{
    public class SimpleTraderDbContextFactory : IDesignTimeDbContextFactory<SimpleTraderDbContext>
    {
        public SimpleTraderDbContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<SimpleTraderDbContext>();
            options.UseSqlServer("server=localhost;database=SimpleTraderDB;trusted_connection=true;");

            return new SimpleTraderDbContext(options.Options);
        }
    }
}