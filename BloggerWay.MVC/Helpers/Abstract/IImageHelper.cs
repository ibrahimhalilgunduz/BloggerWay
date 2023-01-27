using BloggerWay.Entities.Dtos;
using BloggerWay.Shared.Utilities.Results.Abstract;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace BloggerWay.MVC.Helpers.Abstract
{
    public interface IImageHelper
    {
        Task<IDataResult<ImageUploadedDto>> UploadUserImage(string userName, IFormFile pictureFile, string folderName = "userImages");
        IDataResult<ImageDeletedDto> Delete(string pictureName);
    }
}
