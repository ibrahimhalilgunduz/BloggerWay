using BloggerWay.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BloggerWay.Data.Concrete.EntityFramework.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Name).IsRequired(true).HasMaxLength(70);
            builder.Property(c => c.Description).IsRequired().HasMaxLength(500);
            builder.Property(c => c.CreatedByName).IsRequired(true).HasMaxLength(50);
            builder.Property(c => c.ModifiedByName).IsRequired(true).HasMaxLength(50);
            builder.Property(c => c.CreatedDate).IsRequired(true);
            builder.Property(c => c.ModifiedDate).IsRequired(true);
            builder.Property(c => c.IsActive).IsRequired(true);
            builder.Property(c => c.IsDeleted).IsRequired(true);
            builder.Property(c => c.Note).HasMaxLength(500);
            builder.ToTable("Categories");

            builder.HasData(
            new Category
            {

                Name = "C#",
                Description = "C# Programlama Dili ile ilgili en güncel bilgiler.",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                Note = "C# Blog Kategorisi",
            },
            new Category
            {

                Name = "C++",
                Description = "C++ Programlama Dili ile ilgili en güncel bilgiler.",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                Note = "C++ Blog Kategorisi",
            },
             new Category
             {

                 Name = "JavaScript",
                 Description = "JavaScript Programlama Dili ile ilgili en güncel bilgiler.",
                 IsActive = true,
                 IsDeleted = false,
                 CreatedByName = "InitialCreate",
                 CreatedDate = DateTime.Now,
                 ModifiedByName = "InitialCreate",
                 ModifiedDate = DateTime.Now,
                 Note = "JavaScript Blog Kategorisi",
             }
            );

        }
    }
}
