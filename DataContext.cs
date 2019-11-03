using Microsoft.EntityFrameworkCore;

namespace DockerTest
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {}

        public DbSet<TestModel> TestModelItems { get; set;}
    }
}