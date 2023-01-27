using BloggerWay.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BloggerWay.Data.Concrete.EntityFramework.Contexts
{
    public class BloggerWayContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Server=127.0.0.1;Port=5432;Database=BloggerWay;User Id=postgres;Password=123;");
        }




    }
}
