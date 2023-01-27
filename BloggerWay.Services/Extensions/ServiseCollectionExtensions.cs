using BloggerWay.Data.Abstract;
using BloggerWay.Data.Concrete;
using BloggerWay.Data.Concrete.EntityFramework.Contexts;
using BloggerWay.Entities.Concrete;
using BloggerWay.Services.Abstract;
using BloggerWay.Services.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace BloggerWay.Services.Extensions
{
    public static class ServiseCollectionExtensions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<BloggerWayContext>();
            serviceCollection.AddIdentity<User, Role>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 10;
                options.Password.RequiredUniqueChars = 0;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;

                options.User.AllowedUserNameCharacters =
             "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = true;

            }).AddEntityFrameworkStores<BloggerWayContext>();
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            serviceCollection.AddScoped<ICategoryService, CategoryManager>();
            serviceCollection.AddScoped<IArticleService, ArticleManager>();
            return serviceCollection;

        }
    }
}
