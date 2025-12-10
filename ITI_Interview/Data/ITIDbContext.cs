using Microsoft.EntityFrameworkCore;

namespace ITI_Interview.Data
{
    public class ITIDbContext : DbContext
    {
        public DbSet<Empolyee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public ITIDbContext(DbContextOptions<ITIDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
