using BloggerWay.Entities.Dtos;
using BloggerWay.Shared.Utilities.Results.Abstract;
using System;
using System.Threading.Tasks;

namespace BloggerWay.Services.Abstract
{
    public interface ICategoryService
    {
        Task<IDataResult<CategoryDto>> Get(Guid categoryId);
        Task<IDataResult<CategoryUpdateDto>> GetCategoryUpdateDto(Guid categoryId);

        Task<IDataResult<CategoryListDto>> GetAll();
        Task<IDataResult<CategoryListDto>> GetAllByNonDeleted();
        Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAndActive();

        Task<IDataResult<CategoryDto>> Add(CategoryAddDto categoryAddDto, string createdByName);
        Task<IDataResult<CategoryDto>> Update(CategoryUpdateDto categoryUpdateDto, string modifiedByName);

        Task<IDataResult<CategoryDto>> Delete(Guid categoryId, string modifiedByName);
        Task<IResult> HardDelete(Guid categoryId);
    }
}
