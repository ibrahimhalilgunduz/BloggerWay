using BloggerWay.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BloggerWay.Data.Concrete.EntityFramework.Mappings
{
    public class RoleMap : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id).ValueGeneratedOnAdd();
            builder.Property(r => r.Name).HasMaxLength(30);
            builder.Property(r => r.Description).IsRequired(true).HasMaxLength(250);
            builder.Property(r => r.CreatedByName).IsRequired(true).HasMaxLength(50);
            builder.Property(r => r.ModifiedByName).IsRequired(true).HasMaxLength(50);
            builder.Property(r => r.CreatedDate).IsRequired(true);
            builder.Property(r => r.ModifiedDate).IsRequired(true);
            builder.Property(r => r.IsActive).IsRequired(true);
            builder.Property(r => r.IsDeleted).IsRequired(true);
            builder.Property(r => r.Note).HasMaxLength(500);
            builder.ToTable("Roles");
            builder.HasData(new Role
            {
                Id = 1,
                Name = "Admin",
                Description = "Admin Rolü, tüm haklara sahiptir",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedByName = "InıtialCreate",
                ModifiedDate = DateTime.Now,
                Note = "Admin Rolüdür"

            });

        }
    }
}
