using BloggerWay.Entities.Concrete;
using BloggerWay.Shared.Entities.Abstract;

namespace BloggerWay.Entities.Dtos
{
    public class UserDto : DtoGetBase
    {
        public User User { get; set; }
    }
}
