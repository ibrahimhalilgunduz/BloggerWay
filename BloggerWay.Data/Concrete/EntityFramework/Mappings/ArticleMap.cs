using BloggerWay.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BloggerWay.Data.Concrete.EntityFramework.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {

            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.Title).HasMaxLength(100).IsRequired(true);
            builder.Property(a => a.Content).HasColumnType("varchar(9999)").IsRequired(true);
            builder.Property(a => a.Date).IsRequired(true);
            builder.Property(a => a.SeoAuthor).IsRequired(true).HasMaxLength(50);
            builder.Property(a => a.SeoDescription).IsRequired(true).HasMaxLength(150);
            builder.Property(a => a.SeoTags).IsRequired().HasMaxLength(70);
            builder.Property(a => a.ViewCount).IsRequired(true);
            builder.Property(a => a.CommentCount).IsRequired(true);
            builder.Property(a => a.Thumbnail).IsRequired(true).HasMaxLength(250);
            builder.Property(a => a.CreatedByName).IsRequired(true).HasMaxLength(50);
            builder.Property(a => a.ModifiedByName).IsRequired(true).HasMaxLength(50);
            builder.Property(a => a.CreatedDate).IsRequired(true);
            builder.Property(a => a.ModifiedDate).IsRequired(true);
            builder.Property(a => a.IsActive).IsRequired(true);
            builder.Property(a => a.IsDeleted).IsRequired(true);
            builder.Property(a => a.Note).HasMaxLength(500);
            builder.HasOne<Category>(a => a.Category).WithMany(c => c.Articles).HasForeignKey(a => a.CategoryId);
            builder.HasOne<User>(a => a.User).WithMany(u => u.Articles).HasForeignKey(a => a.UserId);
            builder.ToTable("Articles");
            builder.HasData(
                new Article
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "C# .Net5 özellikleri ",
                    Content = " Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    Thumbnail = "Default.jpg",
                    SeoDescription = "C#, C#9 ,.NET5 Yenilikleri",
                    SeoTags = "C#, C#9 .NET5 , .NET Framework, .NET Core",
                    SeoAuthor = "Ali Veli",
                    Date = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "C# .Net5 özellikleri",
                    UserId = 1,
                    ViewCount = 12,
                    CommentCount = 1,
                },
                new Article
                {
                    Id = 2,
                    CategoryId = 2,
                    Title = "C++ 11 ve 19 özellikleri ",
                    Content = " Bir okuyucunun, sayfa düzenine bakarken sayfanın okunabilir içeriği tarafından dikkatinin dağılacağı uzun süredir bilinen bir gerçektir. Lorem Ipsum kullanmanın amacı, 'İçerik burada, içerik burada' kullanılmasının aksine, harflerin az çok normal dağılımına sahip olması ve okunabilir İngilizce gibi görünmesini sağlamasıdır. Birçok masaüstü yayıncılık paketi ve web sayfası düzenleyicisi artık varsayılan model metni olarak Lorem Ipsum'u kullanıyor ve 'lorem ipsum' araması, henüz emekleme aşamasında olan birçok web sitesini ortaya çıkaracaktır. Yıllar içinde, bazen tesadüfen, bazen de bilerek (enjekte edilmiş mizah ve benzeri) çeşitli versiyonlar gelişti.",
                    Thumbnail = "Default.jpg",
                    SeoDescription = "C++ 11 ve 19 özellikleri",
                    SeoTags = "C++ 11 ve 19 özellikleri",
                    SeoAuthor = "Ali Veli",
                    Date = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "C++ 11 ve 19 özellikleri",
                    UserId = 1,
                    ViewCount = 295,
                    CommentCount = 1,
                },
                new Article
                {
                    Id = 3,
                    CategoryId = 3,
                    Title = "JavaScript ES2019 ES2020 özellikleri ",
                    Content = " Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, " +
                    "looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, Lorem ipsum dolor sit amet.., comes from a line in section 1.10.32.The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham..",
                    Thumbnail = "Default.jpg",
                    SeoDescription = "JavaScript ES2019 ES2020 özellikleri ",
                    SeoTags = "JavaScript ES2019 ES2020 özellikleri ",
                    SeoAuthor = "Ali Veli",
                    Date = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "JavaScript ES2019 ES2020 özellikleri ",
                    UserId = 1,
                    ViewCount = 100,
                    CommentCount = 1,

                }
                ); ;
        }
    }
}
