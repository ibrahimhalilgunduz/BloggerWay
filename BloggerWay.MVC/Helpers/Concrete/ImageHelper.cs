using BloggerWay.Entities.ComplexTypes;
using BloggerWay.Entities.Dtos;
using BloggerWay.MVC.Helpers.Abstract;
using BloggerWay.Shared.Utilities.Extensions;
using BloggerWay.Shared.Utilities.Results.Abstract;
using BloggerWay.Shared.Utilities.Results.ComplexTypes;
using BloggerWay.Shared.Utilities.Results.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BloggerWay.MVC.Helpers.Concrete
{
    public class ImageHelper : IImageHelper
    {
        private readonly IWebHostEnvironment _env;
        private readonly string _wwwroot;
        private const string imgFolder = "img";
        private const string userImagesFolder = "userImages";
        private const string postImagesFolder = "postImages";
        public ImageHelper(IWebHostEnvironment env)
        {
            _env = env;
            _wwwroot = _env.WebRootPath;
        }



        public async Task<IDataResult<ImageUploadedDto>> Upload(string name, IFormFile pictureFile, PictureType pictureType, string folderName = null)
        {
            /* Eğer folderName değişkeni null gelir ise o zaman resim tipine göre (PictureType) klasör adı ataması yapar. */
            folderName ??= pictureType == PictureType.User ? userImagesFolder : postImagesFolder;

            /* Eğer folderName değişkeni ile gelen klasör adı  mevcut değilse yeni bir klasör oluşturur. */
            if (!Directory.Exists($"{_wwwroot}/{imgFolder}/{folderName}"))
            {
                Directory.CreateDirectory($"{_wwwroot}/{imgFolder}/{folderName}");
            }

            /* Resimin yüklenme sırasındaki ilk adı oldFileName adlı değişkene atar. */
            string oldFileName = Path.GetFileNameWithoutExtension(pictureFile.FileName);
            string fileExtension = Path.GetExtension(pictureFile.FileName);


            Regex regex = new Regex("[*'\",._&#^@]");
            name = regex.Replace(name, string.Empty);


            DateTime dateTime = DateTime.Now;

            // Parametre ile gelen değerler kullanılarak yeni bir resim adı oluşturur.
            // Örn: AliVeli_578_1_44_15_4_12_2022.png

            string newFileName = $"{name}_{dateTime.FullDateAndTimeStringWithUnderscore()}{fileExtension}";

            /* yeni eklenen parametre ile yeni bir dosya yolu (path) oluşturur. */
            var path = Path.Combine($"{_wwwroot}/{imgFolder}/{folderName}", newFileName);

            /* oluşturulan yeni dosya yoluna resmi kopyalar. */
            await using (var stream = new FileStream(path, FileMode.Create))
            {
                await pictureFile.CopyToAsync(stream);
            }
            /* Resim tipine göre kullanıcı için bir mesaj oluşturur. */
            string nameMessage = pictureType == PictureType.User
                ? $"{name} adlı kullanıcının resimi başarıyla yüklenmiştir."
                : $"{name} adlı makalenin  resimi başarıyla yüklenmiştir.";

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

        public IDataResult<ImageDeletedDto> Delete(string pictureName)
        {
            var fileToDelete = Path.Combine($"{_wwwroot}/{imgFolder}/", pictureName);
            if (System.IO.File.Exists(fileToDelete))
            {
                var fileInfo = new FileInfo(fileToDelete);
                var imageDeletedDto = new ImageDeletedDto
                {
                    FullName = pictureName,
                    Extension = fileInfo.Extension,
                    Path = fileInfo.FullName,
                    Size = fileInfo.Length
                };
                System.IO.File.Delete(fileToDelete);
                return new DataResult<ImageDeletedDto>(ResultStatus.Success, imageDeletedDto);
            }
            else
            {
                return new DataResult<ImageDeletedDto>(ResultStatus.Error, $"Böyle bir resim bulunamadı.", null);
            }
        }
    }
}
