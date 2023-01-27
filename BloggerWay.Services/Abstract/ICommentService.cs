using BloggerWay.Shared.Utilities.Results.Abstract;
using System.Threading.Tasks;

namespace BloggerWay.Services.Abstract
{
    public interface ICommentService
    {
        Task<IDataResult<int>> CountAsync();
        Task<IDataResult<int>> CountByNonDeletedAsync();
    }
}
