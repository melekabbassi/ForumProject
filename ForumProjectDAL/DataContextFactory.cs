using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace ForumProjectDAL
{
    internal class DataContextFactory : IDesignTimeDbContextFactory<ForumProjectDbContext>
    {
        public ForumProjectDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ForumProjectDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ForumProjectDB;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new ForumProjectDbContext(optionsBuilder.Options);
        }
    }
}
