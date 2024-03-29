﻿using BloggerWay.Data.Abstract;
using BloggerWay.Data.Concrete;
using BloggerWay.Data.Concrete.EntityFramework.Contexts;
using BloggerWay.Entities.Concrete;
using BloggerWay.Services.Abstract;
using BloggerWay.Services.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BloggerWay.Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection, string connectionString)
        {
            serviceCollection.AddDbContext<BloggerWayContext>(options => options.UseNpgsql(connectionString).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
            serviceCollection.AddIdentity<User, Role>(options =>
            {
                // User Password Options
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 5;
                options.Password.RequiredUniqueChars = 0;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                // User Username and Email Options
                options.User.AllowedUserNameCharacters =
             "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+$";
                options.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<BloggerWayContext>();
            serviceCollection.Configure<SecurityStampValidatorOptions>(options =>
            {
                options.ValidationInterval = TimeSpan.FromMinutes(15);
            });
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            serviceCollection.AddScoped<ICategoryService, CategoryManager>();
            serviceCollection.AddScoped<IArticleService, ArticleManager>();
            serviceCollection.AddScoped<ICommentService, CommentManager>();
            serviceCollection.AddSingleton<IMailService, MailManager>();
            return serviceCollection;
        }
    }
}
