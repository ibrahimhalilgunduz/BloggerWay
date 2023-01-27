using Microsoft.AspNetCore.Http;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BloggerWay.Entities.Dtos
{
    public class UserAddDto
    {
        [DisplayName("Kullanıcı Adı")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        [MaxLength(50, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        [MinLength(3, ErrorMessage = "{0} {1} karakterden az olmamalıdır.")]
        public string UserName { get; set; }
        [DisplayName("E-Posta Adresi")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        [MaxLength(100, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        [MinLength(3, ErrorMessage = "{0} {1} karakterden az olmamalıdır.")]
        [DataType(DataType.EmailAddress)]

        public string Email { get; set; }
        [DisplayName("Şifre")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        [MaxLength(30, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        [MinLength(5, ErrorMessage = "{0} {1} karakterden az olmamalıdır.")]
        [DataType(DataType.PhoneNumber)]

        public string Password { get; set; }
        [DisplayName("Resim")]
        [Required(ErrorMessage = "Lütfen bir {0}  seçiniz.")]
        [MaxLength(13, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]  //+90555555555 // 13 karakter
        [MinLength(13, ErrorMessage = "{0} {1} karakterden az olmamalıdır.")]
        [DataType(DataType.Upload)]
        public string PhoneNumber { get; set; }

        public IFormFile Picture { get; set; }
    }
}
