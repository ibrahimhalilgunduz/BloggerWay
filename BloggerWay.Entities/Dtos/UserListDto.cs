using BloggerWay.Entities.Concrete;
using BloggerWay.Shared.Entities.Abstract;
using System.Collections.Generic;

namespace BloggerWay.Entities.Dtos
{
    public class UserListDto : DtoGetBase
    {
        public IList<User> Users { get; set; }
    }
}
