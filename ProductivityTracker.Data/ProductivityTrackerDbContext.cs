using Microsoft.EntityFrameworkCore;
using ProductivityTracker.Data.Entities.Task;

namespace ProductivityTracker.Data
{
    public class ProductivityTrackerDbContext : DbContext
    {
        public ProductivityTrackerDbContext(DbContextOptions<ProductivityTrackerDbContext> options)
            : base(options)
        { }

        public DbSet<TaskItem> Tasks { get; set; }
    }
}
