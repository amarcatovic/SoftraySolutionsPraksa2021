using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.EntityConfig
{
    public class TodoConfig : IEntityTypeConfiguration<Todo>
    {
        public void Configure(EntityTypeBuilder<Todo> builder)
        {
            builder.HasKey(t => t.Id);

            builder
                .Property(t => t.Title)
                .IsRequired();

            builder
                .HasOne(t => t.TodoCategory)
                .WithMany(td => td.Todos)
                .HasForeignKey(t => t.TodoCategoryId);
        }
    }
}
