using BloggerWay.Entities.Concrete;
using BloggerWay.Shared.Data.Abstract;
using System.Threading.Tasks;

namespace BloggerWay.Data.Abstract
{
    public interface ICategoryRepository : IEntityRepository<Category>
    {

        Task<Category> GetById(int categoryId);

    }



}
