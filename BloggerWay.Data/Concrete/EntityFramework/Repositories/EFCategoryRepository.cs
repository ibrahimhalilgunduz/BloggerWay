using BloggerWay.Data.Abstract;
using BloggerWay.Entities.Concrete;
using BloggerWay.Shared.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace BloggerWay.Data.Concrete.EntityFramework.Repositories
{
    public class EFCategoryRepository : EfEntityRepositoryBase<Category>, ICategoryRepository
    {
        public EFCategoryRepository(DbContext context) : base(context)
        {

        }
    }
}
