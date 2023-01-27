using BloggerWay.Entities.Concrete;
using System.Collections.Generic;

namespace BloggerWay.MVC.Areas.Admin.Models
{
    public class UserWithRolesViewModel
    {
        public User User { get; set; }
        public IList<string> Roles { get; set; }
    }
}
