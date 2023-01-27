using BloggerWay.Data.Abstract;
using BloggerWay.Entities.Concrete;
using BloggerWay.Shared.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace BloggerWay.Data.Concrete.EntityFramework.Repositories
{
    public class EFCommentRepository : EfEntityRepositoryBase<Comment>, ICommentRepository
    {
        public EFCommentRepository(DbContext context) : base(context)
        {
        }
    }
}
