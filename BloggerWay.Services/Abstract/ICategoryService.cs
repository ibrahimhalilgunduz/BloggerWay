using BloggerWay.Entities.Concrete;
using BloggerWay.Entities.Dtos;
using BloggerWay.Shared.Utilities.Results.Abstract;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BloggerWay.Services.Abstract
{
    public interface ICategoryService
    {
        Task<IDataResult<Category>> Get(int categoryId);
        Task<IDataResult<IList<Category>>> GetAll();
        Task<IResult> Add(CategoryAddDto categoryAddDto, string createdByName);
        Task<IResult> Update(CategoryUpdateDto categoryAddDto, string modifiedByName);

        Task<IResult> Delete(int categoryId);
        Task<IResult> HardDelete(int categoryId);
    }
}
