using Microsoft.EntityFrameworkCore;

namespace DemoAPI.Model
{
    public class EFDataContext: DbContext
    {
        public DbSet<TodoEntity> TodoEntity { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=seminalwealth.com;Database=seminalwealth_com_todo;User Id=seminalwealth.com.todo;Password=t7c2M6*x;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoEntity>().HasKey(t => t.TodoId);
        }
    }
}
