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
            modelBuilder.Entity<Todo>()
                .HasKey(t => t.Id);

            modelBuilder.Entity<Todo>()
                .Property(t => t.Title)
                .IsRequired();

            modelBuilder.Entity<TodoCategory>()
                .HasKey(td => td.Id);

            modelBuilder.Entity<Todo>()
                .HasOne(t => t.TodoCategory)
                .WithMany(td => td.Todos)
                .HasForeignKey(t => t.TodoCategoryId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
