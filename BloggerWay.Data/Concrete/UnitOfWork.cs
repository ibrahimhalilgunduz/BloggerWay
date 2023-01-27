using BloggerWay.Data.Abstract;
using BloggerWay.Data.Concrete.EntityFramework.Contexts;
using BloggerWay.Data.Concrete.EntityFramework.Repositories;
using System.Threading.Tasks;

namespace BloggerWay.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BloggerWayContext _context;
        private EFArticleRepository _articleRepository;
        private EFCategoryRepository _categoryRepository;
        private EFCommentRepository _commentRepository;

        public UnitOfWork(BloggerWayContext context)
        {
            _context = context;
        }

        public IArticleRepository Articles => _articleRepository ?? new EFArticleRepository(_context);
        public ICategoryRepository Categories => _categoryRepository ?? new EFCategoryRepository(_context);
        public ICommentRepository Comments => _commentRepository ?? new EFCommentRepository(_context);
        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
    }
}
