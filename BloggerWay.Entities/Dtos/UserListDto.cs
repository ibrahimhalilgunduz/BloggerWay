using BloggerWay.Entities.Concrete;
using System.Collections.Generic;

namespace BloggerWay.Entities.Dtos
{
    public class UserListDto : DtoGetBase
    {
        public IList<User> Users { get; set; }
    }
}
