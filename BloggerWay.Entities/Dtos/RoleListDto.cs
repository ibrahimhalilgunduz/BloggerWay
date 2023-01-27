using BloggerWay.Entities.Concrete;
using System.Collections.Generic;

namespace BloggerWay.Entities.Dtos
{
    public class RoleListDto
    {
        public IList<Role> Roles { get; set; }
    }
}
