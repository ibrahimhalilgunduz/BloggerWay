using BloggerWay.Entities.ComplexTypes;
using BloggerWay.Entities.Dtos;
using BloggerWay.MVC.Helpers.Abstract;
using BloggerWay.Shared.Utilities.Extensions;
using BloggerWay.Shared.Utilities.Results.Abstract;
using BloggerWay.Shared.Utilities.Results.ComplexTypes;
using BloggerWay.Shared.Utilities.Results.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BloggerWay.MVC.Helpers.Concrete
{
    public class ImageHelper : IImageHelper
    {
        private readonly IWebHostEnvironment _env;
        private readonly ILogger<ImageHelper> _logger;
        private readonly string _wwwroot;
        private const string imgFolder = "img";
        private const string userImagesFolder = "userImages";
        private const string postImagesFolder = "postImages";

        public ImageHelper(IWebHostEnvironment env, ILogger<ImageHelper> logger)
        {
            _env = env;
            _logger = logger;
            _wwwroot = _env.WebRootPath;
        }

        public async Task<IDataResult<ImageUploadedDto>> Upload(string name, IFormFile pictureFile, PictureType pictureType, string folderName = null)
        {
            try
            {
                folderName ??= pictureType == PictureType.User ? userImagesFolder : postImagesFolder;

                if (!Directory.Exists($"{_wwwroot}/{imgFolder}/{folderName}"))
                {
                    Directory.CreateDirectory($"{_wwwroot}/{imgFolder}/{folderName}");
                }

                string oldFileName = Path.GetFileNameWithoutExtension(pictureFile.FileName);
                string fileExtension = Path.GetExtension(pictureFile.FileName);

                Regex regex = new Regex("[*'\",._&#^@]");
                name = regex.Replace(name, string.Empty);

                DateTime dateTime = DateTime.Now;
                string newFileName = $"{name}_{dateTime.FullDateAndTimeStringWithUnderscore()}{fileExtension}";
                var path = Path.Combine($"{_wwwroot}/{imgFolder}/{folderName}", newFileName);

                await using (var stream = new FileStream(path, FileMode.Create))
                {
                    await pictureFile.CopyToAsync(stream);
                }

                string nameMessage = pictureType == PictureType.User
                    ? $"{name} adlı kullanıcının resmi başarıyla yüklendi."
                    : $"{name} adlı makalenin resmi başarıyla yüklendi.";

                _logger.LogInformation("Resim başarıyla yüklendi: {Path}", path);

                return new DataResult<ImageUploadedDto>(ResultStatus.Success, nameMessage, new ImageUploadedDto
                {
                    FullName = $"{folderName}/{newFileName}",
                    OldName = oldFileName,
                    Extension = fileExtension,
                    FolderName = folderName,
                    Path = path,
                    Size = pictureFile.Length
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Resim yükleme sırasında bir hata oluştu: {Name}", name);
                return new DataResult<ImageUploadedDto>(ResultStatus.Error, "Resim yükleme sırasında bir hata oluştu.", null);
            }
        }

        public IDataResult<ImageDeletedDto> Delete(string pictureName)
        {
            try
            {
                var fileToDelete = Path.Combine($"{_wwwroot}/{imgFolder}/", pictureName);
                if (File.Exists(fileToDelete))
                {
                    var fileInfo = new FileInfo(fileToDelete);
                    var imageDeletedDto = new ImageDeletedDto
                    {
                        FullName = pictureName,
                        Extension = fileInfo.Extension,
                        Path = fileInfo.FullName,
                        Size = fileInfo.Length
                    };
                    File.Delete(fileToDelete);
                    _logger.LogInformation("Resim başarıyla silindi: {Path}", fileToDelete);
                    return new DataResult<ImageDeletedDto>(ResultStatus.Success, imageDeletedDto);
                }
                else
                {
                    _logger.LogWarning("Silinmek istenen resim bulunamadı: {PictureName}", pictureName);
                    return new DataResult<ImageDeletedDto>(ResultStatus.Error, "Böyle bir resim bulunamadı.", null);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Resim silme sırasında bir hata oluştu: {PictureName}", pictureName);
                return new DataResult<ImageDeletedDto>(ResultStatus.Error, "Resim silme sırasında bir hata oluştu.", null);
            }
        }
    }
}
