using BloggerWay.Entities.Concrete;

namespace BloggerWay.Entities.Dtos
{
    public class UserDto : DtoGetBase
    {
        public User User { get; set; }
    }
}
