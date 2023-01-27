using BloggerWay.Data.Abstract;
using BloggerWay.Data.Concrete.EntityFramework.Contexts;
using BloggerWay.Entities.Concrete;
using BloggerWay.Shared.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BloggerWay.Data.Concrete.EntityFramework.Repositories
{
    public class EFCategoryRepository : EfEntityRepositoryBase<Category>, ICategoryRepository
    {
        public EFCategoryRepository(DbContext context) : base(context)
        {

        }

        public async Task<Category> GetById(int categoryId)
        {
            return await BloggerWayContext.Categories.SingleOrDefaultAsync(c => c.Id == categoryId);
        }
        private BloggerWayContext BloggerWayContext
        {
            get { return _context as BloggerWayContext; }
        }
    }
}
