using Microsoft.EntityFrameworkCore;
using mvc_first_task.Models;

namespace mvc_first_task.Context
{
    public class SystaemContext : DbContext
    {
        public SystaemContext(DbContextOptions<SystaemContext> option) : base(option) { }
        public DbSet<Models.Employees> Employees { get; set; }
        public DbSet<Models.Department> Departments { get; set; }
        public DbSet<Models.Manager> Managers { get; set; }
        public DbSet<Models.Tasks> Tasks { get; set; }
        public DbSet<Models.Feadbacks> Feadbacks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Feadbacks>()
               .HasOne(f => f.SentTo)
               .WithMany()
               .HasForeignKey(f => f.SentToID)
               .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }


    }
}
