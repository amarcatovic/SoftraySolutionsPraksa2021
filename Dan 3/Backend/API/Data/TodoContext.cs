using API.Data.EntityConfig;
using API.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class TodoContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        public DbSet<TodoCategory> TodoCategories { get; set; }

        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TodoConfig());
            modelBuilder.ApplyConfiguration(new TodoCategoryConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
